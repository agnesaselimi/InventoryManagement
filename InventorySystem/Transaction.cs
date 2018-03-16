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
    public partial class Transaction : Form
    {
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
        }
    }
}
