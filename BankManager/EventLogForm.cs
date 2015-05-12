using System;
using System.Linq;
using System.Windows.Forms;

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
                eventDataGridView.DataSource = null;
                eventDataGridView.Rows.Clear();
            }
            else
            {
                new LoginForm().Show();
            }
            Hide();
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //eventViewBindingSource.EndEdit();
            //if (!string.IsNullOrEmpty(iDTextBox.Text))
            //{
            //    int id = Convert.ToInt32(iDTextBox.Text);
            //    using (var client = new LogServicesClient())
            //    {
            //        client.DeleteEvent(id);
            //    }
            //    eventViewBindingSource.RemoveCurrent();
            //}
            //else
            //{
            //    MessageBox.Show(@"There is no record to delete", @"Item Deletion", MessageBoxButtons.OKCancel,
            //        MessageBoxIcon.Asterisk);
            //}
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is TransactionHistoryForm);
            if (formToShow != null)
            {
                formToShow.Show();
                eventDataGridView.DataSource = null;
                eventDataGridView.Rows.Clear();
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
                eventDataGridView.DataSource = null;
                eventDataGridView.Rows.Clear();
            }
            else
            {
                new MainForm().Show();
            }
            Hide();
        }

        private void eventDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is ErrorLogForm);
            if (formToShow != null)
            {
                formToShow.Show();
                eventDataGridView.DataSource = null;
                eventDataGridView.Rows.Clear();
            }
            else
            {
                new ErrorLogForm().Show();
            }
            Hide();
        }
    }
}