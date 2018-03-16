namespace InventorySystem
{
    partial class CustomerDetail
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
            this.dgCustomerDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCustomerDetail
            // 
            this.dgCustomerDetail.AllowUserToAddRows = false;
            this.dgCustomerDetail.AllowUserToDeleteRows = false;
            this.dgCustomerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerDetail.Location = new System.Drawing.Point(31, 44);
            this.dgCustomerDetail.Name = "dgCustomerDetail";
            this.dgCustomerDetail.ReadOnly = true;
            this.dgCustomerDetail.Size = new System.Drawing.Size(822, 465);
            this.dgCustomerDetail.TabIndex = 0;
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 539);
            this.Controls.Add(this.dgCustomerDetail);
            this.Name = "CustomerDetail";
            this.Text = "CustomerDetail";
            this.Load += new System.EventHandler(this.CustomerDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustomerDetail;
    }
}