namespace Kaburi.Dialogs
{
    partial class ReceiptDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Font = new Font("돋움체", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txt.Location = new Point(12, 12);
            txt.Multiline = true;
            txt.Name = "txt";
            txt.Size = new Size(296, 382);
            txt.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 400);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(296, 38);
            btnOk.TabIndex = 1;
            btnOk.Text = "확인";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ReceiptDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(323, 450);
            Controls.Add(btnOk);
            Controls.Add(txt);
            Name = "ReceiptDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "영수증 상세내역";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private Button btnOk;
    }
}