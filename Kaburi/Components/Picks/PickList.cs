using Kaburi.Models;
using System.ComponentModel;

namespace Kaburi.Components.Picks
{
    public delegate void ItemValueChangedHandler(List<PickItem> pickItems);

    [DefaultEvent("ItemValueChanged")]
    public partial class PickList: UserControl
    {
        private List<PickItem> _pickItems = new ();
        private void RaiseItemValueChanged() => ItemValueChanged?.Invoke(_pickItems);

        public PickList()
        {
            InitializeComponent();
        }

        public event ItemValueChangedHandler? ItemValueChanged;
        public Color BorderColor { get => roundedPanel1.BorderColor; set => roundedPanel1.BorderColor = value; }
        public int BorderWidth { get => roundedPanel1.BorderWidth; set => roundedPanel1.BorderWidth = value; }

        public void AddItem(Product product)
        {
            // PickItem이 이미 추가가 되어 있는 경우
            PickItem? pickItem = _pickItems.FirstOrDefault(item => item.ID == product.ID);
            if (pickItem != null)
            {
                pickItem.Count++;
                return;
            }

            // PickItem이 존재하지 않을 경우
            pickItem = new PickItem
            {
                ID = product.ID,
                Title = product.Title,
                DefaultPrice = product.Price,
                Image = product.Image!,
                Count = 1,
            };
            
            pickItem.DeleteClicked += PickItem_DeleteClicked;
            pickItem.CountChanged += PickItem_CountChanged;
            
            _pickItems.Add(pickItem);
            flpnl.Controls.Add(pickItem);
            RaiseItemValueChanged();
        }

        private void PickItem_CountChanged(object? sender, EventArgs e)
        {
            RaiseItemValueChanged();
        }
        private void PickItem_DeleteClicked(object? sender, EventArgs e)
        {
            PickItem pickItem = (PickItem)sender!;
            _pickItems.Remove(pickItem);
            flpnl.Controls.Remove(pickItem);
            RaiseItemValueChanged();
        }

        internal List<PickItem> GetItems()
        {
            return _pickItems;
        }

        internal void Clear()
        {
            _pickItems.Clear();
            flpnl.Controls.Clear();
            RaiseItemValueChanged();
        }
    }
}
