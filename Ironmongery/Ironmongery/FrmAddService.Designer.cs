namespace Ironmongery
{
    partial class FrmAddService
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
            this.components = new System.ComponentModel.Container();
            this.scAdd = new System.Windows.Forms.SplitContainer();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.eName = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.eCat = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scAdd)).BeginInit();
            this.scAdd.Panel1.SuspendLayout();
            this.scAdd.Panel2.SuspendLayout();
            this.scAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // scAdd
            // 
            this.scAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAdd.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scAdd.IsSplitterFixed = true;
            this.scAdd.Location = new System.Drawing.Point(0, 0);
            this.scAdd.Name = "scAdd";
            this.scAdd.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAdd.Panel1
            // 
            this.scAdd.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.scAdd.Panel1.Controls.Add(this.lblTitle);
            // 
            // scAdd.Panel2
            // 
            this.scAdd.Panel2.Controls.Add(this.lblId);
            this.scAdd.Panel2.Controls.Add(this.txtId);
            this.scAdd.Panel2.Controls.Add(this.lblDesc);
            this.scAdd.Panel2.Controls.Add(this.txtDesc);
            this.scAdd.Panel2.Controls.Add(this.cboCat);
            this.scAdd.Panel2.Controls.Add(this.btnSave);
            this.scAdd.Panel2.Controls.Add(this.lblCat);
            this.scAdd.Panel2.Controls.Add(this.lblPrice);
            this.scAdd.Panel2.Controls.Add(this.txtPrice);
            this.scAdd.Panel2.Controls.Add(this.txtName);
            this.scAdd.Panel2.Controls.Add(this.lblName);
            this.scAdd.Size = new System.Drawing.Size(820, 382);
            this.scAdd.SplitterDistance = 61;
            this.scAdd.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(310, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NEW SERVICE";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(93, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(97, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 26);
            this.txtId.TabIndex = 15;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(211, 122);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(104, 24);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(214, 149);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(210, 26);
            this.txtDesc.TabIndex = 13;
            // 
            // cboCat
            // 
            this.cboCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Items.AddRange(new object[] {
            "Delivery",
            "Building",
            "Assessment"});
            this.cboCat.Location = new System.Drawing.Point(473, 77);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(210, 28);
            this.cboCat.TabIndex = 12;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(470, 52);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(85, 24);
            this.lblCat.TabIndex = 7;
            this.lblCat.Text = "Category";
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(470, 122);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(473, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ShortcutsEnabled = false;
            this.txtPrice.Size = new System.Drawing.Size(210, 26);
            this.txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(214, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(211, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Ironmongery.Properties.Resources.icons8_create_20px_3;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(315, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // eName
            // 
            this.eName.ContainerControl = this;
            // 
            // eDesc
            // 
            this.eDesc.ContainerControl = this;
            // 
            // eCat
            // 
            this.eCat.ContainerControl = this;
            // 
            // ePrice
            // 
            this.ePrice.ContainerControl = this;
            // 
            // FrmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 382);
            this.Controls.Add(this.scAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddService";
            this.Text = "FrmAddService";
            this.scAdd.Panel1.ResumeLayout(false);
            this.scAdd.Panel1.PerformLayout();
            this.scAdd.Panel2.ResumeLayout(false);
            this.scAdd.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAdd)).EndInit();
            this.scAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider eName;
        private System.Windows.Forms.ErrorProvider eDesc;
        private System.Windows.Forms.ErrorProvider eCat;
        private System.Windows.Forms.ErrorProvider ePrice;
    }
}