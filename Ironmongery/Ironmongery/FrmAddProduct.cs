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
    public partial class FrmAddProduct : Form
    {
        private ProductBO productbo;
        private EProduct eproduct;
        private Form parent;
        string path = "";

        public FrmAddProduct(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.productbo = new ProductBO();
            lblTitle.Text = "ADD PRODUCT";
        }
        public FrmAddProduct(Form parent, EProduct product)
        {
            InitializeComponent();
            this.parent = parent;
            this.productbo = new ProductBO();
            this.eproduct = product;
            lblTitle.Text = "EDIT PRODUCT";
        }
        #region METHODS
        /*METHODS*/
        /*
         Save path image
         */
        private string saveImage()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                path = fbd.SelectedPath;
                return path;
            }
            return path;
        }
        /*
         Add new product
         */
        private void addProduct()
        {
            EProduct newProduct = new EProduct();
            try
            {
                newProduct.Name = txtName.Text.Trim();
                newProduct.Category = txtCategory.Text.Trim();
                newProduct.Description = txtDescription.Text.Trim();
                newProduct.Price = decimal.Parse(txtPrice.Text.Trim());
                newProduct.Units = decimal.Parse(txtUnits.Text.Trim());
                if (!(path.Equals("")))
                {
                    newProduct.Image = path;
                    productbo.Save(newProduct);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         Edit an existing product*/
        private void editProduct()
        {
            EProduct oldProduct = this.eproduct;
            int id = this.eproduct.Id;
            EProduct newProduct = oldProduct;
            try
            {
                newProduct.Name = txtName.Text.Trim();
                newProduct.Category = txtCategory.Text.Trim();
                newProduct.Description = txtDescription.Text.Trim();
                newProduct.Price = decimal.Parse(txtPrice.Text.Trim());
                newProduct.Units = decimal.Parse(txtUnits.Text.Trim());
                productbo.Save(newProduct, id);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region EVENTS
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "EDIT CAREER")
            {
                editProduct();
            }
            else
            {
                addProduct();
            }
        }
        #endregion

        private void btnImage_Click(object sender, EventArgs e)
        {
            saveImage();
        }
    }
}
