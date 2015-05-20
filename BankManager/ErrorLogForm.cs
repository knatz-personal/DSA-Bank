using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BankManager.LogServices;

namespace BankManager
{
    public partial class ErrorLogForm : Form
    {
        private SortOrder _currentSortOrder;
        private ObservableCollection<ErrorView> _list;

        public ErrorLogForm()
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
                errorDataGrid.DataSource = null;
                errorDataGrid.Rows.Clear();
            }
            else
            {
                new LoginForm().Show();
            }
            Hide();
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            errorDataGrid.DataSource = null;
            errorDataGrid.Rows.Clear();

            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;
            if (start.Date != end.Date)
            {
                using (var client = new LogServicesClient())
                {
                    var list =
                        new ObservableCollection<ErrorView>(client.FilterErrorsList(comboBoxQuery.Text, start, end));
                    _list = list;
                    errorViewBindingSource.DataSource = list.ToBindingList();
                    _currentSortOrder = SortOrder.Descending;
                    errorDataGrid.Sort(errorDataGrid.Columns[1], ListSortDirection.Descending);
                    errorDataGrid.DataSource = errorViewBindingSource;
                }
            }
            else
            {
                using (var client = new LogServicesClient())
                {
                    var list =
                        new ObservableCollection<ErrorView>(client.FilterErrorsList(comboBoxQuery.Text, null, null));
                    _list = list;
                    errorViewBindingSource.DataSource = list.ToBindingList();
                    _currentSortOrder = SortOrder.Descending;
                    errorDataGrid.Sort(errorDataGrid.Columns[1], ListSortDirection.Descending);
                    errorDataGrid.DataSource = errorViewBindingSource;
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            errorViewBindingSource.EndEdit();
            if (!string.IsNullOrEmpty(iDTextBox.Text))
            {
                int id = Convert.ToInt32(iDTextBox.Text);
                using (var client = new LogServicesClient())
                {
                    client.DeleteError(id);
                }
                errorViewBindingSource.RemoveCurrent();
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
                errorDataGrid.DataSource = null;
                errorDataGrid.Rows.Clear();
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
                errorDataGrid.DataSource = null;
                errorDataGrid.Rows.Clear();
            }
            else
            {
                new MainForm().Show();
            }
            Hide();
        }

        private void errorDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in errorDataGrid.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    if (id != 0)
                    {
                        using (var client = new LogServicesClient())
                        {
                            client.DeleteError(id);
                        }
                    }
                    errorDataGrid.Rows.Remove(row);
                }
            }
        }

        private void eventLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is EventLogForm);
            if (formToShow != null)
            {
                formToShow.Show();
                errorDataGrid.DataSource = null;
                errorDataGrid.Rows.Clear();
            }
            else
            {
                new EventLogForm().Show();
            }
            Hide();
        }

        private void errorDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (_currentSortOrder == SortOrder.Descending)
                {
                    _currentSortOrder = SortOrder.Ascending;
                    errorDataGrid.Sort(errorDataGrid.Columns[1], ListSortDirection.Ascending);
                }
                else
                {
                    _currentSortOrder = SortOrder.Descending;
                    errorDataGrid.Sort(errorDataGrid.Columns[1], ListSortDirection.Descending);
                }
            }
        }
    }
}