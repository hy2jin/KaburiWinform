﻿namespace Kaburi.Components
{
    partial class RoundedButton
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
            lblText = new Label();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Controls.Add(lblText);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(98, 44);
            roundedPanel1.TabIndex = 0;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Cursor = Cursors.Hand;
            lblText.Dock = DockStyle.Fill;
            lblText.Location = new Point(0, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(98, 44);
            lblText.TabIndex = 0;
            lblText.Text = "lblText";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoundedButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel1);
            Name = "RoundedButton";
            Size = new Size(98, 44);
            roundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label lblText;
    }
}
