using System;
using System.Linq;
using System.Windows.Forms;
using BankManager.LogServices;

namespace BankManager
{
    public partial class EventLogForm : Form
    {
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
            using (var client = new LogServicesClient())
            {
                eventViewBindingSource.DataSource = client.ListEvents();
                eventDataGrid.DataSource = eventViewBindingSource;
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

        
    }
}