namespace Kaburi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Models.Product product6 = new Models.Product();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Models.Product product7 = new Models.Product();
            Models.Product product8 = new Models.Product();
            Models.Product product9 = new Models.Product();
            Models.Product product10 = new Models.Product();
            headerControl1 = new Kaburi.Components.HeaderControl();
            productList1 = new Kaburi.Components.ProductList();
            pickList = new Kaburi.Components.Picks.PickList();
            orderSummaryControl1 = new Kaburi.Components.OrderSummaryControl();
            btnPay = new Kaburi.Components.RoundedButton();
            btnCancel = new Kaburi.Components.RoundedButton();
            SuspendLayout();
            // 
            // headerControl1
            // 
            headerControl1.Description = "저희 음식점은 국내산만 사용합니다.\r\n누구나 즐길 수 있는 합리적인 가격으로 모시겠습니다.";
            headerControl1.Dock = DockStyle.Top;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(892, 112);
            headerControl1.TabIndex = 0;
            headerControl1.Title = "까불이 음식점에 오신 것을 환영합니다!";
            // 
            // productList1
            // 
            productList1.BackColor = Color.Transparent;
            productList1.BorderColor = Color.Silver;
            productList1.BorderWidth = 1;
            product6.ID = 1;
            product6.Image = (Image)resources.GetObject("product6.Image");
            product6.Price = new decimal(new int[] { 2000, 0, 0, 0 });
            product6.Title = "사과";
            product7.ID = 2;
            product7.Image = (Image)resources.GetObject("product7.Image");
            product7.Price = new decimal(new int[] { 19000, 0, 0, 0 });
            product7.Title = "치킨";
            product8.ID = 3;
            product8.Image = (Image)resources.GetObject("product8.Image");
            product8.Price = new decimal(new int[] { 3000, 0, 0, 0 });
            product8.Title = "쿠키";
            product9.ID = 4;
            product9.Image = (Image)resources.GetObject("product9.Image");
            product9.Price = new decimal(new int[] { 4500, 0, 0, 0 });
            product9.Title = "햄버거";
            product10.ID = 5;
            product10.Image = (Image)resources.GetObject("product10.Image");
            product10.Price = new decimal(new int[] { 990, 0, 0, 0 });
            product10.Title = "아이스크림";
            productList1.Items.Add(product6);
            productList1.Items.Add(product7);
            productList1.Items.Add(product8);
            productList1.Items.Add(product9);
            productList1.Items.Add(product10);
            productList1.Location = new Point(12, 118);
            productList1.Name = "productList1";
            productList1.Size = new Size(868, 355);
            productList1.TabIndex = 2;
            productList1.ItemClicked += productList1_ItemClicked;
            // 
            // pickList
            // 
            pickList.BorderColor = Color.Salmon;
            pickList.BorderWidth = 1;
            pickList.Location = new Point(12, 479);
            pickList.Name = "pickList";
            pickList.Size = new Size(569, 284);
            pickList.TabIndex = 3;
            pickList.ItemValueChanged += pickList_ItemValueChanged;
            // 
            // orderSummaryControl1
            // 
            orderSummaryControl1.BorderColor = Color.DodgerBlue;
            orderSummaryControl1.BorderWidth = 1;
            orderSummaryControl1.Count = 0;
            orderSummaryControl1.Location = new Point(587, 479);
            orderSummaryControl1.Name = "orderSummaryControl1";
            orderSummaryControl1.Size = new Size(293, 205);
            orderSummaryControl1.TabIndex = 4;
            orderSummaryControl1.TotalPrice = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.DodgerBlue;
            btnPay.BorderColor = Color.DodgerBlue;
            btnPay.BorderWidth = 2;
            btnPay.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(739, 690);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(141, 73);
            btnPay.TabIndex = 5;
            btnPay.Text = "결제하기";
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Salmon;
            btnCancel.BorderColor = Color.Salmon;
            btnCancel.BorderWidth = 2;
            btnCancel.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(587, 690);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 73);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "취소하기";
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 775);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(orderSummaryControl1);
            Controls.Add(pickList);
            Controls.Add(productList1);
            Controls.Add(headerControl1);
            Name = "Form1";
            Text = "까불이네 키오스크";
            ResumeLayout(false);
        }

        #endregion

        private Components.HeaderControl headerControl1;
        private Components.ProductList productList1;
        private Components.Picks.PickList pickList;
        private Components.OrderSummaryControl orderSummaryControl1;
        private Components.RoundedButton btnPay;
        private Components.RoundedButton btnCancel;
    }
}
