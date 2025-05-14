using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaburi.Components
{
    public partial class OrderSummaryControl: UserControl
    {
        private int _count;
        private decimal _totalPrice;
        private void SetLblCount()
        {
            lblCount.Text = _count.ToString();
        }
        private void SetLblTotalPrice()
        {
            lblTotalPrice.Text = $"{_totalPrice: #,##0}원";
        }

        public OrderSummaryControl()
        {
            InitializeComponent();
            SetLblCount();
            SetLblTotalPrice();
        }
        public Color BorderColor { get => roundedPanel1.BorderColor; set => roundedPanel1.BorderColor = value; }
        public int BorderWidth { get => roundedPanel1.BorderWidth; set => roundedPanel1.BorderWidth = value; }

        public int Count
        {
            get { return _count; }
            set {
                _count = value;
                SetLblCount();
            }
        }
        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set {
                _totalPrice = value;
                SetLblTotalPrice();
            }
        }
    }
}
