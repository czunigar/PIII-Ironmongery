namespace Ironmongery
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstPackProducDetails = new System.Windows.Forms.TextBox();
            this.pcbxImageProdct = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPackageProducts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUnitsBuy = new System.Windows.Forms.Label();
            this.txtUnitsToBuy = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lstShoppingProducts = new System.Windows.Forms.ListBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtPrince = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCaregory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pcImageProductPurch = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnConfirmProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lstConfirmPurchase = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnService = new System.Windows.Forms.Panel();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cbxServiceName = new System.Windows.Forms.ComboBox();
            this.lblServiceCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.cbService = new System.Windows.Forms.CheckBox();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImageProdct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImageProductPurch)).BeginInit();
            this.pnService.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(997, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 612);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtUnitsToBuy);
            this.tabPage1.Controls.Add(this.lblUnitsBuy);
            this.tabPage1.Controls.Add(this.lstPackProducDetails);
            this.tabPage1.Controls.Add(this.pcbxImageProdct);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lstPackageProducts);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(924, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Package Store";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstPackProducDetails
            // 
            this.lstPackProducDetails.Location = new System.Drawing.Point(430, 269);
            this.lstPackProducDetails.Multiline = true;
            this.lstPackProducDetails.Name = "lstPackProducDetails";
            this.lstPackProducDetails.ReadOnly = true;
            this.lstPackProducDetails.Size = new System.Drawing.Size(278, 188);
            this.lstPackProducDetails.TabIndex = 10;
            // 
            // pcbxImageProdct
            // 
            this.pcbxImageProdct.BackColor = System.Drawing.Color.DarkGray;
            this.pcbxImageProdct.Location = new System.Drawing.Point(656, 75);
            this.pcbxImageProdct.Margin = new System.Windows.Forms.Padding(4);
            this.pcbxImageProdct.Name = "pcbxImageProdct";
            this.pcbxImageProdct.Size = new System.Drawing.Size(214, 159);
            this.pcbxImageProdct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxImageProdct.TabIndex = 8;
            this.pcbxImageProdct.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Products:";
            // 
            // lstPackageProducts
            // 
            this.lstPackageProducts.FormattingEnabled = true;
            this.lstPackageProducts.ItemHeight = 20;
            this.lstPackageProducts.Location = new System.Drawing.Point(23, 37);
            this.lstPackageProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lstPackageProducts.Name = "lstPackageProducts";
            this.lstPackageProducts.Size = new System.Drawing.Size(359, 464);
            this.lstPackageProducts.TabIndex = 6;
            this.lstPackageProducts.Click += new System.EventHandler(this.lstPackageProducts_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(717, 487);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbService);
            this.tabPage2.Controls.Add(this.pnService);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtUnits);
            this.tabPage2.Controls.Add(this.txtPrince);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.txtCaregory);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.pcImageProductPurch);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnConfirmProduct);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lstConfirmPurchase);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(924, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirm Purchase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(40, 23);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(123, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 29);
            this.txtSearch.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(396, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblUnitsBuy
            // 
            this.lblUnitsBuy.AutoSize = true;
            this.lblUnitsBuy.Location = new System.Drawing.Point(396, 108);
            this.lblUnitsBuy.Name = "lblUnitsBuy";
            this.lblUnitsBuy.Size = new System.Drawing.Size(53, 20);
            this.lblUnitsBuy.TabIndex = 11;
            this.lblUnitsBuy.Text = "Units:";
            // 
            // txtUnitsToBuy
            // 
            this.txtUnitsToBuy.Location = new System.Drawing.Point(455, 108);
            this.txtUnitsToBuy.Name = "txtUnitsToBuy";
            this.txtUnitsToBuy.Size = new System.Drawing.Size(157, 26);
            this.txtUnitsToBuy.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCompleteOrder);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lstShoppingProducts);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shopping Cart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(998, 780);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Products:";
            // 
            // lstShoppingProducts
            // 
            this.lstShoppingProducts.FormattingEnabled = true;
            this.lstShoppingProducts.ItemHeight = 24;
            this.lstShoppingProducts.Location = new System.Drawing.Point(67, 93);
            this.lstShoppingProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lstShoppingProducts.Name = "lstShoppingProducts";
            this.lstShoppingProducts.Size = new System.Drawing.Size(285, 412);
            this.lstShoppingProducts.TabIndex = 13;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(396, 398);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(95, 29);
            this.txtUnits.TabIndex = 48;
            // 
            // txtPrince
            // 
            this.txtPrince.Location = new System.Drawing.Point(394, 360);
            this.txtPrince.Name = "txtPrince";
            this.txtPrince.ReadOnly = true;
            this.txtPrince.Size = new System.Drawing.Size(97, 29);
            this.txtPrince.TabIndex = 47;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(394, 319);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 29);
            this.txtDescription.TabIndex = 46;
            // 
            // txtCaregory
            // 
            this.txtCaregory.Location = new System.Drawing.Point(391, 275);
            this.txtCaregory.Name = "txtCaregory";
            this.txtCaregory.Size = new System.Drawing.Size(189, 29);
            this.txtCaregory.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "Units:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Price:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Description:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "Category:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcImageProductPurch
            // 
            this.pcImageProductPurch.Location = new System.Drawing.Point(335, 98);
            this.pcImageProductPurch.Margin = new System.Windows.Forms.Padding(4);
            this.pcImageProductPurch.Name = "pcImageProductPurch";
            this.pcImageProductPurch.Size = new System.Drawing.Size(176, 133);
            this.pcImageProductPurch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImageProductPurch.TabIndex = 39;
            this.pcImageProductPurch.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(282, 477);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 33);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnConfirmProduct
            // 
            this.btnConfirmProduct.Location = new System.Drawing.Point(431, 477);
            this.btnConfirmProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmProduct.Name = "btnConfirmProduct";
            this.btnConfirmProduct.Size = new System.Drawing.Size(118, 33);
            this.btnConfirmProduct.TabIndex = 37;
            this.btnConfirmProduct.Text = "Confirm";
            this.btnConfirmProduct.UseVisualStyleBackColor = true;
            this.btnConfirmProduct.Click += new System.EventHandler(this.confirmProduct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "Product name:";
            // 
            // lstConfirmPurchase
            // 
            this.lstConfirmPurchase.FormattingEnabled = true;
            this.lstConfirmPurchase.ItemHeight = 24;
            this.lstConfirmPurchase.Location = new System.Drawing.Point(44, 98);
            this.lstConfirmPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.lstConfirmPurchase.Name = "lstConfirmPurchase";
            this.lstConfirmPurchase.Size = new System.Drawing.Size(219, 412);
            this.lstConfirmPurchase.TabIndex = 35;
            this.lstConfirmPurchase.Click += new System.EventHandler(this.lstConfirmPurchase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Service:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnService
            // 
            this.pnService.Controls.Add(this.txtServicePrice);
            this.pnService.Controls.Add(this.lblServicePrice);
            this.pnService.Controls.Add(this.cbxCategory);
            this.pnService.Controls.Add(this.lblServiceCategory);
            this.pnService.Controls.Add(this.cbxServiceName);
            this.pnService.Controls.Add(this.lblServiceName);
            this.pnService.Location = new System.Drawing.Point(612, 147);
            this.pnService.Name = "pnService";
            this.pnService.Size = new System.Drawing.Size(287, 205);
            this.pnService.TabIndex = 51;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(30, 91);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(66, 24);
            this.lblServiceName.TabIndex = 52;
            this.lblServiceName.Text = "Name:";
            this.lblServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxServiceName
            // 
            this.cbxServiceName.FormattingEnabled = true;
            this.cbxServiceName.Location = new System.Drawing.Point(105, 88);
            this.cbxServiceName.Name = "cbxServiceName";
            this.cbxServiceName.Size = new System.Drawing.Size(167, 32);
            this.cbxServiceName.TabIndex = 53;
            // 
            // lblServiceCategory
            // 
            this.lblServiceCategory.AutoSize = true;
            this.lblServiceCategory.Location = new System.Drawing.Point(6, 29);
            this.lblServiceCategory.Name = "lblServiceCategory";
            this.lblServiceCategory.Size = new System.Drawing.Size(90, 24);
            this.lblServiceCategory.TabIndex = 54;
            this.lblServiceCategory.Text = "Category:";
            this.lblServiceCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(105, 29);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(164, 32);
            this.cbxCategory.TabIndex = 55;
            this.cbxCategory.TextUpdate += new System.EventHandler(this.cbxCategory_TextUpdate);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(38, 149);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(58, 24);
            this.lblServicePrice.TabIndex = 56;
            this.lblServicePrice.Text = "Price:";
            this.lblServicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(105, 146);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.ReadOnly = true;
            this.txtServicePrice.Size = new System.Drawing.Size(107, 29);
            this.txtServicePrice.TabIndex = 57;
            // 
            // cbService
            // 
            this.cbService.AutoSize = true;
            this.cbService.Location = new System.Drawing.Point(717, 94);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(95, 28);
            this.cbService.TabIndex = 52;
            this.cbService.Text = "Service";
            this.cbService.UseVisualStyleBackColor = true;
            this.cbService.CheckedChanged += new System.EventHandler(this.cbService_CheckedChanged);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(680, 462);
            this.btnCompleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(115, 43);
            this.btnCompleteOrder.TabIndex = 38;
            this.btnCompleteOrder.Text = "Confirm";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 808);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImageProdct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImageProductPurch)).EndInit();
            this.pnService.ResumeLayout(false);
            this.pnService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPackageProducts;
        private System.Windows.Forms.TextBox lstPackProducDetails;
        private System.Windows.Forms.PictureBox pcbxImageProdct;
        private System.Windows.Forms.TextBox txtUnitsToBuy;
        private System.Windows.Forms.Label lblUnitsBuy;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtPrince;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCaregory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pcImageProductPurch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirmProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstConfirmPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstShoppingProducts;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblServiceCategory;
        private System.Windows.Forms.ComboBox cbxServiceName;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.CheckBox cbService;
        private System.Windows.Forms.Button btnCompleteOrder;
    }
}