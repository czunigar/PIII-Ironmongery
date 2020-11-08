using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoLayer;
using EntityLayer;

namespace Ironmongery
{
    public partial class FrmMain : Form
    {
        private ProductBO pbo;
        public FrmMain()
        {
            InitializeComponent();
            this.pbo = new ProductBO();
            LoadProducts();
        }
        /*Method to load all the subjects registered to the list*/
        private void LoadProducts()
        {
            lstProduct.Items.Clear();
            string filter = txtSearch.Text.ToUpper().Trim();
            foreach (EProduct products in pbo.LoadProducts(filter))
            {
                if (string.IsNullOrEmpty(filter))
                {
                    lstProduct.Items.Add(products);
                }
            }
        }

        private void addProductOrder() 
        {
        
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
