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
    public partial class Question : Form
    {
        public int Answer { get; set; }
        public Question(string message)
        {
            InitializeComponent();
            lblText.Text = message;
        }
        public Question()
        {
            InitializeComponent();
        }


        public void notification(string message)
        {
            Messages frm = new Messages(message);
            frm.ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer = 1;
        }
    }
}
