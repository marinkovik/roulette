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
        public List<ChipBet> ChipsBet { get; set; }
        public int currentWin;
        public int currentBetNumber;
        public int[] firstTime;

        public ChipsDoc()
        {
            currentWin = 0;
            firstTime = new int[46];
            for (int i = 0; i<46; i++)
            {
                firstTime[i] = 0;
            }
            currentBetNumber = 0;
            Chips = new List<Chip>();
            ChipsBet = new List<ChipBet>();
        }

        //Adding the chips
        public void AddChip(Chip c)
        {
            Chips.Add(c);
        }

        //Adding the BettingChips // 1, 5, 10, 50
        public void AddChipBet(ChipBet c)
        {
            ChipsBet.Add(c);
        }

        //Drawing the chips 
        public void Draw(Graphics g)
        {
            foreach(Chip c in Chips)
            {
                c.Draw(g);
            }

            foreach (ChipBet b in ChipsBet)
            {
                b.Draw(g);
            }
        }

        // Checking for selected ChipBet
        public void Select(Point p)
        {
            foreach (ChipBet c in ChipsBet)
            {
                c.isSelected = false;
            }

            foreach (ChipBet c in ChipsBet)
            {
                c.Select(p);
            }

        }

        public int getChipBet()
        {
            foreach (ChipBet c in ChipsBet)
            {
                if(c.isSelected == true)
                {
                    currentBetNumber = c.Digit;
                    break;
                }
                else
                {
                    currentBetNumber = 0;
                }
            }
            return currentBetNumber;
        }

        // Inserting chip example
        public void chipInsert(Point center, long digit, int number)
        {
            if (firstTime[number] == 0)
            {
                Chip c = new Chip(center, digit, number);
                AddChip(c);
                firstTime[number] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == number)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void Clear()
        {
            foreach (Chip c in Chips)
            {
                c.Digit = 0;
            }
        }

        // Checking if the player win something
        public int checkTheResults(int currentBetNumberFromWheel)
        {
            currentBetNumber = currentBetNumberFromWheel;
            currentWin = 0;
            if (currentBetNumber <= 12)
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 37)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 3);
                        break;
                    }
                }
            }

            if ((currentBetNumber > 12) && (currentBetNumber <= 24))
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 38)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 3);
                        break;
                    }
                }
            }

            if ((currentBetNumber > 24) && (currentBetNumber <= 36))
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 39)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 3);
                        break;
                    }
                }
            }

            // From 1-18
            if (currentBetNumber <= 18)
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 40)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 2);
                        break;
                    }
                }
            }

            // From 19-36
            if (currentBetNumber > 18)
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 41)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 2);
                        break;
                    }
                }
            }

            // even
            if (currentBetNumber % 2 == 0)
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 42)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 2);
                        break;
                    }
                }
            }

            //Odd
            if (currentBetNumber % 2 == 1)
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 43)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 2);
                        break;
                    }
                }
            }

            // Missing for red and black

            // For the number 
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == currentBetNumber)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 36);
                        break;
                    }
                }

            return currentWin;
        }
    }
}
