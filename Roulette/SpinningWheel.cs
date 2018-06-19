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
    public partial class SpinningWheel : Form
    {
        public int timerCall = 0;
        public RouletteBetScreen rouletteBetScreen { get; set; }
        Random random = new Random();
        public int currentNumber;
        public int seconds = 0;
        public int[] numbers = new int[37] { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };
        public int[] redNumbers = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public int[] blackNumbers = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public int y, z;


        public SpinningWheel()
        {
            InitializeComponent();
            y = random.Next(85, 120);
            z = random.Next(40, 80);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (z == 0)
            {
                timer1.Stop();

                currentNumber = numbers[(y % 37)+1];
                //currentNumber = 5; For testing

                // Wait 2 seconds then close
                System.Threading.Thread.Sleep(2000);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

            // Changing the background color depend of the number
            foreach (int n in blackNumbers)
            {
                if (numbers[y % 37] == n)
                {
                label1.BackColor = Color.Red;
                break;
                }
            }
            foreach (int n in redNumbers)
            {
                if (numbers[y % 37] == n)
                {
                    label1.BackColor = Color.Black;
                    break;
                }
            }
            if(numbers[y%37] == 0)
            {
                label1.BackColor = Color.Green;
            }

            label1.Text = numbers[y % 37].ToString();
            y--;
            z--;

            // After few seconds lower the interval of the timer
            if (timerCall % 10 == 0)
            {
                seconds++;
                if (seconds == 2)
                    timer1.Interval = 250;
                if(seconds == 3)
                    timer1.Interval = 500;
                if (seconds == 6)
                    timer1.Interval = 700;
            }
            timerCall++;
        }
    }
}
