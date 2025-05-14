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
            kioskEventHub1.Payment();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            kioskEventHub1.Clear();
        }
    }
}
