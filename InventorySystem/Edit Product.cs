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
    public partial class Edit_Product : Form
    {
        public Edit_Product()
        {
            InitializeComponent();
        }

        private void Edit_Product_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.ProductIDList();
            dg.DataSource = dt;
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {
                cbID.Items.Add(dg.Rows[i].Cells[0].Value);
            }
            DataTable dt1 = ClassInventory.Instance.ProductCategoryList();
            dg1.DataSource = dt1;
            for (int i = 0; i < dg1.Rows.Count - 1; i++)
            {
                cbCategory.Items.Add(dg1.Rows[i].Cells[0].Value);
            }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cbID.Text;
            DataTable dt = ClassInventory.Instance.ProductTable(ID);
            dg.DataSource = dt;
            tbName.Text = dg.Rows[0].Cells[1].Value.ToString();
            tbCost.Text = dg.Rows[0].Cells[2].Value.ToString();
            tbDesc.Text = dg.Rows[0].Cells[3].Value.ToString();
           
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string ID=cbID.Text;
            string Name=tbName.Text;
            string Cost=tbCost.Text;
            string Desc=tbDesc.Text;
            string Category=cbCategory.Text;
            int val = ClassInventory.Instance.UpdateProductTable(ID, Name, Cost, Desc, Category);
            if (val > 0)
            {
                MessageBox.Show("Product Update");
            }
        }
    }
}
