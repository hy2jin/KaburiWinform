namespace Kaburi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productCard1_Clicked(object sender, Kaburi.Components.Products.IProductCard e)
        {
            MessageBox.Show($"{e.Title}, {e.Price}");
        }
    }
}
