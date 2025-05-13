using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kaburi.Models;

namespace Kaburi.Components.Products
{
    public interface IProductCard
    {
        event EventHandler<IProductCard> Clicked;

        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Image Image { get; set; }
        public Product ToProduct()
        {
            return new Product
            {
                ID = ID,
                Title = Title,
                Price = Price,
                Image = Image,
            };
        }
    }

    [DefaultEvent("Clicked")]
    public partial class ProductCard: UserControl, IProductCard
    {
        private decimal _price;

        public ProductCard()
        {
            InitializeComponent();
            AddClickEvent(this);
        }

        private void AddClickEvent(Control parentControl)
        {
            foreach(Control control in parentControl.Controls)
            {
                control.Click += (_, __) => Clicked?.Invoke(this, this);
                if (control.HasChildren)
                {
                    AddClickEvent(control);
                }
            }
        }

        public int ID { get; set; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value.Trim(); }
        public decimal Price { 
            get => _price;
            set {
                _price = value;
                SetPrice();
            }
        }
        public Image Image { get => picBox.Image; set => picBox.Image = value; }

        public event EventHandler<IProductCard>? Clicked;

        private void SetPrice()
        {
            lblPrice.Text = $"{_price:#,000}원";
        }
    }
}
