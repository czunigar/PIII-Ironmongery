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
        private ServiceOrderBO sobo;
        private OrderBO obo;
        private ProductOrderBO pobo;
        private EProductOrder eproductorder;
        private EProduct eproduct;
        private EServiceOrder eserviceorder;
        private EOrder eorder;
        private List<EProduct> productList;
        private List<EProduct> eproductOrder;
        private List<EService> serviceSelectedList;
        private List<EOrder> orderList;
        private List<EProductOrder> productorderList;
        public FrmMain()
        {
            InitializeComponent();
            this.sbo = new ServiceBO();
            this.sobo = new ServiceOrderBO();
            this.pobo = new ProductOrderBO();
            this.pbo = new ProductBO();
            this.obo = new OrderBO();
            productList = new List<EProduct>();
            serviceSelectedList = new List<EService>();
            eproductOrder = new List<EProduct>();
            productorderList = new List<EProductOrder>();
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
        /*Method to add the product to the whislist*/
        private void addProductOrder() 
        {
            eproduct = (EProduct)lstPackageProducts.SelectedItem;
            decimal oldunits = decimal.Parse(eproduct.Units.ToString());
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
                        pbo.UpdateUnits(eproduct, oldunits);
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
        /*Method to load the products to confirm order*/
        private void loadDataConfirmPurchase()
        {
            EProduct product = (EProduct)lstConfirmPurchase.SelectedItem;
            txtCaregory.Text = product.Category;
            txtDescription.Text = product.Description;
            txtUnits.Text = product.Units.ToString();
            product.Price *= product.Units;
            txtPrice.Text = product.Price.ToString();
            pcImageProductPurch.Image = Image.FromFile(product.Image);
        }
        /*method to change the price of the product*/
        private void changePrice()
        {
            EProduct product = (EProduct)lstConfirmPurchase.SelectedItem;
            if (txtUnits.Text != product.Units.ToString() )
            {
                product.Units = int.Parse(txtUnits.Text);
                product.Price *= product.Units;
                txtPrice.Text = product.Price.ToString();
            }
        }
        /*Method to confirm the purchase*/
        private void confirmPurchase()
        {
            EProduct product = (EProduct)lstConfirmPurchase.SelectedItem;
            ((Control)this.tabPage3).Enabled = true;
            if (txtUnits.Text != "")
            {
                int units = int.Parse(txtUnits.Text);
                if (product.Units > 0)
                {
                    if (product.Units >= units && units > 0)
                    {
                        EProduct orderProduct = product;
                        MessageBox.Show(product.Name + " just added to the order" );
                        orderProduct.Units = units;
                        eproductOrder.Add(orderProduct);
                        //pobo.Save(eproductorder);
                        
                        lstShoppingProducts.Items.Add(orderProduct);
                        lstConfirmPurchase.Items.Remove(orderProduct);
                        txtCaregory.Text = "";
                        txtDescription.Text = "";
                        txtUnits.Text = "";
                        txtPrice.Text = "";
                        pcImageProductPurch.Image = null;
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
        /*Method to load all the services that are in data base*/
        private void loadService()
        {
            lstServices.DataSource = null;
            lstServices.DataSource = sbo.loadServices("");
        }
        /*Method to add the service selected*/
        private void addService()
        {
            if (cbService.Checked)
            {
                EService service= (EService)lstServices.SelectedItem;
                serviceSelectedList.Add(service);
                lstServices.Items.Remove(service);
            }
        }
        #endregion
        #region TAB3
        /*Methid to create the order to confirm the invoice*/
        private void createOrder()
        {
            eorder = new EOrder();
            eorder.Cid = txtUserId.Text;
            eorder.ClientName = txtUserName.Text;
            eorder.Date = dtpDate.Value;
            eorder.Status = "true";
            obo.Save(eorder);
            orderList = obo.LoadOrders("");
            foreach (EOrder order in orderList)
            {
                if (order.Cid == eorder.Cid)
                {
                    eproductorder = new EProductOrder();
                    eproductorder.OrderID = order.Id;
                    eproductorder.Order = eorder;
                    //eproductorder.ProductID
                    //eproductorder.Units = 
                    pobo.Save(eproductorder);
                    eserviceorder = new EServiceOrder();
                    eserviceorder.OrderID = order.Id;
                    eserviceorder.Order = eorder;
                    foreach (EService service in serviceSelectedList)
                    {
                        eserviceorder.ServiceID = service.Id;
                    }
                    sobo.Save(eserviceorder);
                }
            }

        }
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
            LogIn login = new LogIn(this);
            login.Visible = true;
            this.Visible = false;
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
                btnAddService.Visible = true;
                loadService();
            }
            else
            {
                pnService.Visible = false;
                btnAddService.Visible = false;
            }
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            addService();
        }
    }
}
