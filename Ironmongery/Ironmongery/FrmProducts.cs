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
            loadData();
        }
        /*Method to get the select the product*/
        private EProduct selected()
        {
            int row = dtgvProducts.CurrentCell.RowIndex;
            if (row < 0)
            {
                return null;
            }
            return (EProduct)dtgvProducts.Rows[row].Cells[0].Value;
        }
        private void loadData()
        {
            dtgvProducts.Rows.Clear();
            string filter = txtSearch.Text.ToUpper().Trim();
            try
            {
                foreach (EProduct product in productbo.LoadProducts(filter))
                {
                    if (string.IsNullOrEmpty(filter) || product.Id.Equals(filter))
                    {

                        object[] row = {product.Id, product.Name, product.Category, product.Description,
                        product.Price, product.Units};
                        dtgvProducts.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvProducts.CurrentCell.Value != null)
                {
                    FrmAddProduct newProduct = new FrmAddProduct(this);
                    newProduct.Visible = true;
                    Visible = false;
                    loadData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace + "There was an issue trying to open the new view, please try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvProducts.CurrentCell.Value != null)
                {
                    FrmAddProduct newProduct = new FrmAddProduct(this, selected());
                    newProduct.Visible = true;
                    Visible = false;
                    loadData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace + "There was an issue trying to edit the product", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvProducts.CurrentCell.Value != null)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void FrmProducts_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
