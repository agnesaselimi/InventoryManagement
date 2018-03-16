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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string Date = dtpBirth.Text;
            string Email = tbEmail.Text;
            string Gender = cbGender.Text;
            string Address = tbAddress.Text;
            int val = ClassInventory.Instance.InsertCustomer(Name, Date, Email, Gender, Address);
            if (val > 0)
            {
                MessageBox.Show("Customer has been Registered");
                tbName.Text = "";
                tbEmail.Text="";
                tbAddress.Text = "";

            }
        }
    }
}
