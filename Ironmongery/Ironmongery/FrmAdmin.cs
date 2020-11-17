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

        public FrmAdmin(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers users = new FrmUsers(this);
            users.Show();
            this.Hide();
        }

        private void mnProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void mnTruck_Click(object sender, EventArgs e)
        {
            
        }

        private void mnService_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers users = new FrmUsers(this);
            users.Visible = true;
            this.Visible = false;
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent != null)
            {
                parent.Visible = true;
            }
        }
    }
}
