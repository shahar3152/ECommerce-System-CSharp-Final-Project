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
    internal partial class E_Commerce : Form
    {
        private Manager manager;
        private Form _currentForm = null;

        public E_Commerce()
        {
            InitializeComponent();
        }
        public E_Commerce(Manager manager)
        {
            InitializeComponent();
           this.manager = manager;
        }

        private void ExiteButton(object sender, EventArgs e)
        {
            //add save into file or something
            this.Close();
        }
        public void OpenForm(Form newForm)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
                _currentForm.Dispose(); // memory release
            }
            _currentForm = newForm;
            _currentForm.Show();
        }       
        private void AddBuyerButton(object sender, EventArgs e)
        {
            AddBuyer addBuyer = new AddBuyer(manager);
            OpenForm(addBuyer);
        }
        private void AddSellerButton(object sender, EventArgs e)
        {
            AddSeller addSeller = new AddSeller(manager);
            OpenForm(addSeller);
        }      
        private void AddProductToCartButton(object sender, EventArgs e)
        {
            if (manager.Buyers.Count == 0)
            {
                MessageBox.Show("There are no buyers in E_Commerce");
            }
            else if (manager.Sellers.Count == 0)
            {
                MessageBox.Show("There are no sellers in E_Commerce");
            }
            else
            {
                LogIn logIn = new LogIn(this, manager, true); // true = buyer
                OpenForm(logIn);
            }
        }
        private void AddProductToSellerButton(Object sender, EventArgs e)
        {
            if (manager.Sellers.Count == 0)
            {
                MessageBox.Show("There are no sellers in E_Commerce");
            }
            else
            {
                LogIn logIn = new LogIn(this, manager, false); // false = seller
                OpenForm(logIn);
            }
        }
        private void ShowBuyersInfoButton(object sender, EventArgs e)
        {
            ShowBuyersInfo showBuyersInfo = new ShowBuyersInfo(manager);
            OpenForm(showBuyersInfo);
        }
        private void ShowSellersInfoButton(object sender, EventArgs e)
        {
            ShowSellersInfo showSellersInfo = new ShowSellersInfo(manager);
            OpenForm(showSellersInfo);
        }
    }
}
