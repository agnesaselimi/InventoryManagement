using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Transaction : Form
    {
        List<Product> products = new List<Product>();

        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.TableCustomer();
            dgCustomer.DataSource = dt;
            for (int i = 0; i < dgCustomer.Rows.Count - 1; i++)
            {
                cbCustomer.Items.Add(dgCustomer.Rows[i].Cells[1].Value);
            }
            DataTable dt1 = ClassInventory.Instance.ProductTable();
            dgProduct.DataSource = dt1;
            for (int j = 0; j < dgProduct.Rows.Count - 1; j++)
            {
                cbProduct.Items.Add(dgProduct.Rows[j].Cells[1].Value);
            }
            fillProductsArray();

        }

        private void fillProductsArray()
        {
            DataTable dt = ClassInventory.Instance.ProductTable();
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                Product product = new Product(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
                products.Add(product);
                Console.WriteLine("Ija " + product.ProductName);
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            // int test = Convert.ToInt32(tbQuantity.Text);
            //  int test1 = Convert.ToInt32(tbPrice.Text);
            //  int test2 = test * test1;
            //  tbTotal.Text = test2.ToString();
            ClassInventory.Instance.InsertTransaction(cbCustomer.SelectedText, dateTimePicker1.Text, cbProduct.SelectedText, tbPrice.Text,
                tbQuantity.Text, tbTotal.Text,tbDesc.Text);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float price = 0.0f;
                float quantity = 0.0f;
                quantity = float.Parse(tbQuantity.Text, CultureInfo.InvariantCulture);
                price = float.Parse(tbPrice.Text, CultureInfo.InvariantCulture);
                price *= quantity;

                tbTotal.Text = price.ToString();
            }
            catch { }

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbProduct.SelectedIndex;
            string text = products[selectedIndex].ProductCost;
            tbPrice.Text = text;
            tbQuantity.Text = "";
            tbTotal.Text = "";
        }
    }
}
