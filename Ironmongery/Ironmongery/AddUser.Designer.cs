namespace Ironmongery
{
    partial class AddUser
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
            this.lblCid = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckAdmin = new System.Windows.Forms.CheckBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.eCid = new System.Windows.Forms.ErrorProvider(this.components);
            this.eName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePass = new System.Windows.Forms.ErrorProvider(this.components);
            this.eCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.eRole = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scAdd)).BeginInit();
            this.scAdd.Panel1.SuspendLayout();
            this.scAdd.Panel2.SuspendLayout();
            this.scAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eCid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRole)).BeginInit();
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
            this.scAdd.Panel2.Controls.Add(this.lblCid);
            this.scAdd.Panel2.Controls.Add(this.txtCid);
            this.scAdd.Panel2.Controls.Add(this.cboType);
            this.scAdd.Panel2.Controls.Add(this.btnSave);
            this.scAdd.Panel2.Controls.Add(this.ckAdmin);
            this.scAdd.Panel2.Controls.Add(this.lblType);
            this.scAdd.Panel2.Controls.Add(this.lblPass);
            this.scAdd.Panel2.Controls.Add(this.txtPass);
            this.scAdd.Panel2.Controls.Add(this.lblUsername);
            this.scAdd.Panel2.Controls.Add(this.txtName);
            this.scAdd.Panel2.Controls.Add(this.lblCode);
            this.scAdd.Panel2.Controls.Add(this.txtCode);
            this.scAdd.Size = new System.Drawing.Size(820, 382);
            this.scAdd.SplitterDistance = 61;
            this.scAdd.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(346, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NEW USER";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(96, 95);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(100, 122);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 26);
            this.txtId.TabIndex = 15;
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(216, 97);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(38, 24);
            this.lblCid.TabIndex = 14;
            this.lblCid.Text = "Cid";
            // 
            // txtCid
            // 
            this.txtCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCid.Location = new System.Drawing.Point(219, 122);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(210, 26);
            this.txtCid.TabIndex = 13;
            this.txtCid.Validated += new System.EventHandler(this.txtCid_Validated);
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Driver",
            "Builder",
            "Seller",
            "Cashier",
            "Administrator"});
            this.cboType.Location = new System.Drawing.Point(478, 52);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(210, 28);
            this.cboType.TabIndex = 12;
            this.cboType.Validated += new System.EventHandler(this.cboType_Validated);
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
            // ckAdmin
            // 
            this.ckAdmin.AutoSize = true;
            this.ckAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAdmin.Location = new System.Drawing.Point(479, 195);
            this.ckAdmin.Name = "ckAdmin";
            this.ckAdmin.Size = new System.Drawing.Size(84, 28);
            this.ckAdmin.TabIndex = 9;
            this.ckAdmin.Text = "Admin";
            this.ckAdmin.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(475, 27);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 24);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Role";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(475, 97);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(92, 24);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(478, 122);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(210, 26);
            this.txtPass.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(216, 162);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(220, 197);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(216, 27);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 24);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(220, 54);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(210, 26);
            this.txtCode.TabIndex = 0;
            // 
            // eCid
            // 
            this.eCid.ContainerControl = this;
            // 
            // eName
            // 
            this.eName.ContainerControl = this;
            // 
            // ePass
            // 
            this.ePass.ContainerControl = this;
            // 
            // eCode
            // 
            this.eCode.ContainerControl = this;
            // 
            // eRole
            // 
            this.eRole.ContainerControl = this;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 382);
            this.Controls.Add(this.scAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.scAdd.Panel1.ResumeLayout(false);
            this.scAdd.Panel1.PerformLayout();
            this.scAdd.Panel2.ResumeLayout(false);
            this.scAdd.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAdd)).EndInit();
            this.scAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eCid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckAdmin;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider eCid;
        private System.Windows.Forms.ErrorProvider eName;
        private System.Windows.Forms.ErrorProvider ePass;
        private System.Windows.Forms.ErrorProvider eCode;
        private System.Windows.Forms.ErrorProvider eRole;
    }
}