using System.Drawing;

namespace cardsofate
{
    public partial class form_mainGame : Form
    {
        Random rng = new Random();
        // intialising the random library 
        List<string> icons = new List<string>() // creating a list of possible images for cards to have 
        {
            "koh", "kod", "koc", "kos",
            "qoh", "qod", "qoc", "qos",
            "joh", "jod", "joc", "jos"
        };

        /* declares variables for first clicked & second clicked cards; 
         * useful for later when user is matching up cards */
        // Label firstClicked, secondClicked;

        public form_mainGame()
        {
            InitializeComponent();
            // tbl_cardLayout.Enabled = true;
        }

        private void assignCards()
        {
            // Reset the icons list
            icons = new List<string>()
    {
        "koh", "kod", "koc", "kos",
        "qoh", "qod", "qoc", "qos",
        "joh", "jod", "joc", "jos"
    };

            // Method for assigning icons/cards to squares in the table layout

            // Count the number of PictureBox controls in the table layout 
            int pictureBoxCount = tbl_cardLayout.Controls.OfType<PictureBox>().Count();

            // Calculate the number of pairs needed
            int pairsNeeded = pictureBoxCount / 2;

            // Create a list to hold pairs of icons
            List<string> iconPairs = new List<string>();

            // Add pairs of icons to the list
            foreach (string icon in icons)
            {
                // Add each icon once to the list
                iconPairs.Add(icon);
                // Add each icon again to ensure there's a pair
                iconPairs.Add(icon);
            }

            // Shuffle the list of pairs
            shuffle(iconPairs);

            // Loop through each PictureBox control in the table layout 
            foreach (Control control in tbl_cardLayout.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    // Assign icon to PictureBox control if there are still pairs available
                    if (iconPairs.Count > 0)
                    {
                        pictureBox.Image = Properties.Resources.ResourceManager.GetObject(iconPairs[0]) as Image;
                        pictureBox.Tag = iconPairs[0]; // Store the icon's name in PictureBox.Tag
                        iconPairs.RemoveAt(0); // Remove the assigned icon from the list of pairs
                    }
                    else
                    {
                        // If there are no more pairs in iconPairs, display an error message
                        MessageBox.Show("Error: Not enough pairs to assign to PictureBox controls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }



        // method to shuffle a list (for the icons list) using Fisher-Yates algorithm
        private void shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1); // Corrected the range to [0, n)
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


        private void lbl_timeLeftText_Click(object sender, EventArgs e)
        {

        }

        private void playGame_Clicked(object sender, EventArgs e)
        {
            // difficultyMenuShow();
        }

        private void lbl_timer_Click(object sender, EventArgs e)
        {

        }

        private void btn_restartGame_Click_1(object sender, EventArgs e)
        {
            assignCards();
            lbl_timer.Text = "30:00";
        }

        /* private void difficultyMenuShow()
        {
            // shows the difficulty menu 
            btn_difficultySelect_Easy.Show();
            btn_difficultySelect_Medium.Show();
            btn_difficultySelect_Hard.Show();
            if (isExtremeUnlocked = true)
            {
                btn_difficultySelect_Extreme.Show();
            }
        } */
    }
}