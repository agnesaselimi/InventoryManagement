using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AddProduct : Form
    {
        private ProductImpl prouctImpl;
        class ProductImpl : ProductInterface
        {
            public void onAddProduct(bool success)
            {
                Console.WriteLine("success " + success);
            }
        }
        public AddProduct()
        {
            InitializeComponent();
            prouctImpl = new ProductImpl();


        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.ProductCategoryList();
           
            dg.DataSource = dt;
            for (int i = 0; i < dg.Rows.Count-1; i++)
            {
                cbCategory.Items.Add(dg.Rows[i].Cells[0].Value);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string Cost = tbCost.Text;
            string Desc = tbDesc.Text;
            string Category = cbCategory.Text;
            int val = ClassInventory.Instance.InsertProduct(Name, Cost, Desc, Category);
            if (val > 0)
            {
                prouctImpl.onAddProduct(true);
                MessageBox.Show("Product Added");
            }
        }
    }
}
