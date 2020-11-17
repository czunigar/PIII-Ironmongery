using BoLayer;
using EntityLayer;
using ServiceLayer;
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
    public partial class FrmProducts : Form
    {
        private Form parent;
        private Messages message;
        private ProductBO productbo;
        private Messages message;
        public FrmProducts(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            message = new Messages();
            this.productbo = new ProductBO();
            this.message = new Messages();
        }
        public FrmProducts()
        {
            InitializeComponent();
            this.productbo = new ProductBO();
            
        }
        private void loadData()
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = productbo.LoadProducts(txtSearch.Text.ToUpper());

        }
        /*Method to get the select the product*/
        private EProduct selected()
        {
            EProduct product = new EProduct();
            int row = dgvProduct.CurrentCell.RowIndex;
            if (row < 0)
            {
                return null;
            }
            product = productbo.GetProductById((int)dgvProduct.Rows[row].Cells["Id"].Value);
            return product;
        }
        private void AddProduct()
        {
            try
            {
                FrmAddProduct newProduct = new FrmAddProduct(this);
                newProduct.Visible = true;
                Visible = false;
            }
            catch (Exception ex)
            {
                message.notification("There was an issue trying to open the new view, please try again");
            }
        }

        private void Edit()
        {
            try
            {
                //if (dgvProducts.CurrentRow != null)
                //{
                    FrmAddProduct newProduct = new FrmAddProduct(this, selected());
                    newProduct.Visible = true;
                    Visible = false;
               // }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        private void Delete()
        {
            try
            {
                if (dgvProducts.CurrentCell.Value != null)
                {
                    Question.notification($"Are you sure to remove the product \"{selected().Name}\"");
                    if (Question.Answer == 1)
                    {
                        productbo.Delete(selected().Id);
                        message.notification("Product deleted");
                        loadData();
                    }
                }
                else
                {
                    message.notification("Please choose a product");
                }
            }
            catch (Exception)
            {
                message.notification("There was an issue trying to delete the product");
            }
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
