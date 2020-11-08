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
        public LogIn()
        {
            InitializeComponent();
            ubo = new UserBO();
            messages = new Messages();
            txtUser.Text = "adm728";
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

                user = ubo.Login(user);

                if(user != null)
                {
                    FrmUsers users = new FrmUsers();
                    users.ShowDialog();
                    clean();
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
    }
}
