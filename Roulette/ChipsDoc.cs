using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    [Serializable]
    public class ChipsDoc
    {
        public List<Chip> Chips { get; set; }

        public ChipsDoc()
        {
            Chips = new List<Chip>();
        }

        //Adding the chips
        public void AddChip(int width, int height, int number)
        {
            Chip c = new Chip(width, height, number);
            Chips.Add(c);
        }

        //Drawing the chips 
        public void Draw(Graphics g)
        {
            foreach(Chip c in Chips)
            {
                c.Draw(g);
            }
        }



    }
}
