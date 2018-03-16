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
    public partial class VendorDetails : Form
    {
        public VendorDetails()
        {
            InitializeComponent();
        }

        private void VendorDetails_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.VendorTable();
            dg.DataSource = dt;
        }
    }
}
