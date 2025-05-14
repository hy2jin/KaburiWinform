using System.Collections.Generic;
using Kaburi.Components.Picks;

namespace Kaburi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productList1_ItemClicked(object sender, Kaburi.Models.Product e)
        {
            pickList.AddItem(e);
        }

        private void pickList_ItemValueChanged(List<PickItem> pickItems)
        {
            int totalCount = pickItems.Sum(item => item.Count);
            decimal totalPrice = pickItems.Sum(item => item.Count * item.DefaultPrice);

            orderSummaryControl1.Count = totalCount;
            orderSummaryControl1.TotalPrice = totalPrice;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
