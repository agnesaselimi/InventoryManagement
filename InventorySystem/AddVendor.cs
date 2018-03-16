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
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            InitializeComponent();
        }

        private void AddVendor_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.ProductList();
            dg.DataSource = dt;
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            { 
           cbProduct.Items.Add(dg.Rows[i].Cells[0].Value);
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string Name=tbName.Text;
            string Email=tbEmail.Text;
            string Address=tbAddress.Text;
            string Product=cbProduct.Text;
            int val = ClassInventory.Instance.InsertVendor(Name, Email, Address, Product);
            if (val > 0)
            {
                MessageBox.Show("Vendor Added");
            }
        }
    }
}
