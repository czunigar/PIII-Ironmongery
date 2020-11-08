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
            this.scAdd = new System.Windows.Forms.SplitContainer();
            this.btnTitle = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.ckAdmin = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scAdd)).BeginInit();
            this.scAdd.Panel1.SuspendLayout();
            this.scAdd.Panel2.SuspendLayout();
            this.scAdd.SuspendLayout();
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
            this.scAdd.Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.scAdd.Panel1.Controls.Add(this.btnTitle);
            // 
            // scAdd.Panel2
            // 
            this.scAdd.Panel2.Controls.Add(this.btnCancel);
            this.scAdd.Panel2.Controls.Add(this.btnSave);
            this.scAdd.Panel2.Controls.Add(this.ckAdmin);
            this.scAdd.Panel2.Controls.Add(this.lblAdmin);
            this.scAdd.Panel2.Controls.Add(this.label4);
            this.scAdd.Panel2.Controls.Add(this.textBox4);
            this.scAdd.Panel2.Controls.Add(this.label3);
            this.scAdd.Panel2.Controls.Add(this.textBox3);
            this.scAdd.Panel2.Controls.Add(this.lblUsername);
            this.scAdd.Panel2.Controls.Add(this.textBox2);
            this.scAdd.Panel2.Controls.Add(this.lblCode);
            this.scAdd.Panel2.Controls.Add(this.txtCode);
            this.scAdd.Size = new System.Drawing.Size(335, 463);
            this.scAdd.SplitterDistance = 61;
            this.scAdd.TabIndex = 0;
            // 
            // btnTitle
            // 
            this.btnTitle.AutoSize = true;
            this.btnTitle.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.Location = new System.Drawing.Point(105, 16);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(138, 27);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "NEW USER";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(68, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(210, 20);
            this.txtCode.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(65, 24);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(65, 93);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 254);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 20);
            this.textBox4.TabIndex = 6;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(65, 302);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin";
            // 
            // ckAdmin
            // 
            this.ckAdmin.AutoSize = true;
            this.ckAdmin.Location = new System.Drawing.Point(110, 302);
            this.ckAdmin.Name = "ckAdmin";
            this.ckAdmin.Size = new System.Drawing.Size(55, 17);
            this.ckAdmin.TabIndex = 9;
            this.ckAdmin.Text = "Admin";
            this.ckAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Ironmongery.Properties.Resources.icons8_undo_20px;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(204, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Return";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Ironmongery.Properties.Resources.icons8_create_20px_3;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(68, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 463);
            this.Controls.Add(this.scAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.scAdd.Panel1.ResumeLayout(false);
            this.scAdd.Panel1.PerformLayout();
            this.scAdd.Panel2.ResumeLayout(false);
            this.scAdd.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAdd)).EndInit();
            this.scAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scAdd;
        private System.Windows.Forms.Label btnTitle;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCode;
    }
}