using System;
using System.Linq;
using System.Windows.Forms;
using BankManager.BankTransactionServices;
using SortOrder = BankManager.BankTransactionServices.SortOrder;

namespace BankManager
{
    public partial class TransactionHistoryForm : Form
    {
        public TransactionHistoryForm()
        {
            InitializeComponent();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
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
                Hide();
                formToShow.Show();
                transactionDataGrid.DataSource = null;
                transactionDataGrid.Rows.Clear();
            }
        }

        private void appoinmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainForm);
            if (formToShow != null)
            {
                Hide();
                formToShow.Show();
                transactionDataGrid.DataSource = null;
                transactionDataGrid.Rows.Clear();
            }
            else
            {
                Hide();
                new MainForm().Show();
            }
        }

        private void bttnLoadRecords_Click(object sender, EventArgs e)
        {
            transactionDataGrid.DataSource = null;
            transactionDataGrid.Rows.Clear();

            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;

            if (txtAcoountNo.Text == string.Empty)
            {
                txtAcoountNo.Text = @"0";
            }

            //filtered by client’s id, account id, date from- date to
            //sorted by date.
            try
            {
                if (start.Date != end.Date)
                {
                    using (var client = new TransactionServicesClient())
                    {
                        transactionBindingSource.DataSource = client.FilterTransactions(txtUsername.Text.Trim(),
                            Convert.ToInt32(txtAcoountNo.Text.Trim()), SortOrder.Descending, start, end
                            );
                        transactionDataGrid.DataSource = transactionBindingSource;
                    } 
                }
                else
                {
                    using (var client = new TransactionServicesClient())
                    {
                        transactionBindingSource.DataSource = client.FilterTransactions(txtUsername.Text.Trim(),
                            Convert.ToInt32(txtAcoountNo.Text.Trim()), SortOrder.Descending, null, null
                            );
                        transactionDataGrid.DataSource = transactionBindingSource;
                    } 
                }
                
            }
            catch
            {
                MessageBox.Show(@"Error loading records", @"Loading Records", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
            }
        }

        private void transactionViewDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in transactionDataGrid.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    if (id != 0)
                    {
                        using (var client = new TransactionServicesClient())
                        {
                            client.Delete(id);
                        }
                    }
                    transactionDataGrid.Rows.Remove(row);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            transactionBindingSource.EndEdit();
            if (!string.IsNullOrEmpty(iDTextBox.Text))
            {
                int id = Convert.ToInt32(iDTextBox.Text);
                using (var client = new TransactionServicesClient())
                {
                    client.Delete(id);
                }
                transactionBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show(@"There is no record to delete", @"Item Deletion", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
            }
        }

    }
}