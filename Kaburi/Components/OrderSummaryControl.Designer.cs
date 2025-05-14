namespace Kaburi.Components
{
    partial class OrderSummaryControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            roundedPanel1 = new RoundedPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lblCount = new Label();
            label3 = new Label();
            lblTotalPrice = new Label();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Controls.Add(tableLayoutPanel1);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(20);
            roundedPanel1.Size = new Size(342, 298);
            roundedPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCount, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTotalPrice, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(302, 258);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 129);
            label1.TabIndex = 0;
            label1.Text = "Count";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            lblCount.Dock = DockStyle.Fill;
            lblCount.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            lblCount.ForeColor = Color.DodgerBlue;
            lblCount.Location = new Point(154, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(145, 129);
            lblCount.TabIndex = 1;
            lblCount.Text = "lblCount";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(145, 129);
            label3.TabIndex = 2;
            label3.Text = "TotalPrice";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Dock = DockStyle.Fill;
            lblTotalPrice.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.DodgerBlue;
            lblTotalPrice.Location = new Point(154, 129);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(145, 129);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "lblTotalPrice";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OrderSummaryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel1);
            Name = "OrderSummaryControl";
            Size = new Size(342, 298);
            roundedPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblCount;
        private Label label3;
        private Label lblTotalPrice;
    }
}
