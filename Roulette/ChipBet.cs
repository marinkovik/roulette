using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    [Serializable]
    public class ChipBet
    {
        public int RADIUS = 25;
        public int Digit { get; set; }
        public bool isSelected { get; set; }

        public Point Center { get; set; }

        public ChipBet(Point center, int digit)
        {
            Digit = digit;
            Center = center;
            isSelected = false;

        }

        public void Draw(Graphics g)
        {
            if (isSelected)
            {
                RADIUS = 35;
                g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                Font f = new Font("Arial", 15);
                g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 12, Center.Y - 10);
                f.Dispose();
            }
            else
            {
                RADIUS = 25;
                g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                Font f = new Font("Arial", 15);
                g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 12, Center.Y - 10);
                f.Dispose();
            }

        }

        public void Select(Point point)
        {
            if (Distance(point, Center) <= RADIUS * RADIUS)
            {
                isSelected = true;
            }
        }

        public static float Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        public int getChipBet()
        {
            if (isSelected)
            {
                return Digit;
            }
            else
              return 0;
        }
    }
}
