using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardsofate
{
    public partial class form_mainGame : Form
    {

        // initialise the random library: 
        Random rng = new Random();

        List<int> cardNumbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 }; // a list of the possible icons that cards can have - represent image files

        // initialising important variables (for matching the cards): 
        int userTries;
        string firstCardUp;
        string secondCardUp;
        int timeLeft;
        int howManyCardSolved; // counts how many cards in total have been solved

        List<PictureBox> icons = new List<PictureBox>();
        PictureBox img_x;
        PictureBox img_y;

        // variable for tracking whether user has lost or not 
        bool isGameOver = false;

        public form_mainGame()
        {
            InitializeComponent();
            assignCards();
        }

        private void assignCards()
        {
            int leftPos = 20;
            int topPos = 20;
            int rowsSoFar = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newCard = new PictureBox();
                newCard.Height = 160;
                newCard.Width = 100;
                newCard.BackgroundImage = Image.FromFile("iconArt/0.png");
                newCard.BackgroundImageLayout = ImageLayout.Stretch;
                newCard.SizeMode = PictureBoxSizeMode.StretchImage;
                //newCard.BackColor = Color.Maroon;
                newCard.Click += onNewCardClicked;
                icons.Add(newCard);

                if (rowsSoFar < 3)
                {
                    rowsSoFar++;
                    newCard.Left = leftPos;
                    newCard.Top = topPos;
                    this.Controls.Add(newCard);
                    leftPos = leftPos + 110;
                }

                if (rowsSoFar == 3)
                {
                    rowsSoFar = 0;
                    leftPos = 20;
                    topPos += 170;
                }
            }

        restartGame();

        }

        private void restartGame()
        {
            // method to call when the restart game button is clicked 
            
            // randomise original list 
            var randomList = cardNumbers.OrderBy(x => Guid.NewGuid()).ToList();

            cardNumbers = randomList;

            for (int i = 0; i < icons.Count; i++ )
            {
                icons[i].Image = null;
                icons[i].Tag = cardNumbers[i].ToString();
            }

            userTries = 0;
            isGameOver = false;
            howManyCardSolved = 0;

            // need code to reset timer here

        }

        private void onNewCardClicked(object sender, EventArgs e)
        {
            // first, check if the game is already over: 
            if (isGameOver)
            {
                // don't register a click if the game is over
                return;
            }

            // if no card is clipped, flip the first card
            if (firstCardUp == null)
            {
                // cast sender to image box
                img_x = sender as PictureBox;

                // check if the card is not already flipped
                if (img_x.Tag != null && img_x.Image == null)
                {
                    // load and display the image associated with the card
                    img_x.Image = Image.FromFile("iconArt/" + (string)img_x.Tag + ".png");
                    firstCardUp = (string)img_x.Tag;
                }
            }

            // if one card is flipped, flip the second one 
            else if(secondCardUp == null)
            {
                img_y = sender as PictureBox;

                // check if the card is not already flipped
                if (img_y.Tag != null && img_y.Image == null)
                {
                    // load and display the image associated with the card
                    img_y.Image = Image.FromFile("iconArt/" + (string)img_y.Tag + ".png");
                    secondCardUp = (string)img_y.Tag;
                }
            }
            else
            {
                // if both cards are flipped, compare them
                compareCards(img_x, img_y);
            }
        }

        private void compareCards(PictureBox A, PictureBox B)
        {
            if (firstCardUp == secondCardUp)
            {
                A.Tag = null;
                B.Tag = null;
                howManyCardSolved++;
            }
            else
            {
                userTries++;
            }

            firstCardUp = null;
            secondCardUp = null;

            foreach (PictureBox pics in icons.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null; 
                }
            }

            // now let's check if all the items have been solved

            if (howManyCardSolved == 12)
            {
                endGame("Great job! You win!");
            }
        }

        private void endGame(string msg)
        {
            // method to make an announcement of whether the player has won or lost the game

            // write code here that will stop the timer

            isGameOver = true;
            MessageBox.Show(msg + "Click 'Restart Game' to play again.", "Congrats!");
        }

        private void timerEvent(object sender, EventArgs e)
        {
            /* this is to count down the timer, this code is here just to reset card icons if the player
             * runs out of time.
             * please change as needed, or take code out of it to make a new method etc. */

            // timer tick code here 

            if (lbl_timer.Text == "00:00")
            {
                // if the timer has run out:

                endGame("Time's up, you lose.");
                foreach (PictureBox x in icons)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag+".png");
                    }
                }
            }
        }
        private void restartGameEvent(object sender, EventArgs e)
        {
            restartGame();
        }
    }
}