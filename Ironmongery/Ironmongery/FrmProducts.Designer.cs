namespace Ironmongery
{
    partial class FrmProducts
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
            this.spProduct = new System.Windows.Forms.SplitContainer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.dvgProduct = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spProduct)).BeginInit();
            this.spProduct.Panel1.SuspendLayout();
            this.spProduct.Panel2.SuspendLayout();
            this.spProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // spProduct
            // 
            this.spProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spProduct.Location = new System.Drawing.Point(0, 0);
            this.spProduct.Margin = new System.Windows.Forms.Padding(4);
            this.spProduct.Name = "spProduct";
            this.spProduct.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spProduct.Panel1
            // 
            this.spProduct.Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.spProduct.Panel1.Controls.Add(this.btnCancel);
            this.spProduct.Panel1.Controls.Add(this.btnSearch);
            this.spProduct.Panel1.Controls.Add(this.txtSearch);
            this.spProduct.Panel1.Controls.Add(this.btnEdit);
            this.spProduct.Panel1.Controls.Add(this.btnRemove);
            this.spProduct.Panel1.Controls.Add(this.btnNewProduct);
            // 
            // spProduct.Panel2
            // 
            this.spProduct.Panel2.Controls.Add(this.dvgProduct);
            this.spProduct.Panel2.Controls.Add(this.dgvProducts);
            this.spProduct.Size = new System.Drawing.Size(1084, 629);
            this.spProduct.SplitterDistance = 66;
            this.spProduct.SplitterWidth = 5;
            this.spProduct.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Image = global::Ironmongery.Properties.Resources.icons8_undo_20px;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(594, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Return";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Image = global::Ironmongery.Properties.Resources.icons8_search_25px_9;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(400, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 37);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(28, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 34);
            this.txtSearch.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Image = global::Ironmongery.Properties.Resources.icons8_edit_25px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(825, 14);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 37);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemove.Image = global::Ironmongery.Properties.Resources.icons8_remove_25px;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(949, 14);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 37);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Delete";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewProduct.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewProduct.Image = global::Ironmongery.Properties.Resources.icons8_add_25px_4;
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.Location = new System.Drawing.Point(701, 14);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(116, 37);
            this.btnNewProduct.TabIndex = 6;
            this.btnNewProduct.Text = "Add";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // dvgProduct
            // 
            this.dvgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduct.Location = new System.Drawing.Point(12, 14);
            this.dvgProduct.Name = "dvgProduct";
            this.dvgProduct.RowHeadersWidth = 51;
            this.dvgProduct.RowTemplate.Height = 24;
            this.dvgProduct.Size = new System.Drawing.Size(1053, 530);
            this.dvgProduct.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(1084, 558);
            this.dgvProducts.TabIndex = 0;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 629);
            this.Controls.Add(this.spProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmProducts_VisibleChanged);
            this.spProduct.Panel1.ResumeLayout(false);
            this.spProduct.Panel1.PerformLayout();
            this.spProduct.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spProduct)).EndInit();
            this.spProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dvgProduct;
    }
}