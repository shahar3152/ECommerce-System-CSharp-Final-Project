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
    internal partial class AddProductToSeller : Form
    {
        private Manager manager;
        private int sellerIndex;
        public AddProductToSeller()
        {
            InitializeComponent();
        }

        public AddProductToSeller(Manager manager, int sellerIndex)
        {
            InitializeComponent();
            this.manager = manager;
            this.sellerIndex = sellerIndex;
        }

        
        private void KidsRadioButton(object sender, EventArgs e)
        {

        }
        private void YesRadioButton(object sender, EventArgs e)
        {

        }
        private void NoRadioButton(object sender, EventArgs e)
        {

        }
        private void ElectronicsRadioButton(object sender, EventArgs e)
        {

        }
        private void OfficeRadioButton(object sender, EventArgs e)
        {

        }
        private void ClothingRadioButton(object sender, EventArgs e)
        {

        }
        
        private void ProductNameTextBox(object sender, EventArgs e)
        {

        }
        private void ProductPriceNumericUpDown(object sender, EventArgs e)
        {

        }
        private void PackagePriceNumericUpDown(object sender, EventArgs e)
        {

        }
        private void OfficeRB_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ClothingRB_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void BackButton(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SubmitButton(object sender, EventArgs e)
        {
            if (KidsRB.Checked == false && ElectRB.Checked == false && OfficeRB.Checked == false && ClothingRB.Checked == false)
            {
                MessageBox.Show("Please choose a category");
            }
            else if (YesRB.Checked == false && NoRB.Checked == false)
            {
                MessageBox.Show("Please choose if the product has a special packaging");
            }
            else
            {
                try
                {
                    string productName = ProductNTB.Text;
                    string category = "";
                    if(KidsRB.Checked)
                    {
                        category = "kids";
                    }
                    else if(ElectRB.Checked)
                    {
                        category = "electronics";
                    }
                    else if (OfficeRB.Checked)
                    {
                        category = "office";
                    }
                    else if(ClothingRB.Checked)
                    {
                        category = "clothing";
                    }
                    float productPrice = (float)ProductPN.Value;
                    float packagePrice = 0;
                    if(YesRB.Checked)
                    {
                        packagePrice = (float)PackagePN.Value;
                    }
                    manager.AddProductToSeller(sellerIndex, productName, productPrice, category, packagePrice);
                    this.Close();
                    MessageBox.Show("Product successfully added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Product error: {ex.Message}", "Product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void CategoryGB_Enter(object sender, EventArgs e)
        {

        }
        private void IsSpecialGB_Enter(object sender, EventArgs e)
        {

        }

        private void ProductPN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
