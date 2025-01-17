﻿namespace Ironmongery
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
            this.lblClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnitsToBuy = new System.Windows.Forms.TextBox();
            this.lblUnitsBuy = new System.Windows.Forms.Label();
            this.lstPackProducDetails = new System.Windows.Forms.TextBox();
            this.pcbxImageProdct = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPackageProducts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cbService = new System.Windows.Forms.CheckBox();
            this.pnService = new System.Windows.Forms.Panel();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCaregory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pcImageProductPurch = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnConfirmProduct = new System.Windows.Forms.Button();
            this.lstConfirmPurchase = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lstShoppingProducts = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxClients = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImageProdct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImageProductPurch)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1007, 31);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 563);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblClient);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblUnits);
            this.tabPage1.Controls.Add(this.txtUnitsToBuy);
            this.tabPage1.Controls.Add(this.lblUnitsBuy);
            this.tabPage1.Controls.Add(this.lstPackProducDetails);
            this.tabPage1.Controls.Add(this.pcbxImageProdct);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lstPackageProducts);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(999, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Package Store";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(425, 302);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(268, 23);
            this.lblClient.TabIndex = 43;
            this.lblClient.Text = "Client Personal Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(429, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 162);
            this.panel1.TabIndex = 42;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(92, 91);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(163, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(92, 39);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(163, 26);
            this.txtUserId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // lblUnits
            // 
            this.lblUnits.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(425, 250);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(213, 27);
            this.lblUnits.TabIndex = 13;
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitsToBuy
            // 
            this.txtUnitsToBuy.Location = new System.Drawing.Point(480, 37);
            this.txtUnitsToBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitsToBuy.Name = "txtUnitsToBuy";
            this.txtUnitsToBuy.Size = new System.Drawing.Size(157, 26);
            this.txtUnitsToBuy.TabIndex = 12;
            // 
            // lblUnitsBuy
            // 
            this.lblUnitsBuy.AutoSize = true;
            this.lblUnitsBuy.Location = new System.Drawing.Point(421, 37);
            this.lblUnitsBuy.Name = "lblUnitsBuy";
            this.lblUnitsBuy.Size = new System.Drawing.Size(53, 20);
            this.lblUnitsBuy.TabIndex = 11;
            this.lblUnitsBuy.Text = "Units:";
            // 
            // lstPackProducDetails
            // 
            this.lstPackProducDetails.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPackProducDetails.Location = new System.Drawing.Point(724, 37);
            this.lstPackProducDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPackProducDetails.Multiline = true;
            this.lstPackProducDetails.Name = "lstPackProducDetails";
            this.lstPackProducDetails.ReadOnly = true;
            this.lstPackProducDetails.Size = new System.Drawing.Size(212, 197);
            this.lstPackProducDetails.TabIndex = 10;
            // 
            // pcbxImageProdct
            // 
            this.pcbxImageProdct.BackColor = System.Drawing.Color.DarkGray;
            this.pcbxImageProdct.Location = new System.Drawing.Point(425, 76);
            this.pcbxImageProdct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbxImageProdct.Name = "pcbxImageProdct";
            this.pcbxImageProdct.Size = new System.Drawing.Size(213, 159);
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
            this.lstPackageProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPackageProducts.Name = "lstPackageProducts";
            this.lstPackageProducts.Size = new System.Drawing.Size(359, 444);
            this.lstPackageProducts.TabIndex = 6;
            this.lstPackageProducts.Click += new System.EventHandler(this.lstPackageProducts_click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(828, 449);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbxClients);
            this.tabPage2.Controls.Add(this.btnAddService);
            this.tabPage2.Controls.Add(this.cbService);
            this.tabPage2.Controls.Add(this.pnService);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtUnits);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.txtCaregory);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.pcImageProductPurch);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnConfirmProduct);
            this.tabPage2.Controls.Add(this.lstConfirmPurchase);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(999, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirm Purchase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(836, 480);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(93, 36);
            this.btnAddService.TabIndex = 53;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // cbService
            // 
            this.cbService.AutoSize = true;
            this.cbService.Location = new System.Drawing.Point(748, 59);
            this.cbService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(95, 28);
            this.cbService.TabIndex = 52;
            this.cbService.Text = "Service";
            this.cbService.UseVisualStyleBackColor = true;
            this.cbService.CheckedChanged += new System.EventHandler(this.cbService_CheckedChanged);
            // 
            // pnService
            // 
            this.pnService.Controls.Add(this.lstServices);
            this.pnService.Location = new System.Drawing.Point(643, 107);
            this.pnService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnService.Name = "pnService";
            this.pnService.Size = new System.Drawing.Size(287, 329);
            this.pnService.TabIndex = 51;
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 24;
            this.lstServices.Location = new System.Drawing.Point(21, 31);
            this.lstServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(233, 244);
            this.lstServices.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Service:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(395, 359);
            this.txtUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(185, 29);
            this.txtUnits.TabIndex = 48;
            this.txtUnits.TextChanged += new System.EventHandler(this.txtUnits_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(396, 319);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(184, 29);
            this.txtPrice.TabIndex = 47;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(395, 271);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 29);
            this.txtDescription.TabIndex = 46;
            // 
            // txtCaregory
            // 
            this.txtCaregory.Enabled = false;
            this.txtCaregory.Location = new System.Drawing.Point(395, 228);
            this.txtCaregory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaregory.Name = "txtCaregory";
            this.txtCaregory.Size = new System.Drawing.Size(185, 29);
            this.txtCaregory.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "Units:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Price:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Description:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "Category:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcImageProductPurch
            // 
            this.pcImageProductPurch.Location = new System.Drawing.Point(405, 59);
            this.pcImageProductPurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcImageProductPurch.Name = "pcImageProductPurch";
            this.pcImageProductPurch.Size = new System.Drawing.Size(176, 133);
            this.pcImageProductPurch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImageProductPurch.TabIndex = 39;
            this.pcImageProductPurch.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(341, 430);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 33);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnConfirmProduct
            // 
            this.btnConfirmProduct.Location = new System.Drawing.Point(464, 430);
            this.btnConfirmProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmProduct.Name = "btnConfirmProduct";
            this.btnConfirmProduct.Size = new System.Drawing.Size(117, 33);
            this.btnConfirmProduct.TabIndex = 37;
            this.btnConfirmProduct.Text = "Confirm";
            this.btnConfirmProduct.UseVisualStyleBackColor = true;
            this.btnConfirmProduct.Click += new System.EventHandler(this.confirmProduct_Click);
            // 
            // lstConfirmPurchase
            // 
            this.lstConfirmPurchase.FormattingEnabled = true;
            this.lstConfirmPurchase.ItemHeight = 24;
            this.lstConfirmPurchase.Location = new System.Drawing.Point(11, 59);
            this.lstConfirmPurchase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstConfirmPurchase.Name = "lstConfirmPurchase";
            this.lstConfirmPurchase.Size = new System.Drawing.Size(241, 388);
            this.lstConfirmPurchase.TabIndex = 35;
            this.lstConfirmPurchase.Click += new System.EventHandler(this.lstConfirmPurchase_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lstShoppingProducts);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(999, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Purchase Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order:";
            // 
            // lstShoppingProducts
            // 
            this.lstShoppingProducts.FormattingEnabled = true;
            this.lstShoppingProducts.ItemHeight = 24;
            this.lstShoppingProducts.Location = new System.Drawing.Point(75, 59);
            this.lstShoppingProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstShoppingProducts.Name = "lstShoppingProducts";
            this.lstShoppingProducts.Size = new System.Drawing.Size(377, 388);
            this.lstShoppingProducts.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(1007, 624);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(395, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(35, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(121, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 29);
            this.txtSearch.TabIndex = 6;
            // 
            // cbxClients
            // 
            this.cbxClients.FormattingEnabled = true;
            this.cbxClients.Location = new System.Drawing.Point(11, 18);
            this.cbxClients.Name = "cbxClients";
            this.cbxClients.Size = new System.Drawing.Size(241, 32);
            this.cbxClients.TabIndex = 54;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 655);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImageProdct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImageProductPurch)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtUnitsToBuy;
        private System.Windows.Forms.Label lblUnitsBuy;
        private System.Windows.Forms.TextBox lstPackProducDetails;
        private System.Windows.Forms.PictureBox pcbxImageProdct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPackageProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.CheckBox cbService;
        private System.Windows.Forms.Panel pnService;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCaregory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pcImageProductPurch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirmProduct;
        private System.Windows.Forms.ListBox lstConfirmPurchase;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstShoppingProducts;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxClients;
    }
}