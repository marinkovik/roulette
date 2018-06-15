using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Chip
    {
        public static int RADIUS = 30;
        public long Digit { get; set; }

        public Point Center { get; set; }

        public Chip(int width,int height, long digit)
        {
            Digit = digit;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
          
            Font f = new Font("Arial", 24);
            g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 15, Center.Y - 15);
            f.Dispose();
        }
    }
}
