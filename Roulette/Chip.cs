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
        public static int RADIUS = 17;
        public long Digit { get; set; }

        public Point Center { get; set; }

        public Chip(Point center, long digit)
        {
            Digit = digit;
            Center = center;
            
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
          
            Font f = new Font("Arial", 10);
            g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 5, Center.Y - 5);
            f.Dispose();
        }
    }
}
