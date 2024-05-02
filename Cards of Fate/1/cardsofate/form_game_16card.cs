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
using System.Windows.Forms.VisualStyles;

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
        int totalTime;
        int timer = 60;
        int seconds;
        Image[] images = { };
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        List<PictureBox> icons = new List<PictureBox>();
        PictureBox img_x;
        PictureBox img_y;

        // variable for tracking whether user has lost or not 
        bool isGameOver = false;

        public form_mainGame()
        {
            InitializeComponent();
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
            startGame();
        }
        private void restartGame()
        {
            for (int i = 0; i < icons.Count; i++)
            {
                icons[i].Hide();
            }
            icons.Clear();
            timeChecker.Visible = false;
        }

        private void startGame()
        {
            var randomList = cardNumbers.OrderBy(x => Guid.NewGuid()).ToList();

            cardNumbers = randomList;

            for (int i = 0; i < icons.Count; i++)
            {
                icons[i].Image = null;
                icons[i].Tag = cardNumbers[i].ToString();
                //images[i] =  
            }

            userTries = 0;
            isGameOver = false;
            howManyCardSolved = 0;
            // method to call when the restart game button is clicked 

            // randomise original list 


            // need code to reset timer here

        }

        private void onNewCardClicked(object sender, EventArgs e)
        {
            // first, check if the game is already over: 
            if (btn_restartGame.Visible == false)
            {
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
                else if (secondCardUp == null)
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

            
        }

        private void compareCards(PictureBox A, PictureBox B)
        {
            if (firstCardUp == secondCardUp)
            {
                A.Tag = null;
                B.Tag = null;
                howManyCardSolved++;

                if (howManyCardSolved == 6)
                {
                    // Stop the timer when all cards are matched. Present Winning Message.
                    myTimer.Stop();
                    MessageBox.Show("Great job! You win! Click Restart to Play Again.");
                    btn_restartGame.Visible = true;
                    timeChecker.Visible = true;
                    timeChecker.Text = "You finished in " + (totalTime - timer).ToString() + " seconds!";
                }
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
        }
        private void timerEvent(object sender, EventArgs e)
        {
            
        }
        private void restartGameEvent(object sender, EventArgs e)
        {
            restartGame();
            showDifficulty();
            title.Visible = true;
            btn_restartGame.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            timerCheck();
            if (timer <= 0)
            {
                myTimer.Stop();
                MessageBox.Show("Game Over! Click Restart to Play Again.");
                btn_restartGame.Visible = true;
            }
        }
        private void timerCheck()
        {
            int minutes = (int)Decimal.Truncate(timer / 60);
            seconds = (int)Decimal.Truncate(timer - (60 * minutes));
            lbl_timer.Text = minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
        }

        private void form_mainGame_Load(object sender, EventArgs e)
        {
            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(timer1_Tick);
            hideButtons();
            timeChecker.Visible = false;
            btn_restartGame.Visible = false;
        }

        private void showButtons()
        {
            noButton.Visible = true;
            yesButton.Visible = true;
        }
        private void hideButtons()
        {
            noButton.Visible = false;
            yesButton.Visible = false;
        }
        private void showDifficulty()
        {
            easyButton.Visible = true;
            mediumButton.Visible = true;
            hardButton.Visible = true;
            extremeButton.Visible = true;
        }
        private void hideDifficulty()
        {
            easyButton.Visible = false;
            mediumButton.Visible = false;
            hardButton.Visible = false;
            extremeButton.Visible = false;
        }

        private void lbl_timer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_timeLeftText_Click(object sender, EventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            totalTime = 60;
            timer = 60;
            timerCheck();
            showButtons();
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            totalTime = 45;
            timer = 45;
            timerCheck();
            showButtons();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            totalTime = 30;
            timer = 30;
            timerCheck();
            showButtons();
        }

        private void extremeButton_Click(object sender, EventArgs e)
        {
            totalTime = 15;
            timer = 15;
            timerCheck();
            showButtons();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            myTimer.Start();
            hideButtons();
            assignCards();
            hideDifficulty();
            title.Visible = false;
            btn_restartGame.Visible = false;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            timer = 0;
            timerCheck();
            hideButtons();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}