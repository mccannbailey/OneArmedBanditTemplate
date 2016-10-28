using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int score = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            int 
            int reelOne = rnd.Next(1, 4);
            int reelTwo = rnd.Next(1, 4);
            int reelThree = rnd.Next(1, 4);
            score = score - 1;
            scoreDisplay.Text = Convert.ToString(score);

            if (score > 0)
            {
                switch (reelOne)
                {
                    case 1:
                        reel1.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel1.Image = Properties.Resources.cherry_100x125;
                        break;
                    case 3:
                        reel1.Image = Properties.Resources.diamond_100x125;
                        break;
                }
                switch (reelTwo)
                {
                    case 1:
                        reel2.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel2.Image = Properties.Resources.cherry_100x125;
                        break;
                    case 3:
                        reel2.Image = Properties.Resources.diamond_100x125;
                        break;
                }
                switch (reelThree)
                {
                    case 1:
                        reel3.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel3.Image = Properties.Resources.cherry_100x125;
                        break;
                    case 3:
                        reel3.Image = Properties.Resources.diamond_100x125;
                        break;
                }
            }
            if (reel1.Image == Properties.Resources._7_100x125) && (reelOne == reelTwo == reelThree)
            {

            }     

            else if (score <= 0)
            {
                coinLabel.ForeColor = Color.Red;
                scoreDisplay.ForeColor = Color.Red;
                outputLabel.Text = "Not enough money!";
            }

        }
    }
}

