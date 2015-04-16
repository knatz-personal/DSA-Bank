using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManager.UserServices;

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
            using (var client = new UserServicesClient())
            {
                try
                {
                    bool isValidUser = client.Authenticate(txtUsername.Text, txtPassword.Text);
                    int roleId = client.GetRoleIdByName("Manager");
                    bool isManager = client.IsUserInRole(txtUsername.Text, roleId);
                    if (isValidUser && isManager)
                    {
                        var form = new MainForm();
                        form.Show();
                        Hide();
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
    }
}
