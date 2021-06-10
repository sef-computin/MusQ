using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusQ_Player
{
    public class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }
 
        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(64,64,64);
            Rectangle rec = e.ClipRectangle;
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);
            e.Graphics.FillRectangle(Brushes.DimGray, 0, 0, rec.Width, rec.Height);
            e.Graphics.FillRectangle(Brushes.Crimson, 0, 0, rec.Width, 2);
        }
        
        
        // пока не готово
        /*
        public double SetProgressBarValue(Point MousePosition)
        {
            double ratio = MousePosition.X/Width;
            double progressBarValue = ratio*Maximum;
            Value = Convert.ToInt16(progressBarValue);
            return progressBarValue;
        }
        */
    }
}