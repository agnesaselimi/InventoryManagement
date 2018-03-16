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
    public partial class CustomerDetail : Form
    {
        public CustomerDetail()
        {
            InitializeComponent();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassInventory.Instance.TableCustomer();
            dgCustomerDetail.DataSource = dt;
        }
    }
}
