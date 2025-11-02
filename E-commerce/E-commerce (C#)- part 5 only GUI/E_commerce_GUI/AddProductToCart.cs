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
    internal partial class AddProductToCart : Form
    {
        private Manager manager;
        private int buyerIndex;
        public AddProductToCart()
        {
            InitializeComponent();
        }
        public AddProductToCart(Manager manager, int buyerIndex)
        {
            InitializeComponent();
            this.manager = manager;
            this.buyerIndex = buyerIndex;
        }

        private void ExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProductNameTextBox(object sender, EventArgs e)
        {

        }
        private void SearchButton(object sender, EventArgs e)
        {
            string searchName = ProductNTB.Text;
            string productList = manager.PrintProductsOptions(searchName);
            ProductLRTB.Text = productList;
        }       
        private void ProductListRichTextBox(object sender, EventArgs e)
        {

        }
        private void ProductIdNumericUpDown(object sender, EventArgs e)
        {

        }
        private void SubmitButton(object sender, EventArgs e)
        {
            try
            {
                if (ProductLRTB.Text == "The product you are looking for isn't being sold")
                {
                    throw new ArgumentOutOfRangeException("");
                }
                int id = (int)ProductIdN.Value;
                manager.AddProductToBuyer(buyerIndex, id);
                this.Close();
                MessageBox.Show("Product successfully added");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"{ex.Message}\nYou can search again for a different product", "Empty option", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.Message}. Please enter a valid id", "Id error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ProductNTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductIdN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
