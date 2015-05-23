using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BankManager.AppointmentServices;
using BankManager.UserServices;
using CommonUtils;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace BankManager
{
    public partial class MainForm : Form
    {
        private const string ApplicationName = "DSA Bank Appointments";

        private static readonly string[] Scopes =
        {
            CalendarService.Scope.Calendar, // Manage calendar
            CalendarService.Scope.CalendarReadonly // View  Calendar
        };

        private static UserCredential _credential;

        public MainForm()
        {
            InitializeComponent();
        }

        public static void CreateCalenderReminder(ReminderView notice, UserView manager, UserView currUser)
        {
            try
            {
                var entry = new Event();
                entry.Summary = notice.Title;
                entry.Description = notice.Content;
                entry.Location = notice.Location;
                entry.Start = new EventDateTime();
                entry.Start.DateTime = notice.StartDate;
                entry.End = new EventDateTime();
                entry.End.DateTime = notice.EndDate;
                entry.Status = "confirmed";
                entry.GuestsCanInviteOthers = false;

                //Reminder
                entry.Reminders = new Event.RemindersData();
                entry.Reminders.UseDefault = false;
                var reminder = new EventReminder();
                reminder.Method = "email";
                reminder.Minutes = 60;
                entry.Reminders.Overrides = new List<EventReminder>();
                entry.Reminders.Overrides.Add(reminder);

                //Attendees
                entry.Attendees = new List<EventAttendee>
                {
                    new EventAttendee
                    {
                        DisplayName = manager.FirstName + " " + manager.MiddleInitial + " " + manager.LastName,
                        Email = manager.Email,
                        Organizer = true,
                        Resource = false,
                        ResponseStatus = "accepted",
                        AdditionalGuests = 0
                    },
                    new EventAttendee
                    {
                        DisplayName = currUser.FirstName + " " + currUser.MiddleInitial + " " + currUser.LastName,
                        Email = currUser.Email,
                        Organizer = false,
                        Resource = false,
                        ResponseStatus = "accepted",
                        AdditionalGuests = 0
                    }
                };
                notice.Service.Events.Insert(entry,
                    "icvdlnmegdb2o5d7f45v6rhth4@group.calendar.google.com").Execute();
            }
            catch
            {
                throw new Exception("Failed to set google calender reminder");
            }
        }

        private static void ReminderNotification(AppointmentView model, UserServicesClient userClient,
            UserView currentUser)
        {
            using (var stream = new FileStream("client_secret.json", FileMode.Open,
                FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                credPath = Path.Combine(credPath, ".credentials");

                _credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                var service = new CalendarService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = _credential,
                    ApplicationName = ApplicationName,
                });

                model.SuggestedDate = model.SuggestedDate + model.SuggestedTime;
                DateTime endDate;
                if (model.Duration == "30 mins")
                {
                    endDate = model.SuggestedDate.AddMinutes(30);
                }
                else if (model.Duration.Contains("1 hour"))
                {
                    endDate = model.SuggestedDate.AddMinutes(60);
                }
                else
                {
                    endDate = model.SuggestedDate.AddMinutes(90);
                }

                var rem = new ReminderView();
                rem.Service = service;
                rem.Title = "Appointment with " + currentUser.FirstName + " " + currentUser.MiddleInitial + " " +
                            currentUser.LastName;
                rem.Content = model.Description;
                rem.Location = "Paola Branch";
                rem.StartDate = model.SuggestedDate;
                rem.EndDate = endDate;

                UserView manager = userClient.ReadByUsername("test0001");
                CreateCalenderReminder(rem, manager, currentUser);
            }
        }

        private void appointmentDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in appointmentDataGrid.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    if (id != 0)
                    {
                        using (var client = new AppointmentServicesClient())
                        {
                            client.Delete(id);
                        }
                    }
                    appointmentDataGrid.Rows.Remove(row);
                }
            }
        }

        private string AppointmentDetailTable(AppointmentView model)
        {
            var table = new StringBuilder();
            table.AppendLine(
                "<table style='border-collapse:collapse;border:1px solid black;border-spacing:0;width:100%'>");
            table.AppendLine(
                "<thead><tr style='border-bottom:1px solid black'><th style='text-align:left;'>Attribute</th><th style='text-align:left;border-left:1px solid black'>Value</th></tr></thead>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td style='text-align:left;width:30%;'> ID </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" + model.ID + "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td> Username </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" + model.Username +
                             "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td> Suggested Date </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" +
                             model.SuggestedDate.ToShortDateString() + "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td> Suggested Time </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" + model.SuggestedTime +
                             "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td> Duration </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" + model.Duration +
                             "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td> Description </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" + model.Description +
                             "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("<tr style='border-bottom:1px solid black'>");
            table.AppendLine(" <td> Status </td>");
            table.AppendLine(" <td style='text-align:left;width:70%;border-left:1px solid black'>" +
                             (model.IsAccepted == true ? "Accepted" : "Rejected") + "</td>");
            table.AppendLine("</tr>");
            table.AppendLine("</table>");
            return table.ToString();
        }

        private void bttnLoadRecords_Click(object sender, EventArgs e)
        {
            appointmentDataGrid.DataSource = null;
            appointmentDataGrid.Rows.Clear();

            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;

            if (drpAppointmentState.SelectedIndex == 0)
            {
                using (var client = new AppointmentServicesClient())
                {
                    appointmentViewBindingSource.DataSource = client.ListAppointments();
                    appointmentDataGrid.DataSource = appointmentViewBindingSource;
                }
            }
            else if (drpAppointmentState.SelectedIndex == 1)
            {
                using (var client = new AppointmentServicesClient())
                {
                    if (start.Date != end.Date)
                    {
                        appointmentViewBindingSource.DataSource = client.FilterAppointmentList(true, start, end);
                    }
                    else
                    {
                        appointmentViewBindingSource.DataSource = client.FilterAppointmentList(true, null, null);
                    }
                    appointmentDataGrid.DataSource = appointmentViewBindingSource;
                }
            }
            else if (drpAppointmentState.SelectedIndex == 3)
            {
                using (var client = new AppointmentServicesClient())
                {
                    if (start.Date != end.Date)
                    {
                        appointmentViewBindingSource.DataSource = client.FilterAppointmentList(false, start, end);
                    }
                    else
                    {
                        appointmentViewBindingSource.DataSource = client.FilterAppointmentList(false, null, null);
                    }
                    appointmentDataGrid.DataSource = appointmentViewBindingSource;
                }
            }
            else
            {
                using (var client = new AppointmentServicesClient())
                {
                    if (start.Date != end.Date)
                    {
                        appointmentViewBindingSource.DataSource = client.FilterAppointmentList(null, start, end);
                    }
                    else
                    {
                        appointmentViewBindingSource.DataSource = client.FilterAppointmentList(null, null, null);
                    }
                    appointmentDataGrid.DataSource = appointmentViewBindingSource;
                }
            }
        }

        private string CreateEmailHtml(AppointmentView model, string fullName, string justification = "")
        {
            var html = new StringBuilder();
            if (model.IsAccepted != null)
            {
                html.AppendLine(
                    "<html><head><style type='text/css'>body{border-collapse:collapse;border: 0 solid gray;width:100%;}" +
                    "a:link,a:active {color: #1155CC;" +
                    "text-decoration: none}a:hover {text-decoration: underline;cursor: pointer}a:visited {color: #6611CC}img {border: 0px}pre {" +
                    "white-space: pre;white-space: -moz-pre-wrap;white-space: -o-pre-wrap;white-space: pre-wrap;word-wrap: break-word;" +
                    "max-width: 800px;overflow: auto;}</style></head>");
                html.AppendLine("<body>");
                html.AppendLine(
                    "<table style='border-collapse:collapse;border-spacing:0;display:table;table-layout:fixed;width:100%;min-width:620px;background-color:#f6f9fb'><tbody><tr>");
                html.AppendLine(
                    "<td style='padding-top:0;padding-bottom:0;padding-left:0;padding-right:0;vertical-align:top'><center>");
                html.AppendLine("<table style='border-collapse:collapse;border-spacing:0;width:100%'><tbody><tr>");
                html.AppendLine(
                    "<td style='padding-top:8px;padding-bottom:8px;padding-left:32px;padding-right:32px;vertical-align:top;font-size:11px;font-weight:400;" +
                    "letter-spacing:0.01em;line-height:17px;width:50%;color:#b3b3b3;text-align:left;font-family:sans-serif'></td>" +
                    "<td style='padding-top:8px;padding-bottom:8px;padding-left:32px;padding-right:32px;vertical-align:top;font-size:11px;font-weight:400;" +
                    "letter-spacing:0.01em;line-height:17px;width:50%;color:#b3b3b3;text-align:right;font-family:sans-serif'>" +
                    "<div>No Images? <a style='font-weight:700;letter-spacing:0.03em;text-decoration:none;color:#b3b3b3'>Click here</a></div>" +
                    "</td></tr></tbody></table>");
                html.AppendLine(
                    "<table style='border-collapse:collapse;border-spacing:0;Margin-left:auto;Margin-right:auto;width:600px'><tbody><tr>");
                html.AppendLine(
                    "<td style='padding-top:16px;padding-bottom:32px;padding-left:0;padding-right:0;vertical-align:top;" +
                    "font-size:24px;line-height:32px;letter-spacing:-0.01em;color:#2e3b4e;font-family:Cabin,Avenir,sans-serif!important' " +
                    "align='center'><center><div><img style='border-left-width:0;border-top-width:0;border-bottom-width:0;" +
                    "border-right-width:0;display:block;Margin-left:auto;Margin-right:auto;max-width:225px' " +
                    "src='cid:logo' alt='' height='134' width='150'></div></center></td>");
                html.AppendLine("</tr></tbody></table>");
                html.AppendLine(
                    "<table style='border-collapse:collapse;border-spacing:0;Margin-left:auto;Margin-right:auto;width:600px'><tbody>");
                html.AppendLine("<tr><div style='font-size:26px;line-height:26px'>&nbsp;</div>" +
                                "<td style='padding-top:0;padding-bottom:0;padding-left:0;padding-right:0;vertical-align:top;text-align:left'>" +
                                "<table style='border-collapse:collapse;border-spacing:0;width:100%'><tbody><tr> <td>");
                html.AppendLine(
                    "<h3 style='Margin-top:0;color:#2e3b4e;font-size:16px;Margin-bottom:16px;font-family:Cabin,Avenir,sans-serif!important;line-height:24px'>Dear " +
                    fullName + ",</h3>");

                if (model.IsAccepted == true)
                {
                    html.AppendLine(
                        "<h2 style='font-size:15px;font-weight:600;margin:0'>Your appointment request has been accepted.</h2>");
                    html.AppendLine(" <p> I received your appointment request for the " +
                                    model.SuggestedDate.ToShortDateString() +
                                    " at my office at our Paola branch. I am glad to inform you that your request has been accepted.</p>");
                }
                else
                {
                    html.AppendLine(
                        "<h2 style='font-size:15px;font-weight:600;margin:0'>Your appointment request has been rejected.</h2>");
                    html.AppendLine("<br/><p>I received your appointment request for the " +
                                    model.SuggestedDate.ToShortDateString() +
                                    " at my office at our Paola branch." +
                                    " I am sorry to inform you that your request has been rejected. " +
                                    justification +
                                    "</p><br/>");
                }
                html.AppendLine(AppointmentDetailTable(model));
                html.AppendLine("<br/>");
                html.AppendLine("</td></tr><tr><td><br/><div style='background:#eaeaea;text-align:center;padding:5px;'>");
                html.AppendLine(
                    "<p style='font-size:12px;margin:0; text-align:left;'>Sincerely, <strong>DSA Bank Manager</strong></p></div>");
                html.AppendLine(
                    " <p style='color:red;font-weight:bold;'>This is an automatic e-mail message generated by the DSA Bank, Malta automated system." +
                    "Please do not reply to this e-mail.</p></td>");
                html.AppendLine(
                    "</tr></tbody></table><div style='font-size:26px;line-height:26px'>&nbsp;</div></td></tr></tbody></table>");
                html.AppendLine(
                    "<table style='border-collapse:collapse;border-spacing:0;width:100%;background-color:#f6f9fb'><tbody>" +
                    "<tr><td style='padding-top:60px;padding-bottom:55px;padding-left:0;padding-right:0;vertical-align:top' align='center'>");
                html.AppendLine("<table style='border-collapse:collapse;border-spacing:0;width:600px'><tbody>" +
                                "<tr><td style='padding-top:0;padding-bottom:22px;padding-left:5px;padding-right:0;" +
                                "vertical-align:top;font-size:11px;font-weight:400;letter-spacing:0.01em;line-height:17px;" +
                                "text-align:right;width:45%;color:#b3b3b3;font-family:sans-serif'>" +
                                "<div style='font-size:1px;line-height:20px;width:100%'>&nbsp;</div>" +
                                "<div><span><span><a style='font-weight:700;letter-spacing:0.03em;" +
                                "text-decoration:none;color:#b3b3b3'>Preferences</a><span> &nbsp;|&nbsp; </span>" +
                                "</span></span><span><a style='font-weight:700;letter-spacing:0.03em;text-decoration:none;color:#b3b3b3'>Unsubscribe</a>");
                html.AppendLine(" </span></div></td></tr></tbody></table></td></tr></tbody></table>");
                html.AppendLine("</center></td>");
                html.AppendLine("</tr></tbody></table>");
                html.AppendLine("</body></html>");
            }
            return html.ToString();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            appointmentViewBindingSource.EndEdit();
            if (!string.IsNullOrEmpty(iDTextBox.Text))
            {
                int id = Convert.ToInt32(iDTextBox.Text);
                using (var client = new AppointmentServicesClient())
                {
                    client.Delete(id);
                }
                appointmentViewBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show(@"There is no record to delete", @"Item Deletion", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
            }
        }

        private void EmailNotification(UserServicesClient userClient, AppointmentView model,
            AppointmentServicesClient client)
        {
            UserView u = userClient.ReadByUsername(model.Username);
            string fullName = string.Format("{0} {1} {2}", u.FirstName, u.MiddleInitial, u.LastName);
            string htmlString = "";
            if (isAcceptedCheckBox.Checked)
            {
                client.Response(model);

                htmlString = CreateEmailHtml(model, fullName);

                ReminderNotification(model, userClient, u);
            }
            else
            {
                var justificationDialog = new RejectionJustificationForm();
                if (justificationDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string justification = justificationDialog.txtReason.Text;
                    htmlString = CreateEmailHtml(model, fullName, justification);
                }
                justificationDialog.Dispose();
            }

            AlternateView htmlAlternateView =
                AlternateView.CreateAlternateViewFromString(htmlString, null, MediaTypeNames.Text.Html);

            var logo = new LinkedResource("logo.png", "image/png")
            {
                ContentId = "logo"
            };

            htmlAlternateView.LinkedResources.Add(logo);

            CommunicationUtil.SendEmail(u.Email, "DSA Bank Appointment Request", htmlAlternateView);
        }

        private void errorMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is ErrorLogForm);
            if (formToShow != null)
            {
                formToShow.Show();
                appointmentDataGrid.DataSource = null;
                appointmentDataGrid.Rows.Clear();
            }
            else
            {
                new ErrorLogForm().Show();
            }
            Hide();
        }

        private void eventMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is EventLogForm);
            if (formToShow != null)
            {
                formToShow.Show();
                appointmentDataGrid.DataSource = null;
                appointmentDataGrid.Rows.Clear();
            }
            else
            {
                new EventLogForm().Show();
            }
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is LoginForm);
            if (formToShow != null)
            {
                formToShow.Show();
                appointmentDataGrid.DataSource = null;
                appointmentDataGrid.Rows.Clear();
            }
            else
            {
                new LoginForm().Show();
            }
            Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpStatusDropdown();

            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            dateTimePickerStart.Value = result;
            dateTimePickerEnd.Value = result;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(iDTextBox.Text))
            {
                using (var client = new AppointmentServicesClient())
                {
                    var model = new AppointmentView
                    {
                        ID = Convert.ToInt32(iDTextBox.Text),
                        Username = usernameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        SuggestedDate = suggestedDateDateTimePicker.Value,
                        SuggestedTime = Convert.ToDateTime(suggestedTimeTextBox.Text).TimeOfDay,
                        Duration = durationTextBox.Text,
                        IsAccepted = isAcceptedCheckBox.Checked
                    };

                    var userClient = new UserServicesClient();

                    EmailNotification(userClient, model, client);
                }
                appointmentViewBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show(@"There is no record to edit",
                    @"Item Editing", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void SetUpStatusDropdown()
        {
            drpAppointmentState.Items.Add(new { Text = "Show All", Value = -1 });
            drpAppointmentState.Items.Add(new { Text = "Accepted", Value = 0 });
            drpAppointmentState.Items.Add(new { Text = "Pending", Value = 1 });
            drpAppointmentState.Items.Add(new { Text = "Rejected", Value = 2 });

            drpAppointmentState.DisplayMember = "Text";
            drpAppointmentState.ValueMember = "Value";
            drpAppointmentState.SelectedIndex = 0;
        }

        private void transactionHistoryMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is TransactionHistoryForm);
            if (formToShow != null)
            {
                formToShow.Show();
                appointmentDataGrid.DataSource = null;
                appointmentDataGrid.Rows.Clear();
            }
            else
            {
                new TransactionHistoryForm().Show();
            }
            Hide();
        }

    }
}