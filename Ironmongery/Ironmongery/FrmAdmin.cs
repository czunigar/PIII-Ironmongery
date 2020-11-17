using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ironmongery
{
    public partial class FrmAdmin : Form
    {
        private Form parent;
        private EUser user; 
        public FrmAdmin(Form parent, EUser user)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = user;
            mnLogged.Text = user.Code;
        }

        /*Method to create a window for the logistics crud*/
        private void Truck()
        {
            FrmLogistic lg = new FrmLogistic(this);
            lg.Visible = true;
            this.Visible = false;
        }

        /*Method to create a window for the users crud*/
        private void User()
        {
            FrmUsers users = new FrmUsers(this);
            users.Visible = true;
            this.Visible = false;
        }

        /*Method to create a window for the services crud*/
        private void Service()
        {
            FrmServices serv = new FrmServices(this);
            serv.Visible = true;
            this.Visible = false;
        }


        private void mnUsers_Click(object sender, EventArgs e)
        {
            User();
        }

        private void mnProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void mnTruck_Click(object sender, EventArgs e)
        {
            Truck();
        }

        private void mnService_Click(object sender, EventArgs e)
        {
            Service();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            User();
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent != null)
            {
                parent.Visible = true;
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            Service();
        }

        private void btnTruck_Click(object sender, EventArgs e)
        {
            Truck();
        }

        private void mnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
