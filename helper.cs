using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MilkyUi
{
    public static class helper
    {
        public static void Edgesmoothing(this Graphics g)
        {
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }

    }
}
