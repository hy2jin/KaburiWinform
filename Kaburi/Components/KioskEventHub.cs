using Kaburi.Components.Picks;
using Kaburi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaburi.Components
{
    public partial class KioskEventHub: Component
    {
        private void CountDownTimer_CountdownEnded()
        {
            PickList.Clear();
        }

        private void CountDownTimer_Tick(int remainingSeconds)
        {
            Debug.Print(remainingSeconds.ToString());
        }

        private void PickList_ItemValueChanged(List<PickItem> pickItems)
        {
            // Timer 시작 혹은 중지
            if (pickItems.Any())
                CountDownTimer.Start();
            else
                CountDownTimer.Stop();

            // Summary
            int totalCount = pickItems.Sum(item => item.Count);
            decimal totalPrice = pickItems.Sum(item => item.Count * item.DefaultPrice);

            OrderSummaryControl.Count = totalCount;
            OrderSummaryControl.TotalPrice = totalPrice;
        }

        private void ProductList_ItemClicked(object? sender, Product e)
        {
            PickList.AddItem(e);
        }
        public KioskEventHub()
        {
            InitializeComponent();
        }

        public KioskEventHub(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            AddEvents();
        }

        private async void AddEvents()
        {
            await Task.Delay(1);

            ProductList.ItemClicked += ProductList_ItemClicked;
            PickList.ItemValueChanged += PickList_ItemValueChanged;
            CountDownTimer.Tick += CountDownTimer_Tick;
            CountDownTimer.CountdownEnded += CountDownTimer_CountdownEnded;
        }



        public Form ParentForm { get; set; } = default!;
        public ProductList ProductList { get; set; } = default!;
        public PickList PickList { get; set; } = default!;
        public IOrderSummaryControl OrderSummaryControl { get; set; } = default!;
        public CountDownTimer CountDownTimer { get; set; } = default!;
    }
}
