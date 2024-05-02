namespace cardsofate
{
    partial class form_mainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_timeLeftText = new Label();
            btn_restartGame = new Button();
            lbl_timer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            easyButton = new Button();
            mediumButton = new Button();
            hardButton = new Button();
            extremeButton = new Button();
            yesButton = new Button();
            noButton = new Button();
            timeChecker = new Label();
            title = new Label();
            SuspendLayout();
            // 
            // lbl_timeLeftText
            // 
            lbl_timeLeftText.AutoSize = true;
            lbl_timeLeftText.BackColor = Color.AntiqueWhite;
            lbl_timeLeftText.BorderStyle = BorderStyle.FixedSingle;
            lbl_timeLeftText.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_timeLeftText.Location = new Point(445, 100);
            lbl_timeLeftText.Name = "lbl_timeLeftText";
            lbl_timeLeftText.Padding = new Padding(10);
            lbl_timeLeftText.Size = new Size(106, 41);
            lbl_timeLeftText.TabIndex = 1;
            lbl_timeLeftText.Text = "Time Left:";
            lbl_timeLeftText.TextAlign = ContentAlignment.MiddleCenter;
            lbl_timeLeftText.Click += lbl_timeLeftText_Click;
            // 
            // btn_restartGame
            // 
            btn_restartGame.BackColor = Color.AntiqueWhite;
            btn_restartGame.FlatAppearance.BorderColor = Color.Black;
            btn_restartGame.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_restartGame.Location = new Point(427, 40);
            btn_restartGame.Name = "btn_restartGame";
            btn_restartGame.Size = new Size(141, 46);
            btn_restartGame.TabIndex = 3;
            btn_restartGame.Text = "Restart";
            btn_restartGame.UseVisualStyleBackColor = false;
            btn_restartGame.Click += restartGameEvent;
            // 
            // lbl_timer
            // 
            lbl_timer.BackColor = Color.AntiqueWhite;
            lbl_timer.BorderStyle = BorderStyle.FixedSingle;
            lbl_timer.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_timer.Location = new Point(458, 150);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Padding = new Padding(10);
            lbl_timer.Size = new Size(81, 37);
            lbl_timer.TabIndex = 4;
            lbl_timer.Text = "00:00";
            lbl_timer.TextAlign = ContentAlignment.MiddleCenter;
            lbl_timer.Click += lbl_timer_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // easyButton
            // 
            easyButton.BackColor = Color.AntiqueWhite;
            easyButton.FlatAppearance.BorderColor = Color.Black;
            easyButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            easyButton.Location = new Point(427, 210);
            easyButton.Name = "easyButton";
            easyButton.Size = new Size(141, 46);
            easyButton.TabIndex = 5;
            easyButton.Text = "Easy";
            easyButton.UseVisualStyleBackColor = false;
            easyButton.Click += easyButton_Click;
            // 
            // mediumButton
            // 
            mediumButton.BackColor = Color.AntiqueWhite;
            mediumButton.FlatAppearance.BorderColor = Color.Black;
            mediumButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            mediumButton.Location = new Point(427, 270);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(141, 46);
            mediumButton.TabIndex = 6;
            mediumButton.Text = "Medium";
            mediumButton.UseVisualStyleBackColor = false;
            mediumButton.Click += mediumButton_Click;
            // 
            // hardButton
            // 
            hardButton.BackColor = Color.AntiqueWhite;
            hardButton.FlatAppearance.BorderColor = Color.Black;
            hardButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            hardButton.Location = new Point(427, 330);
            hardButton.Name = "hardButton";
            hardButton.Size = new Size(141, 46);
            hardButton.TabIndex = 7;
            hardButton.Text = "Hard";
            hardButton.UseVisualStyleBackColor = false;
            hardButton.Click += hardButton_Click;
            // 
            // extremeButton
            // 
            extremeButton.BackColor = Color.AntiqueWhite;
            extremeButton.FlatAppearance.BorderColor = Color.Black;
            extremeButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            extremeButton.Location = new Point(427, 390);
            extremeButton.Name = "extremeButton";
            extremeButton.Size = new Size(141, 46);
            extremeButton.TabIndex = 8;
            extremeButton.Text = "Extreme";
            extremeButton.UseVisualStyleBackColor = false;
            extremeButton.Click += extremeButton_Click;
            // 
            // yesButton
            // 
            yesButton.BackColor = Color.AntiqueWhite;
            yesButton.FlatAppearance.BorderColor = Color.Black;
            yesButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            yesButton.Location = new Point(232, 242);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(141, 46);
            yesButton.TabIndex = 9;
            yesButton.Text = "Yes!";
            yesButton.UseVisualStyleBackColor = false;
            yesButton.Click += yesButton_Click;
            // 
            // noButton
            // 
            noButton.BackColor = Color.AntiqueWhite;
            noButton.FlatAppearance.BorderColor = Color.Black;
            noButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            noButton.Location = new Point(232, 330);
            noButton.Name = "noButton";
            noButton.Size = new Size(141, 46);
            noButton.TabIndex = 10;
            noButton.Text = "No!";
            noButton.UseVisualStyleBackColor = false;
            noButton.Click += noButton_Click;
            // 
            // timeChecker
            // 
            timeChecker.BackColor = Color.AntiqueWhite;
            timeChecker.BorderStyle = BorderStyle.FixedSingle;
            timeChecker.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            timeChecker.Location = new Point(445, 200);
            timeChecker.Name = "timeChecker";
            timeChecker.Padding = new Padding(10);
            timeChecker.Size = new Size(106, 116);
            timeChecker.TabIndex = 11;
            timeChecker.Text = "00:00";
            timeChecker.TextAlign = ContentAlignment.MiddleCenter;
            timeChecker.Click += label1_Click;
            // 
            // title
            // 
            title.BackColor = Color.AntiqueWhite;
            title.BorderStyle = BorderStyle.FixedSingle;
            title.Font = new Font("Viner Hand ITC", 35F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title.Location = new Point(12, 40);
            title.Name = "title";
            title.Padding = new Padding(10);
            title.Size = new Size(409, 92);
            title.TabIndex = 12;
            title.Text = "Cards Of Fate";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_mainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(581, 718);
            Controls.Add(title);
            Controls.Add(timeChecker);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(extremeButton);
            Controls.Add(hardButton);
            Controls.Add(mediumButton);
            Controls.Add(easyButton);
            Controls.Add(lbl_timer);
            Controls.Add(btn_restartGame);
            Controls.Add(lbl_timeLeftText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_mainGame";
            Text = "Cards of Fate";
            Load += form_mainGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_timeLeftText;
        private Button btn_restartGame;
        private Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private Button easyButton;
        private Button mediumButton;
        private Button hardButton;
        private Button extremeButton;
        private Button yesButton;
        private Button noButton;
        private Label timeChecker;
        private Label title;
    }
}