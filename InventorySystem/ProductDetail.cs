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
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.ProductTable();
            dataGridView1.DataSource = dt;

            List<Product> products = new List<Product>();
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                // public Product(int id, string ProductName, string ProductCost, string ProductDescription, string ProductCategory)

                Product product = new Product(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), 
                    dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
                products.Add(product);
                Console.WriteLine("Ija " + product.ProductName);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
