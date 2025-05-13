using Kaburi.Utils;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Kaburi
{
    class RoundedPanel : Panel
    {
        private int _borderWidth = 2;
        private int _borderRadius = 8;
        private Color _borderColor = Color.Black;
        private Color _innerBackgroundColor = Color.White;

        public RoundedPanel()
        {
            Resize += RoundedPanel_Resize;
        }

        private void RoundedPanel_Resize(object? sender, EventArgs e)
        {
            Invalidate();
        }

        [DefaultValue(2), Category("커스텀"), Description("보더 두께를 변경합니다.")]
        public int BorderWidth
        { 
            get { return _borderWidth; }
            set {
                _borderWidth = value;
                Invalidate();
            } 
        }

        [DefaultValue(8), Category("커스텀"), Description("보더 둥글기를 변경합니다.")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Black"), Category("커스텀"), Description("보더 색상을 변경합니다.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "White"), Category("커스텀"), Description("보더 내부 색상을 변경합니다.")]
        public Color InnerBackgroundColor
        {
            get { return _innerBackgroundColor; }
            set { _innerBackgroundColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            // 패널 경계 계산
            Rectangle rect = new Rectangle(_borderWidth, _borderWidth, Width - _borderWidth * 2, Height - _borderWidth * 2);
            //graphics.DrawRectangle(new Pen(_borderColor, _borderWidth), rect);

            GraphicsPath path = GraphicsUtil.GetRoundedRectanglePath(rect, _borderRadius);

            // 내부 영역 채우기
            using (SolidBrush innerBrush = new SolidBrush(_innerBackgroundColor))
            {
                graphics.FillPath(innerBrush, path);
            }

            // 보더 그리기
            using (Pen borderPen = new Pen(_borderColor, _borderWidth))
            {
                graphics.DrawPath(borderPen, path);
            }
        }
    }
}
