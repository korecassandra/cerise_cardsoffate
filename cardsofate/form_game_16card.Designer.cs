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
            lbl_timeLeftText = new Label();
            btn_restartGame = new Button();
            lbl_timer = new Label();
            SuspendLayout();
            // 
            // lbl_timeLeftText
            // 
            lbl_timeLeftText.AutoSize = true;
            lbl_timeLeftText.BackColor = Color.AntiqueWhite;
            lbl_timeLeftText.BorderStyle = BorderStyle.FixedSingle;
            lbl_timeLeftText.Location = new Point(458, 105);
            lbl_timeLeftText.Name = "lbl_timeLeftText";
            lbl_timeLeftText.Padding = new Padding(10);
            lbl_timeLeftText.Size = new Size(81, 37);
            lbl_timeLeftText.TabIndex = 1;
            lbl_timeLeftText.Text = "Time Left:";
            lbl_timeLeftText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_restartGame
            // 
            btn_restartGame.BackColor = Color.AntiqueWhite;
            btn_restartGame.FlatAppearance.BorderColor = Color.Black;
            btn_restartGame.Location = new Point(427, 41);
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
            lbl_timer.Location = new Point(458, 152);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Padding = new Padding(10);
            lbl_timer.Size = new Size(81, 37);
            lbl_timer.TabIndex = 4;
            lbl_timer.Text = "00:00";
            lbl_timer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_mainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 718);
            Controls.Add(lbl_timer);
            Controls.Add(btn_restartGame);
            Controls.Add(lbl_timeLeftText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_mainGame";
            Text = "Cards of Fate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_timeLeftText;
        private Button btn_restartGame;
        private Label lbl_timer;
    }
}