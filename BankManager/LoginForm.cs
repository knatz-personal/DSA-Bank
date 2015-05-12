using BankManager.UserServices;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BankManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                using (var client = new UserServicesClient())
                {
                    try
                    {
                        bool isValidUser = client.Authenticate(username, password);
                        int roleId = client.GetRoleIdByName("Manager");
                        bool isManager = client.IsUserInRole(username, roleId);
                        if (isValidUser && isManager)
                        {
                            txtPassword.Text = string.Empty;
                            txtUsername.Text = string.Empty;
                            lblMessage.Text = string.Empty;
                            errorProvider1.Clear();
                            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainForm);

                            if (formToShow != null)
                            {
                                formToShow.Show();
                                Hide();
                            }
                            else
                            {
                                var form = new MainForm();
                                form.Show();
                                Hide();
                            }
                        }
                        else
                        {
                            lblMessage.Text = @"Authentication failed!";
                            lblMessage.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Text = ex.Message;
                        lblMessage.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username cannot be empty");
                    errorProvider1.SetError(txtPassword, "Password cannot be empty");
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username cannot be empty");
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "Password cannot be empty");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            lblMessage.Text = string.Empty;
            errorProvider1.Clear();
        }
    }
}