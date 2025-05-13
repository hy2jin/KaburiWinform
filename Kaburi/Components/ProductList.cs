using Kaburi.Components.Products;
using Kaburi.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Kaburi.Components
{
    [DefaultEvent("ItemClicked")]
    public partial class ProductList: UserControl
    {
        public event EventHandler<Product>? ItemClicked;

        public ProductList()
        {
            InitializeComponent();

            Items.CollectionChanged += Items_CollectionChanged;
        }

        private void Items_CollectionChanged(object? sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            flpnl.Controls.Clear(); // 기존 컨트롤 제거

            foreach (var item in Items)
            {
                var productCard = new ProductCard
                {
                    ID = item.ID,
                    Title = item.Title,
                    Price = item.Price,
                    Image = item.Image!,    // !: null이 아님을 보장
                };
                productCard.Clicked += ProductCard_Clicked;
                flpnl.Controls.Add(productCard);
            }
        }

        private void ProductCard_Clicked(object? sender, IProductCard e)
        {
            ItemClicked?.Invoke(this, e.ToProduct());
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Product> Items { get; set; } = [];
    }
}
