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
    public partial class Question : Form
    {
        public static int Answer { get; set; }
        public Question(string message)
        {
            InitializeComponent();
            lblText.Text = message;
            Answer = 0;
        }
        public Question()
        {
            InitializeComponent();
        }


        public static void notification(string message)
        {
            Question frm = new Question(message);
            frm.ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer = 1;
            this.Close();
        }
    }
}
