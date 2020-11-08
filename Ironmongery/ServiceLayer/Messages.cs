using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLayer
{
    public partial class Messages : Form
    {

        public Messages()
        {
            InitializeComponent();
        }

        public Messages(string message)
        {
            InitializeComponent();
            lblText.Text = message;
        }

        public void notification(string message)
        {
            Messages frm = new Messages(message);
            frm.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
