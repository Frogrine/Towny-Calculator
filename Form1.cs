using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towny_Calculator
{
    public partial class TownyCalculator : Form
    {
        public TownyCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check for errors
            try
            {
                //assign a custom variable to the "gold1" text field:
                int gold = int.Parse(gold1.Text);

                //do the equation:
                double math = gold / 16;

                //set the value of the chunksRES1 field:
                chunksRES1.Text = math.ToString();
            } catch
            {
                MessageBox.Show("'It may not be empty \nnor messed up'\n\t\t~ Grandpa", "Read the quote!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check for errors
            try
            {   
                //assign a custom variable to the "chunks1" text field:
                int chunks = int.Parse(chunks1.Text);

                //do the equation:
                double math = chunks * 16;
                    
                //set the value of the goldRES1 field:
                goldRES1.Text = math.ToString();
            } catch
            {
                MessageBox.Show("'It may not be empty \nnor messed up'\n\t\t~ Grandpa", "Read the quote!", MessageBoxButtons.OK);
            }   
        }
    }
}
