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

            /*
            string Username = tbUserName.Text;
            string Password = tbPassword.Text;
            if (Username == "" && Password == "")
            {
                this.Hide();
                loginImpl.onUserLogin();

            }
            else
            {
                loginImpl.onUserFailToLogin("User not found.");
            }*/

            loginUser();
        }
        
        private void loginUser()  
        {
            string Username = tbUserName.Text;
            string Password = tbPassword.Text;
            UserHelper.user = ClassInventory.Instance.UserTable(Username, Password);
            
            if (UserHelper.user != null)
            {
                MessageBox.Show("G " + UserHelper.user.getRole());

            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
