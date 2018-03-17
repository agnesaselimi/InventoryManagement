namespace InventorySystem
{
    partial class MainForm
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
            this.btnCustomerReg = new System.Windows.Forms.Button();
            this.btCustomerDetail = new System.Windows.Forms.Button();
            this.btOrderDetail = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.btProductDetail = new System.Windows.Forms.Button();
            this.btAddCategory = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btVendorDetail = new System.Windows.Forms.Button();
            this.btVendor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerReg
            // 
            this.btnCustomerReg.Location = new System.Drawing.Point(278, 188);
            this.btnCustomerReg.Name = "btnCustomerReg";
            this.btnCustomerReg.Size = new System.Drawing.Size(149, 55);
            this.btnCustomerReg.TabIndex = 1;
            this.btnCustomerReg.Text = "Customer Registration";
            this.btnCustomerReg.UseVisualStyleBackColor = true;
            this.btnCustomerReg.Click += new System.EventHandler(this.btnCustomerReg_Click);
            // 
            // btCustomerDetail
            // 
            this.btCustomerDetail.Location = new System.Drawing.Point(278, 249);
            this.btCustomerDetail.Name = "btCustomerDetail";
            this.btCustomerDetail.Size = new System.Drawing.Size(149, 55);
            this.btCustomerDetail.TabIndex = 2;
            this.btCustomerDetail.Text = "Customer Detail";
            this.btCustomerDetail.UseVisualStyleBackColor = true;
            this.btCustomerDetail.Click += new System.EventHandler(this.btCustomerDetail_Click);
            // 
            // btOrderDetail
            // 
            this.btOrderDetail.Location = new System.Drawing.Point(278, 310);
            this.btOrderDetail.Name = "btOrderDetail";
            this.btOrderDetail.Size = new System.Drawing.Size(149, 55);
            this.btOrderDetail.TabIndex = 3;
            this.btOrderDetail.Text = "Order Detail";
            this.btOrderDetail.UseVisualStyleBackColor = true;
            this.btOrderDetail.Click += new System.EventHandler(this.btOrderDetail_Click);
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(433, 127);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(149, 55);
            this.btAddProduct.TabIndex = 4;
            this.btAddProduct.Text = "Add Product";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.Location = new System.Drawing.Point(433, 188);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(149, 55);
            this.btEditProduct.TabIndex = 5;
            this.btEditProduct.Text = "Edit Product";
            this.btEditProduct.UseVisualStyleBackColor = true;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // btProductDetail
            // 
            this.btProductDetail.Location = new System.Drawing.Point(433, 249);
            this.btProductDetail.Name = "btProductDetail";
            this.btProductDetail.Size = new System.Drawing.Size(149, 55);
            this.btProductDetail.TabIndex = 7;
            this.btProductDetail.Text = "Product Detail";
            this.btProductDetail.UseVisualStyleBackColor = true;
            this.btProductDetail.Click += new System.EventHandler(this.btProductDetail_Click);
            // 
            // btAddCategory
            // 
            this.btAddCategory.Location = new System.Drawing.Point(277, 127);
            this.btAddCategory.Name = "btAddCategory";
            this.btAddCategory.Size = new System.Drawing.Size(149, 55);
            this.btAddCategory.TabIndex = 9;
            this.btAddCategory.Text = "Add Category";
            this.btAddCategory.UseVisualStyleBackColor = true;
            this.btAddCategory.Click += new System.EventHandler(this.btAddCategory_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(433, 310);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(149, 55);
            this.btnTransaction.TabIndex = 10;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click_1);
            // 
            // btVendorDetail
            // 
            this.btVendorDetail.Location = new System.Drawing.Point(588, 188);
            this.btVendorDetail.Name = "btVendorDetail";
            this.btVendorDetail.Size = new System.Drawing.Size(149, 55);
            this.btVendorDetail.TabIndex = 12;
            this.btVendorDetail.Text = "Vendor Detail";
            this.btVendorDetail.UseVisualStyleBackColor = true;
            this.btVendorDetail.Click += new System.EventHandler(this.btVendorDetail_Click_1);
            // 
            // btVendor
            // 
            this.btVendor.Location = new System.Drawing.Point(588, 127);
            this.btVendor.Name = "btVendor";
            this.btVendor.Size = new System.Drawing.Size(149, 55);
            this.btVendor.TabIndex = 11;
            this.btVendor.Text = "Add Vendor";
            this.btVendor.UseVisualStyleBackColor = true;
            this.btVendor.Click += new System.EventHandler(this.btVendor_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 727);
            this.Controls.Add(this.btVendorDetail);
            this.Controls.Add(this.btVendor);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btAddCategory);
            this.Controls.Add(this.btProductDetail);
            this.Controls.Add(this.btEditProduct);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.btOrderDetail);
            this.Controls.Add(this.btCustomerDetail);
            this.Controls.Add(this.btnCustomerReg);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCustomerReg;
        private System.Windows.Forms.Button btCustomerDetail;
        private System.Windows.Forms.Button btOrderDetail;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.Button btProductDetail;
        private System.Windows.Forms.Button btAddCategory;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btVendorDetail;
        private System.Windows.Forms.Button btVendor;
    }
}