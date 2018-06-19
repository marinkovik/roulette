using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class RouletteBetScreen : Form
    {
        ChipsDoc chipsDoc;
        public int credits;
        public int bet;
        public int win;
        //current win from the wheel
        public int currentWin;
        private int timerCall;
        public int seconds;
        //Curent number of betChip
        public int currentBetNumber;

        public RouletteBetScreen()
        {
            currentBetNumber = 0;
            timerCall = 0;
            credits = 1000;
            bet = 0;
            win = 0;
            seconds = 20;

            chipsDoc = new ChipsDoc();

            ChipBet c = new ChipBet(new Point(400,615), 1);
            chipsDoc.AddChipBet(c);

            c = new ChipBet(new Point(500, 615), 5);
            chipsDoc.AddChipBet(c);

            c = new ChipBet(new Point(600, 615), 10);
            chipsDoc.AddChipBet(c);

            c = new ChipBet(new Point(700, 615), 50);
            chipsDoc.AddChipBet(c);

            InitializeComponent();
        }

        // Updating the numbers of currents bets and credits
        public void refresh()
        {
            label1.Text = credits.ToString();
            label2.Text = bet.ToString();
            label3.Text = currentWin.ToString();
            Invalidate(true);
        }

        public void resetGame()
        {
            timer1.Start();
            label5.Text = "Please, place your bets";
            currentBetNumber = chipsDoc.getChipBet();

            seconds = 20;
        }

        // Check if the player got credits for gambling
        public bool check()
        {
            if (credits >= currentBetNumber)
            {
                credits -= currentBetNumber;
                bet += currentBetNumber;
                refresh();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (check())
            {              
                chipsDoc.chipInsert(new Point(button37.Location.X + 20, button37.Location.Y + 20), currentBetNumber, 0);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button36.Location.X + 20, button36.Location.Y + 20), currentBetNumber, 36);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button35.Location.X + 20, button35.Location.Y + 20), currentBetNumber, 35);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button34.Location.X + 20, button34.Location.Y + 20), currentBetNumber, 34);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button33.Location.X + 20, button33.Location.Y + 20), currentBetNumber, 33);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button32.Location.X + 20, button32.Location.Y + 20), currentBetNumber, 32);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button31.Location.X + 20, button31.Location.Y + 20), currentBetNumber, 31);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button30.Location.X + 20, button30.Location.Y + 20), currentBetNumber, 30);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button29.Location.X + 20, button29.Location.Y + 20), currentBetNumber, 29);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button28.Location.X + 20, button28.Location.Y + 20), currentBetNumber, 28);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button27.Location.X + 20, button27.Location.Y + 20), currentBetNumber, 27);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button26.Location.X + 20, button26.Location.Y + 20), currentBetNumber, 26);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button25.Location.X + 20, button25.Location.Y + 20), currentBetNumber, 25);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button24.Location.X + 20, button24.Location.Y + 20), currentBetNumber, 24);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button23.Location.X + 20, button23.Location.Y + 20), currentBetNumber, 23);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button22.Location.X + 20, button22.Location.Y + 20), currentBetNumber, 22);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button21.Location.X + 20, button21.Location.Y + 20), currentBetNumber, 21);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button20.Location.X + 20, button20.Location.Y + 20), currentBetNumber, 20);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button19.Location.X + 20, button19.Location.Y + 20), currentBetNumber, 19);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button18.Location.X + 20, button18.Location.Y + 20), currentBetNumber, 18);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button17.Location.X + 20, button17.Location.Y + 20), currentBetNumber, 17);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button16.Location.X + 20, button16.Location.Y + 20), currentBetNumber, 16);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button15.Location.X + 20, button15.Location.Y + 20), currentBetNumber, 15);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button14.Location.X + 20, button14.Location.Y + 20), currentBetNumber, 14);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button13.Location.X + 20, button13.Location.Y + 20), currentBetNumber, 13);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button12.Location.X + 20, button12.Location.Y + 20), currentBetNumber, 12);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button11.Location.X + 20, button11.Location.Y + 20), currentBetNumber, 11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button10.Location.X + 20, button10.Location.Y + 20), currentBetNumber, 10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button9.Location.X + 20, button9.Location.Y + 20), currentBetNumber, 9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button8.Location.X + 20, button8.Location.Y + 20), currentBetNumber, 8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button7.Location.X + 20, button7.Location.Y + 20), currentBetNumber, 7);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button6.Location.X + 20, button6.Location.Y + 20), currentBetNumber, 6);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button5.Location.X + 20, button5.Location.Y + 20), currentBetNumber, 5);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button4.Location.X + 20, button4.Location.Y + 20), currentBetNumber, 4);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button3.Location.X + 20, button3.Location.Y + 20), currentBetNumber,3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button2.Location.X + 20, button2.Location.Y + 20), currentBetNumber,2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(button1.Location.X + 20, button1.Location.Y + 20), currentBetNumber,1);
        }

        private void RouletteBetScreen_Paint(object sender, PaintEventArgs e)
        {
            chipsDoc.Draw(e.Graphics);
        }

        private void RouletteBetScreen_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                chipsDoc.Select(e.Location);
                currentBetNumber = chipsDoc.getChipBet();
                Invalidate(true);
            }
        }


        //ZeroSpiel
        private void zeroSpiel_Click(object sender, EventArgs e)
        {
            if (credits >= currentBetNumber*7)
            {
                credits -= currentBetNumber*7;
                bet += currentBetNumber*7;
                refresh();
                chipsDoc.chipInsert(new Point(button12.Location.X + 20, button12.Location.Y + 20), currentBetNumber, 12);
                chipsDoc.chipInsert(new Point(button35.Location.X + 20, button35.Location.Y + 20), currentBetNumber, 35);
                chipsDoc.chipInsert(new Point(button3.Location.X + 20, button3.Location.Y + 20), currentBetNumber, 3);
                chipsDoc.chipInsert(new Point(button26.Location.X + 20, button26.Location.Y + 20), currentBetNumber, 26);
                chipsDoc.chipInsert(new Point(button37.Location.X + 20, button37.Location.Y + 20), currentBetNumber, 0);
                chipsDoc.chipInsert(new Point(button32.Location.X + 20, button32.Location.Y + 20), currentBetNumber, 32);
                chipsDoc.chipInsert(new Point(button15.Location.X + 20, button15.Location.Y + 20), currentBetNumber, 15);
                Invalidate(true);
            }
        }

        private void orphans_Click(object sender, EventArgs e)
        {
            if (credits >= currentBetNumber*8)
            {
                credits -= currentBetNumber*8;
                bet += currentBetNumber*8;
                refresh();
                chipsDoc.chipInsert(new Point(button9.Location.X + 20, button9.Location.Y + 20), currentBetNumber, 9);
                chipsDoc.chipInsert(new Point(button31.Location.X + 20, button31.Location.Y + 20), currentBetNumber, 31);
                chipsDoc.chipInsert(new Point(button14.Location.X + 20, button14.Location.Y + 20), currentBetNumber, 14);
                chipsDoc.chipInsert(new Point(button20.Location.X + 20, button20.Location.Y + 20), currentBetNumber, 20);
                chipsDoc.chipInsert(new Point(button1.Location.X + 20, button1.Location.Y + 20), currentBetNumber, 1);
                chipsDoc.chipInsert(new Point(button17.Location.X + 20, button17.Location.Y + 20), currentBetNumber, 17);
                chipsDoc.chipInsert(new Point(button34.Location.X + 20, button34.Location.Y + 20), currentBetNumber, 34);
                chipsDoc.chipInsert(new Point(button6.Location.X + 20, button6.Location.Y + 20), currentBetNumber, 6);
                Invalidate(true);
            }
        }

        private void bigSeries_Click(object sender, EventArgs e)
        {
            if (credits >= currentBetNumber*17)
            {
                credits -= currentBetNumber*17;
                bet += currentBetNumber*17;
                refresh();
                chipsDoc.chipInsert(new Point(button12.Location.X + 20, button12.Location.Y + 20), currentBetNumber, 12);
                chipsDoc.chipInsert(new Point(button35.Location.X + 20, button35.Location.Y + 20), currentBetNumber, 35);
                chipsDoc.chipInsert(new Point(button3.Location.X + 20, button3.Location.Y + 20), currentBetNumber, 3);
                chipsDoc.chipInsert(new Point(button26.Location.X + 20, button26.Location.Y + 20), currentBetNumber, 26);
                chipsDoc.chipInsert(new Point(button37.Location.X + 20, button37.Location.Y + 20), currentBetNumber, 0);
                chipsDoc.chipInsert(new Point(button32.Location.X + 20, button32.Location.Y + 20), currentBetNumber, 32);
                chipsDoc.chipInsert(new Point(button15.Location.X + 20, button15.Location.Y + 20), currentBetNumber, 15);
                chipsDoc.chipInsert(new Point(button22.Location.X + 20, button22.Location.Y + 20), currentBetNumber, 22);
                chipsDoc.chipInsert(new Point(button18.Location.X + 20, button18.Location.Y + 20), currentBetNumber, 18);
                chipsDoc.chipInsert(new Point(button29.Location.X + 20, button29.Location.Y + 20), currentBetNumber, 29);
                chipsDoc.chipInsert(new Point(button7.Location.X + 20, button7.Location.Y + 20), currentBetNumber, 7);
                chipsDoc.chipInsert(new Point(button28.Location.X + 20, button28.Location.Y + 20), currentBetNumber, 28);
                chipsDoc.chipInsert(new Point(button19.Location.X + 20, button19.Location.Y + 20), currentBetNumber, 19);
                chipsDoc.chipInsert(new Point(button4.Location.X + 20, button4.Location.Y + 20), currentBetNumber, 4);
                chipsDoc.chipInsert(new Point(button21.Location.X + 20, button21.Location.Y + 20), currentBetNumber, 21);
                chipsDoc.chipInsert(new Point(button2.Location.X + 20, button2.Location.Y + 20), currentBetNumber, 2);
                chipsDoc.chipInsert(new Point(button25.Location.X + 20, button25.Location.Y + 20), currentBetNumber, 25);
                Invalidate(true);
            }
        }

        private void smallSeries_Click(object sender, EventArgs e)
        {
            if (credits >= currentBetNumber*13)
            {
                credits -= currentBetNumber*13;
                bet += currentBetNumber*13;
                refresh();
                chipsDoc.chipInsert(new Point(button33.Location.X + 20, button33.Location.Y + 20), currentBetNumber, 33);
                chipsDoc.chipInsert(new Point(button16.Location.X + 20, button16.Location.Y + 20), currentBetNumber, 16);
                chipsDoc.chipInsert(new Point(button24.Location.X + 20, button24.Location.Y + 20), currentBetNumber, 24);
                chipsDoc.chipInsert(new Point(button5.Location.X + 20, button5.Location.Y + 20), currentBetNumber, 5);
                chipsDoc.chipInsert(new Point(button10.Location.X + 20, button10.Location.Y + 20), currentBetNumber, 10);
                chipsDoc.chipInsert(new Point(button23.Location.X + 20, button23.Location.Y + 20), currentBetNumber, 23);
                chipsDoc.chipInsert(new Point(button8.Location.X + 20, button8.Location.Y + 20), currentBetNumber, 8);
                chipsDoc.chipInsert(new Point(button30.Location.X + 20, button30.Location.Y + 20), currentBetNumber, 30);
                chipsDoc.chipInsert(new Point(button11.Location.X + 20, button11.Location.Y + 20), currentBetNumber, 11);
                chipsDoc.chipInsert(new Point(button36.Location.X + 20, button36.Location.Y + 20), currentBetNumber, 36);
                chipsDoc.chipInsert(new Point(button13.Location.X + 20, button13.Location.Y + 20), currentBetNumber, 13);
                chipsDoc.chipInsert(new Point(button27.Location.X + 20, button27.Location.Y + 20), currentBetNumber, 27);
                Invalidate(true);
            }
        }

        // Field 1-12
        private void onetotwelve_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(onetotwelve.Location.X + 90, onetotwelve.Location.Y + 30), currentBetNumber,37);
        }

        // Field 13-24
        private void thirteentotwentyfour_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(thirteentotwentyfour.Location.X + 110, thirteentotwentyfour.Location.Y + 30), currentBetNumber,38);
            
        }

        // Field 24-36
        private void twentyfivetothirtysix_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(twentyfivetothirtysix.Location.X + 90, twentyfivetothirtysix.Location.Y + 30), currentBetNumber,39);
            
        }

        // Field 1-18
        private void onetoeighteen_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(onetoeighteen.Location.X + 50, onetoeighteen.Location.Y + 20), currentBetNumber, 40);
        }

        // Field 19-36
        private void nineteentothirtysix_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(nineteentothirtysix.Location.X + 50, nineteentothirtysix.Location.Y + 20), currentBetNumber, 41);
        }

        // Field Even
        private void even_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(even.Location.X + 50, even.Location.Y + 20), currentBetNumber, 42);
        }

        // Field Odd
        private void odd_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(odd.Location.X + 50, odd.Location.Y + 20), currentBetNumber, 43);
        }

        // Field red
        private void redBtn_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(redBtn.Location.X + 50, redBtn.Location.Y + 20), currentBetNumber, 44);
        }

        // Field black
        private void blackBtn_Click(object sender, EventArgs e)
        {
            if (check())
                chipsDoc.chipInsert(new Point(blackBtn.Location.X + 55, blackBtn.Location.Y + 20), currentBetNumber, 45);
        }

        // Button for opening insert credits form
        private void button38_Click(object sender, EventArgs e)
        {
            InsertCreditsForm form = new InsertCreditsForm();
            form.rouletteBetScreen = this;
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                credits += form.credits;
                label1.Text = credits.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerCall%10 == 0)
            {
                seconds--;
                label4.Text = seconds.ToString() + " seconds";
                if (seconds < 1)
                {
                    label5.Text = "The betting is over. Good luck";
                    timer1.Stop();
                    SpinningWheel form = new SpinningWheel();
                    form.rouletteBetScreen = this;
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        label6.Text = "The latest number was " + form.currentNumber.ToString();
                        currentBetNumber = form.currentNumber;
                        checkTheResults();
                    }
                }
            }
            timerCall++;
        }

        public void checkTheResults()
        {
            currentWin = chipsDoc.checkTheResults(currentBetNumber);
            credits += currentWin;
            bet = 0;
            chipsDoc.Clear();
            refresh();
            resetGame();
        }
    }
}
