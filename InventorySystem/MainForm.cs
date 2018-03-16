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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory AC = new AddCategory();
            AC.Show();
        }

        private void btnCustomerReg_Click(object sender, EventArgs e)
        {
            CustomerRegistration CR = new CustomerRegistration();
            CR.Show();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
          
            AddProduct AP = new AddProduct();
            AP.Show();
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
          
            Edit_Product EP = new Edit_Product();
            EP.Show();
        }

        private void btVendor_Click(object sender, EventArgs e)
        {
            
        }

        private void btVendorDetail_Click(object sender, EventArgs e)
        {
      
        }

        private void btOrderDetail_Click(object sender, EventArgs e)
        {
            OrderDetail OD = new OrderDetail();
            OD.Show();
        }

        private void btProductDetail_Click(object sender, EventArgs e)
        {
            ProductDetail PD = new ProductDetail();
            PD.Show();

        }

        private void btCustomerDetail_Click(object sender, EventArgs e)
        {
            CustomerDetail CD = new CustomerDetail();
            CD.Show();
        }

        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            Transaction T = new Transaction();
            T.Show();
        }

        private void btVendor_Click_1(object sender, EventArgs e)
        {
            AddVendor AV = new AddVendor();
            AV.Show();
        }

        private void btVendorDetail_Click_1(object sender, EventArgs e)
        {
            VendorDetails VD = new VendorDetails();
            VD.Show();
        }
    }
}
