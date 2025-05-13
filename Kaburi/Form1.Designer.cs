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
            Models.Product product1 = new Models.Product();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            headerControl1 = new Kaburi.Components.HeaderControl();
            productList1 = new Kaburi.Components.ProductList();
            SuspendLayout();
            // 
            // headerControl1
            // 
            headerControl1.Description = "저희 음식점은 국내산만 사용합니다.\r\n누구나 즐길 수 있는 합리적인 가격으로 모시겠습니다.";
            headerControl1.Dock = DockStyle.Top;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(1001, 150);
            headerControl1.TabIndex = 0;
            headerControl1.Title = "까불이 음식적에 오신 것을 환영합니다!";
            // 
            // productList1
            // 
            productList1.BackColor = Color.Transparent;
            product1.ID = 1;
            product1.Image = (Image)resources.GetObject("product1.Image");
            product1.Price = new decimal(new int[] { 2000, 0, 0, 0 });
            product1.Title = "사과";
            productList1.Items.Add(product1);
            productList1.Location = new Point(12, 118);
            productList1.Name = "productList1";
            productList1.Size = new Size(635, 414);
            productList1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 638);
            Controls.Add(productList1);
            Controls.Add(headerControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Components.HeaderControl headerControl1;
        private Components.ProductList productList1;
    }
}
