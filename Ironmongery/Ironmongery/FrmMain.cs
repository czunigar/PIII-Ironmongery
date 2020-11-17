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
using ServiceLayer;

namespace Ironmongery
{
    public partial class FrmMain : Form
    {
        private ProductBO pbo;
        private ServiceBO sbo;
        private ServiceOrderBO sobo;
        private OrderBO obo;
        private ProductOrderBO pobo;
        private List<EProduct> productList;
        private List<EProduct> eproductOrder;
        private List<EService> serviceSelectedList;
        private List<EProductOrder> productorderList;
        private Messages message;
        private int id = 0;
        public FrmMain()
        {
            InitializeComponent();
            this.sbo = new ServiceBO();
            this.sobo = new ServiceOrderBO();
            this.pobo = new ProductOrderBO();
            this.pbo = new ProductBO();
            this.obo = new OrderBO();
            this.message = new Messages();
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
            try
            {
                if (!string.IsNullOrEmpty(txtUnitsToBuy.Text))
                {
                    int units = int.Parse(txtUnitsToBuy.Text);
                    btnAdd.Enabled = true;
                    if (SelectedProduct().Units > 0)
                    {
                        if (SelectedProduct().Units >= units && units > 0)
                        {
                            EProduct newP = new EProduct();
                            newP = SelectedProduct();
                            message.notification($"You just added: {newP.Name} to your shopping cart");
                            productList.Add(newP);
                            newP.Units = newP.Units - units;
                            pbo.Save(newP);
                            lstConfirmPurchase.Items.Add(CreatePrOrder(Order(), newP, units));
                        }
                        else
                        {
                            message.notification("Units value invalid, please enter a valid value. Thanks");
                        }
                    }
                }
                else
                {
                    message.notification("Units value invalid, please enter a valid value. Thanks");
                }
            }
            catch (Exception)
            {

                message.notification("Cannot do that action");
            }
            
        }

        /*Method to create the order to confirm the invoice*/
        private EOrder Order()
        {
            EOrder ord = new EOrder();
            ord.Cid = txtUserId.Text;
            ord.ClientName = txtUserName.Text;
            ord.Date = DateTime.Now;
            ord.Status = "Pending";
            obo.Save(ord);
            return ord;
        }

        /*Method to add the product to each order*/
        private EProductOrder CreatePrOrder(EOrder ord,EProduct product, int units)
        {
            EProductOrder pOrder = new EProductOrder();
            foreach (EOrder order in obo.LoadOrders(""))
            {
                if (order.Cid.Equals(ord.Cid))
                {    
                    pOrder.OrderID = order.Id;
                    this.id = order.Id;
                    pOrder.Order = ord;
                    pOrder.ProductID = product.Id;
                    pOrder.Product = product;
                    pOrder.Units = units;
                    pobo.Save(pOrder);
                }
            }
            return pOrder;
        }

        /*Method to grab the selected product*/
        private EProduct SelectedProduct()
        {
            return (EProduct)lstPackageProducts.SelectedItem;
        }
        #endregion
        #region TAB2

        /*Method to load the products to confirm order*/
        private void LoadPurchase()
        {
            lstConfirmPurchase.DataSource = pobo.LoadProductOrders(this.id);
        }

        /*Method to grab the selected order for a product*/
        private EProductOrder SelectedPrOrder()
        {
            return (EProductOrder)lstConfirmPurchase.SelectedItem;
        }

        /*method to change the price of the product*/
        private void getPrice()
        {
            int units = int.Parse(txtUnits.Text);
            decimal price = (decimal)(SelectedPrOrder().Product.Price);
            decimal newPrice = price * units;
            txtPrice.Text = newPrice.ToString();
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
            if (SelectedProduct().Units > 0)
            {
                lstPackProducDetails.Text = SelectedProduct().ProductDetails();
                lblUnits.Text = $"Units: {(int)SelectedProduct().Units}";
                txtUnitsToBuy.Text = "";
                btnAdd.Enabled = true;
                pcbxImageProdct.Image = Image.FromFile(SelectedProduct().Image);
            }
            else
            {
                lstPackProducDetails.Text = SelectedProduct().ProductDetails() + " \n SOLD OUT! \n";
                txtUnitsToBuy.Text = "Sold out";
                lblUnits.Text = $"Units: 0";
                btnAdd.Enabled = false;
                pcbxImageProdct.Image = Image.FromFile(SelectedProduct().Image);
            }
            
        }

        private void lstShoppingProducts_Click(object sender, EventArgs e)
        {
            lstPackProducDetails.Text = SelectedProduct().ProductDetails();
        }
        #endregion
        #endregion

        private void confirmProduct_Click(object sender, EventArgs e)
        {
            confirmPurchase();
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void cboClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPurchase();
        }

        private void txtUnits_Validated(object sender, EventArgs e)
        {
            getPrice();
        }

        private void lstConfirmPurchase_Click(object sender, EventArgs e)
        {
            int units = (int)SelectedPrOrder().Units;
            txtCaregory.Text = SelectedPrOrder().Product.Category;
            txtDescription.Text = SelectedPrOrder().Product.Description;
            txtUnits.Text = units.ToString();     
        }

        private void txtUnits_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnits.Text))
            {
                getPrice();
            }
        }
    }
}
