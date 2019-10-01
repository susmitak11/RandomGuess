using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int randomNumber = 0;
        int chances = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = rand.Next(0, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = randomNumber + "";

            //MessageBox.Show(Convert.ToString(randomNumber));
            if (chances > 0)
            {
                if (Convert.ToInt32(TextBox.Text) == randomNumber)
                {
                    MessageBox.Show("you win");
                }
                else if (Convert.ToInt32(TextBox.Text) != randomNumber)
                {
                    MessageBox.Show("you have " + chances + " number of chance(s) left");
                    //chances = chances - 1;
                    //chances -= 1;
                    chances--;
                    //TextBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("you lose");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
    }
}
