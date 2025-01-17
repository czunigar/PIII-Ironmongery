﻿using BoLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            loadProduct();
        }
        #region METHODS
        /*METHODS*/    

        /* Load product*/
        private void loadProduct()
        {
            txtName.Text = eproduct.Name;
            cboCategory.SelectedItem = eproduct.Category;
            txtDescription.Text = eproduct.Description;
            txtPrice.Text = eproduct.Price.ToString();
            txtUnits.Text = eproduct.Units.ToString();
            pcImage.Image = Image.FromFile(eproduct.Image);
        }

        /*
         Add new product
         */
        private void addProduct()
        {
            EProduct newProduct = new EProduct();
            try
            {
                if (pcImage.Image != null)
                {
                    string filename = txtName.Text + ".jpg";
                    string folder = "C:\\DBImages";
                    string pathstring = System.IO.Path.Combine(folder, filename);
                    Image image = pcImage.Image;
                    image.Save(pathstring);
                    newProduct.Name = txtName.Text.Trim();
                    newProduct.Category = cboCategory.SelectedItem.ToString();
                    newProduct.Description = txtDescription.Text.Trim();
                    newProduct.Price = decimal.Parse(txtPrice.Text.Trim());
                    newProduct.Units = decimal.Parse(txtUnits.Text.Trim());
                    newProduct.Image = pathstring;
                    productbo.Save(newProduct);
                }
                else
                {
                    MessageBox.Show("Please select an image");
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
                string filename = txtName.Text + ".jpg";
                string folder = "C:\\DBImages";
                string pathstring = System.IO.Path.Combine(folder, filename);
                newProduct.Id = id;
                newProduct.Name = txtName.Text.Trim();
                newProduct.Category = cboCategory.SelectedItem.ToString();
                newProduct.Description = txtDescription.Text.Trim();
                newProduct.Price = decimal.Parse(txtPrice.Text.Trim());
                newProduct.Units = decimal.Parse(txtUnits.Text.Trim());
                newProduct.Image = pathstring;
                productbo.Save(newProduct);
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
            if (lblTitle.Text == "EDIT PRODUCT")
            {
                editProduct();
            }
            else
            {
                addProduct();
            }
            FrmProducts products = new FrmProducts(this);
            products.Visible = true;
            Visible = false;
        }
        #endregion

        private void btnImage_Click(object sender, EventArgs e)
        {
           
        }

        private void pcImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            PictureBox picture = sender as PictureBox;
            if (picture != null)
            {
                openFile.Filter = "(*.jpg; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = Image.FromFile(openFile.FileName);
                }
            }
        }

        private void FrmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(parent != null)
            {
                parent.Visible = true;
            }
        }
    }
}
