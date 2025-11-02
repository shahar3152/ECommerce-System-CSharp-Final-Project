using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce
{
    internal partial class LogIn : Form
    {
        private Manager manager;
        private bool userType;
        private E_Commerce mainMenu;
        public LogIn()
        {
            InitializeComponent();
        }
        public LogIn(E_Commerce mainMenu, Manager manager, bool userType)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.manager=manager;
            this.userType = userType;
        }       
        
        private void UsernameTextBox(object sender, EventArgs e)
        {

        }
        private void PasswordTextBox(object sender, EventArgs e)
        {

        }
        
        private void ExitButton(object sender, EventArgs e) 
        {
            this.Close();
        }
        private void SubmitButton(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameTB.Text;
                manager.ValidateUsername(username);
                string password = PasswordTB.Text;
                manager.ValidatePassword(password);
                if (!userType)
                {
                    int sellerIndex = manager.LogIn(username, password, userType);

                    if (sellerIndex == -1)
                    {
                        throw new InvalidOperationException("Incorrect username or password");
                    }
                    AddProductToSeller addProductToSeller = new AddProductToSeller(manager, sellerIndex);
                    mainMenu.OpenForm(addProductToSeller);
                }
                else
                {
                    int buyerIndex = manager.LogIn(username, password, userType);

                    if (buyerIndex == -1)
                    {
                        throw new InvalidOperationException("Incorrect username or password");
                    }
                    AddProductToCart addProductToCart = new AddProductToCart(manager, buyerIndex);
                    mainMenu.OpenForm(addProductToCart);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Log in failed: {ex.Message}", "Log in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogInLabel(object sender, EventArgs e)
        {

        }
        private void UsernameLabel(object sender, EventArgs e)
        {

        }
        private void PasswordLabel(object sender, EventArgs e)
        {

        }
    }
}
