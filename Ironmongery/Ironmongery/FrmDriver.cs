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
    public partial class FrmDriver : Form
    {
        private Form parent;
        private EUser user;

        public FrmDriver(Form parent, EUser user)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = user;
            lblTitle.Text = $"{user.Name}' deliveries for today";
            btnReport.Visible = false;
        }
    }
}
