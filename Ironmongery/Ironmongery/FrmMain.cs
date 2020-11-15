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
        private EProduct eproduct;
        public FrmMain()
        {
            InitializeComponent();
            this.pbo = new ProductBO();
            loadData();
        }

        /*Method to load all the subjects registered to the list*/
        private void loadData()
        {
            lstPackageProducts.DataSource = null;
            lstPackageProducts.DataSource = pbo.LoadProducts("");

        }

        private void addProductOrder() 
        {
            eproduct = (EProduct)lstPackageProducts.SelectedItem;
            lstShoppingProducts.Items.Add(eproduct);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProductOrder();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.ShowDialog();
        }

        private void lstPackageProducts_click(object sender, EventArgs e)
        {
            eproduct = (EProduct)lstPackageProducts.SelectedItem;
            lstPackProducDetails.Text = eproduct.ProductDetails();
            pcbxImageProdct.Image = Image.FromFile(eproduct.Image);
        }
    }
}
