using BoLayer;
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
    public partial class FrmProducts : Form
    {
        private Form parent;
        private ProductBO productbo;
        public FrmProducts(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.productbo = new ProductBO();
            
        }
        public FrmProducts()
        {
            InitializeComponent();
            this.productbo = new ProductBO();
            
        }
        private void loadData()
        {
            dvgProduct.DataSource = null;
            dvgProduct.DataSource = productbo.LoadProducts(txtSearch.Text.ToUpper());

        }
        /*Method to get the select the product*/
        private EProduct selected()
        {
            EProduct product = new EProduct();
            int row = dvgProduct.CurrentCell.RowIndex;
            if (row < 0)
            {
                return null;
            }
            product = productbo.GetProductById((int)dvgProduct.Rows[row].Cells["Id"].Value);
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

                MessageBox.Show(ex.StackTrace + "There was an issue trying to open the new view, please try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult result = MessageBox.Show($"Are you sure to remove the product \"{selected().Name}\"",
                                "Removing User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        productbo.Delete(selected().Id);
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a product", "Deliting product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There was an issue trying to delete the product", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmProducts_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void dtgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
