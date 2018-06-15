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
        //Curent number of betChip
        public int currentBetNumber;

        public RouletteBetScreen()
        {
            currentBetNumber = 0;
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

        private void button37_Click(object sender, EventArgs e)
        {
            chipsDoc.insert0(new Point(button37.Location.X + 20, button37.Location.Y + 20), currentBetNumber);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            chipsDoc.insert36(new Point(button36.Location.X + 20, button36.Location.Y + 20), currentBetNumber);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            chipsDoc.insert35(new Point(button35.Location.X + 20, button35.Location.Y + 20), currentBetNumber);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            chipsDoc.insert34(new Point(button34.Location.X + 20, button34.Location.Y + 20), currentBetNumber);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            chipsDoc.insert33(new Point(button33.Location.X + 20, button33.Location.Y + 20), currentBetNumber);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            chipsDoc.insert32(new Point(button32.Location.X + 20, button32.Location.Y + 20), currentBetNumber);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            chipsDoc.insert31(new Point(button31.Location.X + 20, button31.Location.Y + 20), currentBetNumber);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            chipsDoc.insert30(new Point(button30.Location.X + 20, button30.Location.Y + 20), currentBetNumber);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            chipsDoc.insert29(new Point(button29.Location.X + 20, button29.Location.Y + 20), currentBetNumber);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            chipsDoc.insert28(new Point(button28.Location.X + 20, button28.Location.Y + 20), currentBetNumber);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            chipsDoc.insert27(new Point(button27.Location.X + 20, button27.Location.Y + 20), currentBetNumber);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            chipsDoc.insert26(new Point(button26.Location.X + 20, button26.Location.Y + 20), currentBetNumber);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            chipsDoc.insert25(new Point(button25.Location.X + 20, button25.Location.Y + 20), currentBetNumber);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            chipsDoc.insert24(new Point(button24.Location.X + 20, button24.Location.Y + 20), currentBetNumber);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            chipsDoc.insert23(new Point(button23.Location.X + 20, button23.Location.Y + 20), currentBetNumber);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            chipsDoc.insert22(new Point(button22.Location.X + 20, button22.Location.Y + 20), currentBetNumber);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            chipsDoc.insert21(new Point(button21.Location.X + 20, button21.Location.Y + 20), currentBetNumber);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            chipsDoc.insert20(new Point(button20.Location.X + 20, button20.Location.Y + 20), currentBetNumber);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            chipsDoc.insert19(new Point(button19.Location.X + 20, button19.Location.Y + 20), currentBetNumber);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            chipsDoc.insert18(new Point(button18.Location.X + 20, button18.Location.Y + 20), currentBetNumber);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            chipsDoc.insert17(new Point(button17.Location.X + 20, button17.Location.Y + 20), currentBetNumber);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            chipsDoc.insert16(new Point(button16.Location.X + 20, button16.Location.Y + 20), currentBetNumber);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            chipsDoc.insert15(new Point(button15.Location.X + 20, button15.Location.Y + 20), currentBetNumber);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            chipsDoc.insert14(new Point(button14.Location.X + 20, button14.Location.Y + 20), currentBetNumber);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chipsDoc.insert13(new Point(button13.Location.X + 20, button13.Location.Y + 20), currentBetNumber);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chipsDoc.insert12(new Point(button12.Location.X + 20, button12.Location.Y + 20), currentBetNumber);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chipsDoc.insert11(new Point(button11.Location.X + 20, button11.Location.Y + 20), currentBetNumber);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chipsDoc.insert10(new Point(button10.Location.X + 20, button10.Location.Y + 20), currentBetNumber);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chipsDoc.insert9(new Point(button9.Location.X + 20, button9.Location.Y + 20), currentBetNumber);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chipsDoc.insert8(new Point(button8.Location.X + 20, button8.Location.Y + 20), currentBetNumber);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chipsDoc.insert7(new Point(button7.Location.X + 20, button7.Location.Y + 20), currentBetNumber);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chipsDoc.insert6(new Point(button6.Location.X + 20, button6.Location.Y + 20), currentBetNumber);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chipsDoc.insert5(new Point(button5.Location.X + 20, button5.Location.Y + 20), currentBetNumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chipsDoc.insert4(new Point(button4.Location.X + 20, button4.Location.Y + 20), currentBetNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chipsDoc.insert3(new Point(button3.Location.X + 20, button3.Location.Y + 20), currentBetNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chipsDoc.insert2(new Point(button2.Location.X + 20, button2.Location.Y + 20), currentBetNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chipsDoc.insert1(new Point(button1.Location.X + 20, button1.Location.Y + 20), currentBetNumber);
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
            chipsDoc.insert12(new Point(button12.Location.X + 20, button12.Location.Y + 20), currentBetNumber);
            chipsDoc.insert35(new Point(button35.Location.X + 20, button35.Location.Y + 20), currentBetNumber);
            chipsDoc.insert3(new Point(button3.Location.X + 20, button3.Location.Y + 20), currentBetNumber);
            chipsDoc.insert26(new Point(button26.Location.X + 20, button26.Location.Y + 20), currentBetNumber);
            chipsDoc.insert0(new Point(button37.Location.X + 20, button37.Location.Y + 20), currentBetNumber);
            chipsDoc.insert32(new Point(button32.Location.X + 20, button32.Location.Y + 20), currentBetNumber);
            chipsDoc.insert15(new Point(button15.Location.X + 20, button15.Location.Y + 20), currentBetNumber);
            Invalidate(true);
        }

        private void orphans_Click(object sender, EventArgs e)
        {
            chipsDoc.insert9(new Point(button9.Location.X + 20, button9.Location.Y + 20), currentBetNumber);
            chipsDoc.insert31(new Point(button31.Location.X + 20, button31.Location.Y + 20), currentBetNumber);
            chipsDoc.insert14(new Point(button14.Location.X + 20, button14.Location.Y + 20), currentBetNumber);
            chipsDoc.insert20(new Point(button20.Location.X + 20, button20.Location.Y + 20), currentBetNumber);
            chipsDoc.insert1(new Point(button1.Location.X + 20, button1.Location.Y + 20), currentBetNumber);
            chipsDoc.insert17(new Point(button17.Location.X + 20, button17.Location.Y + 20), currentBetNumber);
            chipsDoc.insert34(new Point(button34.Location.X + 20, button34.Location.Y + 20), currentBetNumber);
            chipsDoc.insert6(new Point(button6.Location.X + 20, button6.Location.Y + 20), currentBetNumber);
            Invalidate(true);
        }

        private void bigSeries_Click(object sender, EventArgs e)
        {
            chipsDoc.insert12(new Point(button12.Location.X + 20, button12.Location.Y + 20), currentBetNumber);
            chipsDoc.insert35(new Point(button35.Location.X + 20, button35.Location.Y + 20), currentBetNumber);
            chipsDoc.insert3(new Point(button3.Location.X + 20, button3.Location.Y + 20), currentBetNumber);
            chipsDoc.insert26(new Point(button26.Location.X + 20, button26.Location.Y + 20), currentBetNumber);
            chipsDoc.insert0(new Point(button37.Location.X + 20, button37.Location.Y + 20), currentBetNumber);
            chipsDoc.insert32(new Point(button32.Location.X + 20, button32.Location.Y + 20), currentBetNumber);
            chipsDoc.insert15(new Point(button15.Location.X + 20, button15.Location.Y + 20), currentBetNumber);
            chipsDoc.insert22(new Point(button22.Location.X + 20, button22.Location.Y + 20), currentBetNumber);
            chipsDoc.insert18(new Point(button18.Location.X + 20, button18.Location.Y + 20), currentBetNumber);
            chipsDoc.insert29(new Point(button29.Location.X + 20, button29.Location.Y + 20), currentBetNumber);
            chipsDoc.insert7(new Point(button7.Location.X + 20, button7.Location.Y + 20), currentBetNumber);
            chipsDoc.insert28(new Point(button28.Location.X + 20, button28.Location.Y + 20), currentBetNumber);
            chipsDoc.insert19(new Point(button19.Location.X + 20, button19.Location.Y + 20), currentBetNumber);
            chipsDoc.insert4(new Point(button4.Location.X + 20, button4.Location.Y + 20), currentBetNumber);
            chipsDoc.insert21(new Point(button21.Location.X + 20, button21.Location.Y + 20), currentBetNumber);
            chipsDoc.insert2(new Point(button2.Location.X + 20, button2.Location.Y + 20), currentBetNumber);
            chipsDoc.insert25(new Point(button25.Location.X + 20, button25.Location.Y + 20), currentBetNumber);
            Invalidate(true);
        }

        private void smallSeries_Click(object sender, EventArgs e)
        {
            chipsDoc.insert33(new Point(button33.Location.X + 20, button33.Location.Y + 20), currentBetNumber);
            chipsDoc.insert16(new Point(button16.Location.X + 20, button16.Location.Y + 20), currentBetNumber);
            chipsDoc.insert24(new Point(button24.Location.X + 20, button24.Location.Y + 20), currentBetNumber);
            chipsDoc.insert5(new Point(button5.Location.X + 20, button5.Location.Y + 20), currentBetNumber);
            chipsDoc.insert10(new Point(button10.Location.X + 20, button10.Location.Y + 20), currentBetNumber);
            chipsDoc.insert23(new Point(button23.Location.X + 20, button23.Location.Y + 20), currentBetNumber);
            chipsDoc.insert8(new Point(button8.Location.X + 20, button8.Location.Y + 20), currentBetNumber);
            chipsDoc.insert30(new Point(button30.Location.X + 20, button30.Location.Y + 20), currentBetNumber);
            chipsDoc.insert11(new Point(button11.Location.X + 20, button11.Location.Y + 20), currentBetNumber);
            chipsDoc.insert36(new Point(button36.Location.X + 20, button36.Location.Y + 20), currentBetNumber);
            chipsDoc.insert13(new Point(button13.Location.X + 20, button13.Location.Y + 20), currentBetNumber);
            chipsDoc.insert27(new Point(button27.Location.X + 20, button27.Location.Y + 20), currentBetNumber);
            Invalidate(true);
        }
    }
}
