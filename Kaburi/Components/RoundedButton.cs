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
    [DefaultEvent("Click")]
    public partial class RoundedButton: UserControl
    {
        private Color _originalBackColor;
        public RoundedButton()
        {
            InitializeComponent();
            base.BackColor = Color.Transparent;
            lblText.MouseEnter += LblText_MouseEnter;
            lblText.MouseLeave += LblText_MouseLeave;
            lblText.Click += LblText_Click;
        }

        public new event EventHandler? Click;
        private void LblText_Click(object? sender, EventArgs e)
        {
            Click?.Invoke(this, e);
        }
        private void LblText_MouseLeave(object? sender, EventArgs e)
        {
            roundedPanel1.InnerBackgroundColor = _originalBackColor;
        }
        private void LblText_MouseEnter(object? sender, EventArgs e)
        {
            roundedPanel1.InnerBackgroundColor = Color.FromArgb((int)(255 * 0.9), _originalBackColor); ;
        }

        public Color BorderColor { get => roundedPanel1.BorderColor; set => roundedPanel1.BorderColor = value; }
        public int BorderWidth { get => roundedPanel1.BorderWidth; set => roundedPanel1.BorderWidth = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => lblText.Text; set => lblText.Text = value; }

        public new Color BackColor { 
            get => roundedPanel1.InnerBackgroundColor;
            set
            {
                _originalBackColor = value;
                roundedPanel1.InnerBackgroundColor = value;
            }
        }

        public new Font Font { get => lblText.Font; set => lblText.Font = value; }

        // ShouldSerialize 메서드: 속성 값이 기본값과 다를 때 직렬화
        private bool ShouldSerializeFont()
        {
            return lblText.Font != DefaultFont;
        }
    }
}
