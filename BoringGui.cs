/*
Boring Gui created by Jerimiah
https://github.com/JerimiahOfficial/BoringGui
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoringGui
{
    public class BButton : Button
    {
        public BButton()
        {
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw Border using color specified in Flat Appearance
            Pen pen = new Pen(FlatAppearance.BorderColor, 1);
            Rectangle rectangle = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            e.Graphics.DrawRectangle(pen, rectangle);
            e.Graphics.DrawRectangle(new Pen(this.BackColor, 5), this.ClientRectangle);
        }
    }
    
    public class BSlider : TrackBar
    {
        
    }
}