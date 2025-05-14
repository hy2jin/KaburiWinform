using Kaburi.Dialogs;

namespace Kaburi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogBox.ShowReceiptDialog(this, pickList.GetItems());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pickList.Clear();
        }
    }
}
