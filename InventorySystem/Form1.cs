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
    public partial class FormLogin : Form
    {
        private class LoginImpl : LoginInterface
        {
    
            public void onUserFailToLogin(string message)
            {
                MessageBox.Show(message);
            }

            public void onUserLogin()
            {
                MainForm MF = new MainForm();
                MF.Show();

            }
        }

        private LoginImpl loginImpl;

        public FormLogin()
        {
            InitializeComponent();
            loginImpl = new LoginImpl();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            loginUser();
        }
        
        private void loginUser()  
        {
            string Username = tbUserName.Text;
            string Password = tbPassword.Text;

            try
            {
                UserHelper.user = ClassInventory.Instance.UserTable(Username, Password);
                MessageBox.Show("Hi " + UserHelper.user.name + ", you have logged in as " + UserHelper.user.getRole() + " successfully");
                loginImpl.onUserLogin();
            }
            catch(UserException e)
            {
                loginImpl.onUserFailToLogin(e.Message);

            }
           
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
