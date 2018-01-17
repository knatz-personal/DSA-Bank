using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BankManager.LogServices;
using WcfServiceDSABank;

namespace BankManager
{
    public partial class EventLogForm : Form
    {
        public EventLogForm()
        {
            InitializeComponent();
        }

        private SortOrder _currentSortOrder;
        private ObservableCollection<EventView> _list;

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainForm);
            if (formToShow != null)
            {
                formToShow.Show();
                eventDataGrid.DataSource = null;
                eventDataGrid.Rows.Clear();
            }
            else
            {
                new MainForm().Show();
            }
            Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                eventViewBindingSource.EndEdit();
                if (!string.IsNullOrEmpty(iDTextBox.Text))
                {
                    int id = Convert.ToInt32(iDTextBox.Text);
                    try
                    {
                        using (var client = new LogServicesClient())
                        {
                            client.DeleteEvent(id);
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("An error occurred communicating over the network.");
                    }
                    eventViewBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"There is no record to delete", @"Item Deletion", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                eventDataGrid.DataSource = null;
                eventDataGrid.Rows.Clear();

                DateTime start = dateTimePickerStart.Value;
                DateTime end = dateTimePickerEnd.Value;
                if (start.Date != end.Date)
                {
                    try
                    {
                        using (var client = new LogServicesClient())
                        {
                            var list =
                                new ObservableCollection<EventView>(client.FilterEventsList(comboBoxSource.Text, start, end));
                            _list = list;
                            eventViewBindingSource.DataSource = list.ToBindingList();
                            _currentSortOrder = SortOrder.Descending;
                            eventDataGrid.Sort(eventDataGrid.Columns[1], ListSortDirection.Descending);
                            eventDataGrid.DataSource = eventViewBindingSource;
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("An error occurred communicating over the network.");
                    }
                }
                else
                {
                    try
                    {
                        using (var client = new LogServicesClient())
                        {
                            var list =
                                new ObservableCollection<EventView>(client.FilterEventsList(comboBoxSource.Text, null, null));
                            _list = list;
                            eventViewBindingSource.DataSource = list.ToBindingList();
                            _currentSortOrder = SortOrder.Descending;
                            eventDataGrid.Sort(eventDataGrid.Columns[1], ListSortDirection.Descending);
                            eventDataGrid.DataSource = eventViewBindingSource;
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("An error occurred communicating over the network.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is ErrorLogForm);
            if (formToShow != null)
            {
                formToShow.Show();
                eventDataGrid.DataSource = null;
                eventDataGrid.Rows.Clear();
            }
            else
            {
                new ErrorLogForm().Show();
            }
            Hide();
        }

        private void eventDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (_currentSortOrder == SortOrder.Descending)
                {
                    _currentSortOrder = SortOrder.Ascending;
                    eventDataGrid.Sort(eventDataGrid.Columns[1], ListSortDirection.Ascending);
                }
                else
                {
                    _currentSortOrder = SortOrder.Descending;
                    eventDataGrid.Sort(eventDataGrid.Columns[1], ListSortDirection.Descending);
                }
            }
        }

        private void eventDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    foreach (DataGridViewRow row in eventDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        if (id != 0)
                        {
                            try
                            {
                                using (var client = new LogServicesClient())
                                {
                                    client.DeleteEvent(id);
                                }
                            }
                            catch (Exception)
                            {
                                throw new Exception("An error occurred communicating over the network.");
                            }
                        }
                        eventDataGrid.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EventLogForm_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            dateTimePickerStart.Value = result;
            dateTimePickerEnd.Value = result;
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
                eventDataGrid.DataSource = null;
                eventDataGrid.Rows.Clear();
            }
            else
            {
                new LoginForm().Show();
            }
            Hide();
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is TransactionHistoryForm);
            if (formToShow != null)
            {
                formToShow.Show();
                eventDataGrid.DataSource = null;
                eventDataGrid.Rows.Clear();
            }
            else
            {
                new TransactionHistoryForm().Show();
            }
            Hide();
        }
    }
}