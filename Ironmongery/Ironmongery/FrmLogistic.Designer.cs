namespace Ironmongery
{
    partial class FrmLogistic
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
            this.scLogic = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvLogic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scLogic)).BeginInit();
            this.scLogic.Panel1.SuspendLayout();
            this.scLogic.Panel2.SuspendLayout();
            this.scLogic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogic)).BeginInit();
            this.SuspendLayout();
            // 
            // scLogic
            // 
            this.scLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLogic.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scLogic.IsSplitterFixed = true;
            this.scLogic.Location = new System.Drawing.Point(0, 0);
            this.scLogic.Name = "scLogic";
            this.scLogic.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLogic.Panel1
            // 
            this.scLogic.Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.scLogic.Panel1.Controls.Add(this.btnSearch);
            this.scLogic.Panel1.Controls.Add(this.txtSearch);
            this.scLogic.Panel1.Controls.Add(this.btnAdd);
            this.scLogic.Panel1.Controls.Add(this.btnEdit);
            this.scLogic.Panel1.Controls.Add(this.btnRemove);
            // 
            // scLogic.Panel2
            // 
            this.scLogic.Panel2.Controls.Add(this.btnCancel);
            this.scLogic.Panel2.Controls.Add(this.dgvLogic);
            this.scLogic.Size = new System.Drawing.Size(809, 531);
            this.scLogic.SplitterDistance = 63;
            this.scLogic.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Image = global::Ironmongery.Properties.Resources.icons8_search_25px_9;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(295, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 30);
            this.txtSearch.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.Image = global::Ironmongery.Properties.Resources.icons8_add_25px_4;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(521, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Assign";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Image = global::Ironmongery.Properties.Resources.icons8_edit_25px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(614, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemove.Image = global::Ironmongery.Properties.Resources.icons8_remove_25px;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(707, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 30);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Delete";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Ironmongery.Properties.Resources.icons8_undo_20px;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(419, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Return";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvLogic
            // 
            this.dgvLogic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogic.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogic.Location = new System.Drawing.Point(0, 0);
            this.dgvLogic.Name = "dgvLogic";
            this.dgvLogic.RowHeadersVisible = false;
            this.dgvLogic.Size = new System.Drawing.Size(809, 464);
            this.dgvLogic.TabIndex = 0;
            // 
            // FrmLogistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 531);
            this.Controls.Add(this.scLogic);
            this.IsMdiContainer = true;
            this.Name = "FrmLogistic";
            this.Text = "FrmLogistic";
            this.Load += new System.EventHandler(this.FrmLogistic_Load);
            this.scLogic.Panel1.ResumeLayout(false);
            this.scLogic.Panel1.PerformLayout();
            this.scLogic.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLogic)).EndInit();
            this.scLogic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scLogic;
        private System.Windows.Forms.DataGridView dgvLogic;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
    }
}