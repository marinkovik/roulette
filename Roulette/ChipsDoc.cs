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
        public int currentBetNumber;
        public int[] firstTime;

        public ChipsDoc()
        {
            firstTime = new int[37];
            for (int i = 0; i<37; i++)
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

        public void insert0(Point center, long digit)
        {
            if(firstTime[0] == 0)
            {
                Chip c = new Chip(center, digit, 0);
                AddChip(c);
                firstTime[0] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if(c.NumberBet == 0)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert1(Point center, long digit)
        {
            if (firstTime[1] == 0)
            {
                Chip c = new Chip(center, digit, 1);
                AddChip(c);
                firstTime[1] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 1)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert2(Point center, long digit)
        {
            if (firstTime[2] == 0)
            {
                Chip c = new Chip(center, digit, 2);
                AddChip(c);
                firstTime[2] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 2)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert3(Point center, long digit)
        {
            if (firstTime[3] == 0)
            {
                Chip c = new Chip(center, digit, 3);
                AddChip(c);
                firstTime[3] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 3)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert4(Point center, long digit)
        {
            if (firstTime[4] == 0)
            {
                Chip c = new Chip(center, digit, 4);
                AddChip(c);
                firstTime[4] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 4)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert5(Point center, long digit)
        {
            if (firstTime[5] == 0)
            {
                Chip c = new Chip(center, digit, 5);
                AddChip(c);
                firstTime[5] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 5)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert6(Point center, long digit)
        {
            if (firstTime[6] == 0)
            {
                Chip c = new Chip(center, digit, 6);
                AddChip(c);
                firstTime[6] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 6)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert7(Point center, long digit)
        {
            if (firstTime[7] == 0)
            {
                Chip c = new Chip(center, digit, 7);
                AddChip(c);
                firstTime[7] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 7)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }


        public void insert8(Point center, long digit)
        {
            if (firstTime[8] == 0)
            {
                Chip c = new Chip(center, digit, 8);
                AddChip(c);
                firstTime[8] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 8)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }


        public void insert9(Point center, long digit)
        {
            if (firstTime[9] == 0)
            {
                Chip c = new Chip(center, digit, 9);
                AddChip(c);
                firstTime[9] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 9)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert10(Point center, long digit)
        {
            if (firstTime[10] == 0)
            {
                Chip c = new Chip(center, digit, 10);
                AddChip(c);
                firstTime[10] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 10)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert11(Point center, long digit)
        {
            if (firstTime[11] == 0)
            {
                Chip c = new Chip(center, digit, 11);
                AddChip(c);
                firstTime[11] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 11)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert12(Point center, long digit)
        {
            if (firstTime[12] == 0)
            {
                Chip c = new Chip(center, digit, 12);
                AddChip(c);
                firstTime[12] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 12)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert13(Point center, long digit)
        {
            if (firstTime[13] == 0)
            {
                Chip c = new Chip(center, digit, 13);
                AddChip(c);
                firstTime[13] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 13)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert14(Point center, long digit)
        {
            if (firstTime[14] == 0)
            {
                Chip c = new Chip(center, digit, 14);
                AddChip(c);
                firstTime[14] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 14)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert15(Point center, long digit)
        {
            if (firstTime[15] == 0)
            {
                Chip c = new Chip(center, digit, 15);
                AddChip(c);
                firstTime[15] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 15)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert16(Point center, long digit)
        {
            if (firstTime[16] == 0)
            {
                Chip c = new Chip(center, digit, 16);
                AddChip(c);
                firstTime[16] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 16)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert17(Point center, long digit)
        {
            if (firstTime[17] == 0)
            {
                Chip c = new Chip(center, digit, 17);
                AddChip(c);
                firstTime[17] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 17)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert18(Point center, long digit)
        {
            if (firstTime[18] == 0)
            {
                Chip c = new Chip(center, digit, 18);
                AddChip(c);
                firstTime[18] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 18)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert19(Point center, long digit)
        {
            if (firstTime[19] == 0)
            {
                Chip c = new Chip(center, digit, 19);
                AddChip(c);
                firstTime[19] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 19)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert20(Point center, long digit)
        {
            if (firstTime[20] == 0)
            {
                Chip c = new Chip(center, digit, 20);
                AddChip(c);
                firstTime[20] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 20)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert21(Point center, long digit)
        {
            if (firstTime[21] == 0)
            {
                Chip c = new Chip(center, digit, 21);
                AddChip(c);
                firstTime[21] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 21)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert22(Point center, long digit)
        {
            if (firstTime[22] == 0)
            {
                Chip c = new Chip(center, digit, 22);
                AddChip(c);
                firstTime[22] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 22)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert23(Point center, long digit)
        {
            if (firstTime[23] == 0)
            {
                Chip c = new Chip(center, digit, 23);
                AddChip(c);
                firstTime[23] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 23)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert24(Point center, long digit)
        {
            if (firstTime[24] == 0)
            {
                Chip c = new Chip(center, digit, 24);
                AddChip(c);
                firstTime[24] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 24)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert25(Point center, long digit)
        {
            if (firstTime[25] == 0)
            {
                Chip c = new Chip(center, digit, 25);
                AddChip(c);
                firstTime[25] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 25)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert26(Point center, long digit)
        {
            if (firstTime[26] == 0)
            {
                Chip c = new Chip(center, digit, 26);
                AddChip(c);
                firstTime[26] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 26)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert27(Point center, long digit)
        {
            if (firstTime[27] == 0)
            {
                Chip c = new Chip(center, digit, 27);
                AddChip(c);
                firstTime[27] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 27)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert28(Point center, long digit)
        {
            if (firstTime[28] == 0)
            {
                Chip c = new Chip(center, digit, 28);
                AddChip(c);
                firstTime[28] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 28)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert29(Point center, long digit)
        {
            if (firstTime[29] == 0)
            {
                Chip c = new Chip(center, digit, 29);
                AddChip(c);
                firstTime[29] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 29)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert30(Point center, long digit)
        {
            if (firstTime[30] == 0)
            {
                Chip c = new Chip(center, digit, 30);
                AddChip(c);
                firstTime[30] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 30)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert31(Point center, long digit)
        {
            if (firstTime[31] == 0)
            {
                Chip c = new Chip(center, digit, 31);
                AddChip(c);
                firstTime[31] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 31)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert32(Point center, long digit)
        {
            if (firstTime[32] == 0)
            {
                Chip c = new Chip(center, digit, 32);
                AddChip(c);
                firstTime[32] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 32)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert33(Point center, long digit)
        {
            if (firstTime[33] == 0)
            {
                Chip c = new Chip(center, digit, 33);
                AddChip(c);
                firstTime[33] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 33)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert34(Point center, long digit)
        {
            if (firstTime[34] == 0)
            {
                Chip c = new Chip(center, digit, 34);
                AddChip(c);
                firstTime[34] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 34)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert35(Point center, long digit)
        {
            if (firstTime[35] == 0)
            {
                Chip c = new Chip(center, digit, 35);
                AddChip(c);
                firstTime[35] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 35)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }

        public void insert36(Point center, long digit)
        {
            if (firstTime[36] == 0)
            {
                Chip c = new Chip(center, digit, 36);
                AddChip(c);
                firstTime[36] = 1;
            }
            else
            {
                foreach (Chip c in Chips)
                {
                    if (c.NumberBet == 36)
                    {
                        c.Digit += digit;
                        break;
                    }
                }
            }
        }
    }
}
