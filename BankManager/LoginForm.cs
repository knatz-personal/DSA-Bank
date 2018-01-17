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
            try
            {
                errorProvider1.Clear();
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    try
                    {
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
                    catch (Exception ex2)
                    {
                        lblMessage.Text = ex2.Message;
                        lblMessage.ForeColor = Color.Red;
                        //throw new Exception("An error occurred communicating over the network.");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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