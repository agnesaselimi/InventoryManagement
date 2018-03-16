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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            DataTable dt = InventoryClass.StaffTable();
            dgStaffInfo.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
