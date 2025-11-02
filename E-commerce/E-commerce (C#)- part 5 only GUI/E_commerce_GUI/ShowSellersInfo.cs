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
    internal partial class ShowSellersInfo : Form
    {
        private Manager manager;

        public ShowSellersInfo()
        {
            InitializeComponent();
        }
        public ShowSellersInfo(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            FillTextBox();
        }

        private void FillTextBox()
        {
            string strSellers = manager.PrintSellers();
            SellersRTB.Text = strSellers;
        }
        private void ExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowSellersInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void SellersInfoRTB(object sender, EventArgs e)
        {
            SellersRTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            SellersRTB.ReadOnly = true;
        }
    }
}
