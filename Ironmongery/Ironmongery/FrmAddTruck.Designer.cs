namespace Ironmongery
{
    partial class FrmAddTruck
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
            this.scTruck = new System.Windows.Forms.SplitContainer();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblTruck = new System.Windows.Forms.Label();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboTruck = new System.Windows.Forms.ComboBox();
            this.eTruck = new System.Windows.Forms.ErrorProvider(this.components);
            this.eDriver = new System.Windows.Forms.ErrorProvider(this.components);
            this.eStatus = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scTruck)).BeginInit();
            this.scTruck.Panel1.SuspendLayout();
            this.scTruck.Panel2.SuspendLayout();
            this.scTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // scTruck
            // 
            this.scTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTruck.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scTruck.IsSplitterFixed = true;
            this.scTruck.Location = new System.Drawing.Point(0, 0);
            this.scTruck.Name = "scTruck";
            this.scTruck.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scTruck.Panel1
            // 
            this.scTruck.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.scTruck.Panel1.Controls.Add(this.lblTitle);
            // 
            // scTruck.Panel2
            // 
            this.scTruck.Panel2.Controls.Add(this.cboTruck);
            this.scTruck.Panel2.Controls.Add(this.cboStatus);
            this.scTruck.Panel2.Controls.Add(this.cboDriver);
            this.scTruck.Panel2.Controls.Add(this.lblId);
            this.scTruck.Panel2.Controls.Add(this.txtId);
            this.scTruck.Panel2.Controls.Add(this.lblStatus);
            this.scTruck.Panel2.Controls.Add(this.btnSave);
            this.scTruck.Panel2.Controls.Add(this.lblDriver);
            this.scTruck.Panel2.Controls.Add(this.lblTruck);
            this.scTruck.Size = new System.Drawing.Size(820, 382);
            this.scTruck.SplitterDistance = 67;
            this.scTruck.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(814, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ASSIGN TRUCK";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(74, 104);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(105, 104);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 26);
            this.txtId.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(239, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Ironmongery.Properties.Resources.icons8_create_20px_3;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(315, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriver.Location = new System.Drawing.Point(239, 104);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(59, 24);
            this.lblDriver.TabIndex = 19;
            this.lblDriver.Text = "Driver";
            this.lblDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTruck
            // 
            this.lblTruck.AutoSize = true;
            this.lblTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruck.Location = new System.Drawing.Point(239, 50);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(132, 24);
            this.lblTruck.TabIndex = 17;
            this.lblTruck.Text = "Truck Number";
            // 
            // cboDriver
            // 
            this.cboDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.Location = new System.Drawing.Point(411, 104);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(210, 28);
            this.cboDriver.TabIndex = 25;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Completed",
            "Busy",
            "Available"});
            this.cboStatus.Location = new System.Drawing.Point(411, 166);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(210, 28);
            this.cboStatus.TabIndex = 26;
            // 
            // cboTruck
            // 
            this.cboTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTruck.FormattingEnabled = true;
            this.cboTruck.Location = new System.Drawing.Point(411, 46);
            this.cboTruck.Name = "cboTruck";
            this.cboTruck.Size = new System.Drawing.Size(210, 28);
            this.cboTruck.TabIndex = 27;
            // 
            // eTruck
            // 
            this.eTruck.ContainerControl = this;
            // 
            // eDriver
            // 
            this.eDriver.ContainerControl = this;
            // 
            // eStatus
            // 
            this.eStatus.ContainerControl = this;
            // 
            // FrmAddTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 382);
            this.Controls.Add(this.scTruck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTruck";
            this.Load += new System.EventHandler(this.FrmAddTruck_Load);
            this.scTruck.Panel1.ResumeLayout(false);
            this.scTruck.Panel2.ResumeLayout(false);
            this.scTruck.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTruck)).EndInit();
            this.scTruck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scTruck;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.ComboBox cboTruck;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ErrorProvider eTruck;
        private System.Windows.Forms.ErrorProvider eDriver;
        private System.Windows.Forms.ErrorProvider eStatus;
    }
}