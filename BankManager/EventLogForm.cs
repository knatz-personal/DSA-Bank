using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BankManager.LogServices;
using BankManager.TransactionServices;
using SortOrder = BankManager.TransactionServices.SortOrder;

namespace BankManager
{
    public partial class EventLogForm : Form
    {
        private ObservableCollection<EventView> _list;
        private SortOrder _currentSortOrder;

        public EventLogForm()
        {
            InitializeComponent();
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

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            eventDataGrid.DataSource = null;
            eventDataGrid.Rows.Clear();

            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;
            if (start.Date != end.Date)
            {
                using (var client = new LogServicesClient())
                {
                    var list = new ObservableCollection<EventView>(client.FilterEventsList(comboBoxSource.Text,start, end));
                    _list = list;
                    eventViewBindingSource.DataSource = list.ToBindingList();
                    _currentSortOrder = SortOrder.Descending;
                    eventDataGrid.Sort(eventDataGrid.Columns[1], ListSortDirection.Descending);
                    eventDataGrid.DataSource = eventViewBindingSource;
                }

            }
            else
            {
                using (var client = new LogServicesClient())
                {
                    var list = new ObservableCollection<EventView>(client.FilterEventsList(comboBoxSource.Text, null, null));
                    _list = list;
                    eventViewBindingSource.DataSource = list.ToBindingList();
                    _currentSortOrder = SortOrder.Descending;
                    eventDataGrid.Sort(eventDataGrid.Columns[1], ListSortDirection.Descending);
                    eventDataGrid.DataSource = eventViewBindingSource;
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            eventViewBindingSource.EndEdit();
            if (!string.IsNullOrEmpty(iDTextBox.Text))
            {
                int id = Convert.ToInt32(iDTextBox.Text);
                using (var client = new LogServicesClient())
                {
                    client.DeleteEvent(id);
                }
                eventViewBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show(@"There is no record to delete", @"Item Deletion", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
            }
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

        private void eventDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in eventDataGrid.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    if (id != 0)
                    {
                        using (var client = new LogServicesClient())
                        {
                            client.DeleteEvent(id);
                        }
                    }
                    eventDataGrid.Rows.Remove(row);
                }
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

        private void EventLogForm_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            dateTimePickerStart.Value = result;
            dateTimePickerEnd.Value = result;
            /*
            using (var client = new LogServicesClient())
            {
                var list = new AutoCompleteStringCollection();
                list.AddRange(client.ListUsernames().ToArray());
                comboBoxUsername.AutoCompleteCustomSource = list;
            }*/
        }


    }
}