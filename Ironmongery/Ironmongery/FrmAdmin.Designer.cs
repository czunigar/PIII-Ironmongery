namespace Ironmongery
{
    partial class FrmAdmin
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
            this.scAdmin = new System.Windows.Forms.SplitContainer();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTruck = new System.Windows.Forms.Button();
            this.BtnServices = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTruck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogged = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scAdmin)).BeginInit();
            this.scAdmin.Panel1.SuspendLayout();
            this.scAdmin.Panel2.SuspendLayout();
            this.scAdmin.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scAdmin
            // 
            this.scAdmin.Location = new System.Drawing.Point(1, 25);
            this.scAdmin.Name = "scAdmin";
            this.scAdmin.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAdmin.Panel1
            // 
            this.scAdmin.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.scAdmin.Panel1.Controls.Add(this.lblTitle);
            // 
            // scAdmin.Panel2
            // 
            this.scAdmin.Panel2.Controls.Add(this.btnTruck);
            this.scAdmin.Panel2.Controls.Add(this.BtnServices);
            this.scAdmin.Panel2.Controls.Add(this.btnProducts);
            this.scAdmin.Panel2.Controls.Add(this.btnUsers);
            this.scAdmin.Size = new System.Drawing.Size(810, 574);
            this.scAdmin.SplitterDistance = 56;
            this.scAdmin.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(805, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MAINTENANCE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTruck
            // 
            this.btnTruck.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruck.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTruck.Image = global::Ironmongery.Properties.Resources.icons8_delivery_125px_1;
            this.btnTruck.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTruck.Location = new System.Drawing.Point(451, 257);
            this.btnTruck.Name = "btnTruck";
            this.btnTruck.Size = new System.Drawing.Size(209, 178);
            this.btnTruck.TabIndex = 3;
            this.btnTruck.Text = "TRUCKS";
            this.btnTruck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTruck.UseVisualStyleBackColor = true;
            this.btnTruck.Click += new System.EventHandler(this.btnTruck_Click);
            // 
            // BtnServices
            // 
            this.BtnServices.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServices.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnServices.Image = global::Ironmongery.Properties.Resources.icons8_request_service_125px;
            this.BtnServices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnServices.Location = new System.Drawing.Point(147, 257);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(209, 178);
            this.BtnServices.TabIndex = 2;
            this.BtnServices.Text = "SERVICES";
            this.BtnServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnServices.UseVisualStyleBackColor = true;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnProducts.Image = global::Ironmongery.Properties.Resources.icons8_add_shopping_cart_125px_3;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducts.Location = new System.Drawing.Point(451, 52);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(209, 175);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUsers.Image = global::Ironmongery.Properties.Resources.icons8_staff_125px;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(147, 52);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(209, 178);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "USERS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // mnMain
            // 
            this.mnMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMenu,
            this.mnUsr});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(811, 25);
            this.mnMain.TabIndex = 2;
            this.mnMain.Text = "menuStrip1";
            // 
            // mnMenu
            // 
            this.mnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUsers,
            this.mnProducts,
            this.mnTruck,
            this.mnService,
            this.toolStripSeparator1,
            this.mnExit});
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(53, 21);
            this.mnMenu.Text = "Menu";
            // 
            // mnUsers
            // 
            this.mnUsers.Name = "mnUsers";
            this.mnUsers.Size = new System.Drawing.Size(180, 22);
            this.mnUsers.Text = "Users";
            this.mnUsers.Click += new System.EventHandler(this.mnUsers_Click);
            // 
            // mnProducts
            // 
            this.mnProducts.Name = "mnProducts";
            this.mnProducts.Size = new System.Drawing.Size(180, 22);
            this.mnProducts.Text = "Products";
            this.mnProducts.Click += new System.EventHandler(this.mnProducts_Click);
            // 
            // mnTruck
            // 
            this.mnTruck.Name = "mnTruck";
            this.mnTruck.Size = new System.Drawing.Size(180, 22);
            this.mnTruck.Text = "Trucks";
            this.mnTruck.Click += new System.EventHandler(this.mnTruck_Click);
            // 
            // mnService
            // 
            this.mnService.Name = "mnService";
            this.mnService.Size = new System.Drawing.Size(180, 22);
            this.mnService.Text = "Services";
            this.mnService.Click += new System.EventHandler(this.mnService_Click);
            // 
            // mnUsr
            // 
            this.mnUsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogged});
            this.mnUsr.Name = "mnUsr";
            this.mnUsr.Size = new System.Drawing.Size(47, 21);
            this.mnUsr.Text = "User";
            // 
            // mnLogged
            // 
            this.mnLogged.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSignOut});
            this.mnLogged.Name = "mnLogged";
            this.mnLogged.Size = new System.Drawing.Size(180, 22);
            this.mnLogged.Text = "Logged";
            // 
            // mnSignOut
            // 
            this.mnSignOut.Name = "mnSignOut";
            this.mnSignOut.Size = new System.Drawing.Size(180, 22);
            this.mnSignOut.Text = "Sign Out";
            this.mnSignOut.Click += new System.EventHandler(this.mnSignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(180, 22);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.scAdmin);
            this.Controls.Add(this.mnMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnMain;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            this.scAdmin.Panel1.ResumeLayout(false);
            this.scAdmin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAdmin)).EndInit();
            this.scAdmin.ResumeLayout(false);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer scAdmin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnMenu;
        private System.Windows.Forms.ToolStripMenuItem mnUsers;
        private System.Windows.Forms.ToolStripMenuItem mnProducts;
        private System.Windows.Forms.ToolStripMenuItem mnTruck;
        private System.Windows.Forms.ToolStripMenuItem mnService;
        private System.Windows.Forms.ToolStripMenuItem mnUsr;
        private System.Windows.Forms.ToolStripMenuItem mnLogged;
        private System.Windows.Forms.ToolStripMenuItem mnSignOut;
        private System.Windows.Forms.Button btnTruck;
        private System.Windows.Forms.Button BtnServices;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
    }
}