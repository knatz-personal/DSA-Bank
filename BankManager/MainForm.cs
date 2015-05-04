using System;
using System.Linq;
using System.Windows.Forms;
using BankManager.AppointmentServices;

namespace BankManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
                MessageBox.Show(@"There is no record to delete", @"Item Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
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
                Hide();

            }
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
                //CommunicationUtil.SendEmail()
                using (var client = new AppointmentServicesClient())
                {
                    client.Response(new AppointmentView()
                    {
                        ID = Convert.ToInt32(iDTextBox.Text),
                        Username = usernameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        SuggestedDate = suggestedDateDateTimePicker.Value,
                        SuggestedTime = Convert.ToDateTime(suggestedTimeTextBox.Text).TimeOfDay,
                        Duration = durationTextBox.Text,
                        IsAccepted = isAcceptedCheckBox.Checked
                    });
                }
                appointmentViewBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show(@"There is no record to edit", @"Item Editing", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
            new TransactionHistoryForm().Show();
            Hide();
        }
    }
}