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
        private ServiceBO sbo;
        private EProduct eproduct;
        private EService eservice;
        private List<EProduct> productList;
        private List<EProduct> productOrder;
        private List<EProduct> newList;
        private List<EService> serviceList;
        public FrmMain()
        {
            InitializeComponent();
            this.sbo = new ServiceBO();
            this.pbo = new ProductBO();
            productList = new List<EProduct>();
            newList = new List<EProduct>();
            productOrder = new List<EProduct>();
            ((Control)this.tabPage3).Enabled = false;
            pnService.Visible = false;
            loadData();
        }
        #region METHODS

        #region TAB1
        /*Method to load all the subjects registered to the list*/
        private void loadData()
        {
            lstPackageProducts.DataSource = null;
            lstPackageProducts.DataSource = pbo.LoadProducts("");

        }
        private void addProductOrder() 
        {
            eproduct = (EProduct)lstPackageProducts.SelectedItem;
            if (txtUnitsToBuy.Text != "")
            {
                int units = int.Parse(txtUnitsToBuy.Text);
                btnAdd.Enabled = true;
                if (eproduct.Units > 0)
                {
                    if (eproduct.Units >= units && units > 0)
                    {
                        EProduct currectproduct = eproduct;
                        MessageBox.Show("You just added: " + eproduct.Name + " to your shopping cart");
                        currectproduct.Units = units;
                        productList.Add(currectproduct);
                        lstConfirmPurchase.Items.Add(currectproduct);
                    }
                    else
                    {
                        MessageBox.Show("Units value invalid, please enter a valid value. Thanks");
                    }
                }
            }
            else
            {
                MessageBox.Show("Units value invalid, please enter a valid value. Thanks");
            }
            
        }
        #endregion
        #region TAB2
        private void loadDataConfirmPurchase()
        {
            EProduct product = (EProduct)lstConfirmPurchase.SelectedItem;
            txtCaregory.Text = product.Category;
            txtDescription.Text = product.Description;
            txtUnits.Text = product.Units.ToString();
            product.Price *= product.Units;
            txtPrince.Text = product.Price.ToString();
            pcImageProductPurch.Image = Image.FromFile(product.Image);
        }
        private void changePrice()
        {
            EProduct product = (EProduct)lstConfirmPurchase.SelectedItem;
            if (txtUnits.Text != product.Units.ToString() )
            {
                product.Units = int.Parse(txtUnits.Text);
                product.Price *= product.Units;
                txtPrince.Text = product.Price.ToString();
            }
        }

        private void confirmPurchase()
        {
            EProduct product = (EProduct)lstConfirmPurchase.SelectedItem;
            if (txtUnits.Text != "")
            {

                int units = int.Parse(txtUnits.Text);
                if (product.Units > 0)
                {
                    if (product.Units >= units && units > 0)
                    {
                        EProduct boughtProduct = new EProduct();
                        MessageBox.Show(product.Name + " just added to the order" );
                        boughtProduct.Units = units;
                        foreach (EProduct prod in productList)
                        {
                            if (product.Id == prod.Id)
                            {
                                product.Units -= boughtProduct.Units;
                                pbo.Save(product);
                            }
                        }
                        productOrder.Add(boughtProduct);
                        lstShoppingProducts.Items.Add(boughtProduct);
                    }
                    else
                    {
                        MessageBox.Show("Units value invalid, please enter a valid value. Thanks");
                    }
                }
            }
            else
            {
                MessageBox.Show("Units value invalid, please enter a valid value. Thanks");
            }
        }
        private void loadService()
        {
            serviceList = sbo.loadServices("");
            foreach (EService services in serviceList)
            {
                cbxCategory.Items.Add(services.Category);
            }

        }
        private void searchService(string category)
        {
            foreach (var service in sbo.loadServices(category))
            {
                cbxServiceName.Items.Add(service.Name);
                txtServicePrice.Text = service.Price.ToString();
            }

        }
        #endregion
        #region TAB3
        #endregion
        #endregion
        #region EVENTS
        #region TAB1

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
            if (eproduct.Units > 0)
            {
                lstPackProducDetails.Text = eproduct.ProductDetails();
                txtUnitsToBuy.Text = "";
                txtSearch.Text = eproduct.Units.ToString();
                btnAdd.Enabled = true;
                pcbxImageProdct.Image = Image.FromFile(eproduct.Image);
            }
            else
            {
                lstPackProducDetails.Text = eproduct.ProductDetails() + " \n SOLD OUT! \n";
                txtUnitsToBuy.Text = "Sold out";
                btnAdd.Enabled = false;
                pcbxImageProdct.Image = Image.FromFile(eproduct.Image);
            }
            
        }

        private void lstShoppingProducts_Click(object sender, EventArgs e)
        {
            eproduct = (EProduct)lstShoppingProducts.SelectedItem;
            lstPackProducDetails.Text = eproduct.ProductDetails();
        }
        #endregion
        #endregion

        private void confirmProduct_Click(object sender, EventArgs e)
        {
            confirmPurchase();
        }

        private void lstConfirmPurchase_Click(object sender, EventArgs e)
        {
            loadDataConfirmPurchase();
        }



        private void cbService_CheckedChanged(object sender, EventArgs e)
        {
            if (cbService.Checked)
            {
                pnService.Visible = true;
                loadService();
            }
            else
            {
                pnService.Visible = false;
            }
        }

        private void cbxCategory_TextUpdate(object sender, EventArgs e)
        {
            string category = cbxCategory.Text;
            searchService(category);
        }

    }
}
