using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaburi.Components.Picks
{
    public partial class PickItem : UserControl
    {
        private int _count;
        private decimal _defaultPrice;

        void SetSumPrice()
        {
            lblSumPrice.Text = $"{_defaultPrice * _count:#,###}원";
        }
        public PickItem()
        {
            InitializeComponent();
        }

        public event EventHandler? CountChanged;
        public event EventHandler? DeleteClicked;

        public int ID { get; set; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value.Trim(); }
        public Image Image { get => picBox.Image; set => picBox.Image = value; }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 1) return;

                _count = value;
                lblCount.Text = _count.ToString();
                SetSumPrice();
                CountChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public decimal DefaultPrice
        {
            get { return _defaultPrice; }
            set
            {
                _defaultPrice = value;
                SetSumPrice();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Count--;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Count++;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
