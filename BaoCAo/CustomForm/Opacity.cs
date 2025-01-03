using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaoCAo.CustomForm
{
    public class TransparentPanel : Panel
    {
        private int opacity = 100; // Độ mờ mặc định (từ 0 đến 100)

        public int Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
                Invalidate(); // Yêu cầu vẽ lại panel với độ mờ mới
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vẽ lại panel với alpha blending
            using (Brush brush = new SolidBrush(Color.FromArgb((opacity * 255) / 100, BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
