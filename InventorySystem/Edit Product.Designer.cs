namespace InventorySystem
{
    partial class Edit_Product
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
            this.cbID = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(260, 94);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(220, 21);
            this.cbID.TabIndex = 56;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(189, 279);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 55;
            this.lblCategory.Text = "Category";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(260, 164);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(197, 20);
            this.tbCost.TabIndex = 54;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(260, 194);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(340, 70);
            this.tbDesc.TabIndex = 53;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(189, 209);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 52;
            this.lblDesc.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(260, 133);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 20);
            this.tbName.TabIndex = 51;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(189, 171);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 50;
            this.lblCost.Text = "Cost";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(179, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Product Name";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 116);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(107, 79);
            this.dg.TabIndex = 57;
            this.dg.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(189, 94);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 58;
            this.lblID.Text = "ID";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(370, 352);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 61;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(192, 352);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 60;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(12, 220);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(107, 79);
            this.dg1.TabIndex = 62;
            this.dg1.Visible = false;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(260, 279);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(220, 21);
            this.cbCategory.TabIndex = 63;
            // 
            // Edit_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 504);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblName);
            this.Name = "Edit_Product";
            this.Text = "Edit_Product";
            this.Load += new System.EventHandler(this.Edit_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}