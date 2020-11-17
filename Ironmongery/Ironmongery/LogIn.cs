using BoLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ServiceLayer;
using EntityLayer;

namespace Ironmongery
{
    public partial class LogIn : Form
    {
        UserBO ubo;
        Messages messages;
        private Form parent;

        public LogIn(Form parent)
        {
            InitializeComponent();
            ubo = new UserBO();
            this.parent = parent;
            messages = new Messages();
            txtUser.Text = "adm269";
            txtPass.Text = "anitacr12345";
        }

        /*Method to reassign the default values*/
        public void clean()
        {
            txtUser.Text = "Username";
            txtUser.ForeColor = Color.FromArgb(204, 204, 204);
            txtPass.PasswordChar = '\0';
            txtPass.Text = "Password";
            txtPass.ForeColor = Color.FromArgb(204, 204, 204);

        }
        private void login()
        {
            try
            {
                EUser user = new EUser();
                user.Code = txtUser.Text.Trim().ToUpper();
                user.Password = txtPass.Text.Trim();

                EUser usr = ubo.Login(user);

                if (usr != null)
                {
                    if ((bool)usr.Admin)
                    {
                        FrmAdmin admin = new FrmAdmin(this, usr);
                        admin.Visible = true;
                        this.Visible = false;
                        clean();
                    }
                    else if (usr.Type.Equals("Driver"))
                    {
                        FrmDriver driver = new FrmDriver(this, usr);
                        driver.Visible = true;
                        this.Visible = false;
                        clean();
                    }
                    else if (usr.Type.Equals("Cashier"))
                    {
                        FrmCashier cashier = new FrmCashier(this, usr);
                        cashier.Visible = true;
                        this.Visible = false;
                        clean();
                    }
                }
                else
                {
                    messages.notification("Wrong Credentials");
                }
            }
            catch (Exception)
            {

                messages.notification("Couldn't find the information");
            }
        }



        /*Method to verify the user's credentials*/
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.FromArgb(204, 204, 204);
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.FromArgb(204, 204, 204);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            txtUser.ForeColor = Color.Black;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtPass.ForeColor = Color.Black;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent != null)
            {
                parent.Visible = true;
            }
        }
    }
}
