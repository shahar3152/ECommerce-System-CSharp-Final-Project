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
    internal partial class AddBuyer : Form
    {
        private Manager manager;
        public AddBuyer()
        {
            InitializeComponent();
        }
        public AddBuyer(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }
        
        private void BackButton(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SubmitButton(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameTB.Text;
                manager.ValidateUsername(username);
                manager.IsUsernameExist(username);
                string password = PasswordTB.Text;
                manager.ValidatePassword(password);
                string street = StreetTB.Text;
                int houseNumber = (int)HouseNumber.Value;
                string city = CityTB.Text;
                string state = StateTB.Text;
                manager.ValidateAddressFromMain(street, houseNumber, city, state);
                manager.AddBuyer(username, password, street, houseNumber, city, state);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Validation failed: {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UsernameTextBox(object sender, EventArgs e)
        {

        }
        private void PasswordTextBox(object sender, EventArgs e)
        {

        }
        private void StreetTextBox(object sender, EventArgs e)
        {

        }
        private void HouseNumberNumericUpDown(object sender, EventArgs e)
        {

        }
        private void CityTextBox(object sender, EventArgs e)
        {

        }
        private void StateTextBox(object sender, EventArgs e)
        {

        }       
    }
}
