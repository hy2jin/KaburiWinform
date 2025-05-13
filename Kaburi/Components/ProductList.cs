using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Kaburi.Models;
using Kaburi.Components.Products;

namespace Kaburi.Components
{
    public partial class ProductList: UserControl
    {
        public ProductList()
        {
            InitializeComponent();

            Items.CollectionChanged += Items_CollectionChanged;
        }

        private void Items_CollectionChanged(object? sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in Items)
            {
                var productCard = new ProductCard
                {
                    ID = item.ID,
                    Title = item.Title,
                    Price = item.Price,
                    Image = item.Image!,    // !: null이 아님을 보장
                };
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Product> Items { get; set; } = [];
    }
}
