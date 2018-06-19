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
    public partial class InsertCreditsForm : Form
    {
        public int credits;
        public RouletteBetScreen rouletteBetScreen { get; set; }
        public InsertCreditsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            credits = Convert.ToInt32(textBox1.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (((Convert.ToInt32(textBox1.Text)) > 1000) || ((Convert.ToInt32(textBox1.Text)) < 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Enter amount amount lower than 1000");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
        }

        // Validating each stroke and if the user enter a char it deletes it
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
