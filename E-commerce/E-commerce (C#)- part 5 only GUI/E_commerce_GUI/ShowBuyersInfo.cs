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
    internal partial class ShowBuyersInfo : Form
    {
        Manager manager;
        public ShowBuyersInfo()
        {
            InitializeComponent();
        }
        public ShowBuyersInfo(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            FillTextBox();
        }

        private void BuyersInfoRTB(object sender, EventArgs e)
        {
            BuyersRTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            BuyersRTB.ReadOnly = true;
        }
        private void FillTextBox()
        {
            string strBuyers = manager.PrintBuyers();
            BuyersRTB.Text = strBuyers;
        }
        private void ShowBuyersInfo_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
