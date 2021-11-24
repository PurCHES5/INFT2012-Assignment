using System;
using System.Windows.Forms;

namespace ShengenQiHaoLiuAssgt
{
    public partial class EndGameResultForm : Form
    {
        // Total wins for each player.
        private static int player1Wins = 0;
        private static int player2Wins = 0;

        // Left value for crown image for each player.
        private int player1CrownLeft = 140;
        private int player2CrownLeft = 485;

        public EndGameResultForm()
        {
            InitializeComponent();
            player1Name.Text = MenuForm.player1Name;
            player2Name.Text = MenuForm.player2Name;
            player1Win.Text = player1Wins.ToString();
            player2Win.Text = player2Wins.ToString();

            avatarPicBox1.Image = MenuForm.avatarImages[MenuForm.avatar1];
            avatarPicBox2.Image = MenuForm.avatarImages[MenuForm.avatar2];

            // Move the crown to the correct player, if ties then hide it.
            if (player1Wins == player2Wins)
            {
                crownPic.Visible = false;
            }
            else if (player2Wins > player1Wins)
            {
                crownPic.Left = player2CrownLeft;
            }
            else
            {
                crownPic.Left = player1CrownLeft;
            }
        }

        /// <summary>
        /// Add winning totals to RAM. Called before showing the end game result form.
        /// </summary>
        /// <param name="player">1 for player1, 2 for player 2</param>
        public static void AddWins(int player)
        {
            if (player == 1)
            {
                player1Wins++;
            }
            else
            {
                player2Wins++;
            }
        }

        /// <summary>
        /// Reset winning totals from RAM.
        /// </summary>
        public static void ClearWins()
        {
            player1Wins = 0;
            player2Wins = 0;
            MenuForm.avatar2 = 5;
            MenuForm.avatar1 = 0;
        }

        private void newRoundButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Closed += (s, args) => this.Close();
            mainGameForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ClearWins();
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.Show();
        }
    }
}

//==========================================
// Reference C1: externally sourced asset (Image)
// Purpose: Used as an winner icon for the player with a higher winning count
// Date: 18/11/2021
// Source: kindpng
// Author: snapixel
// url: https://www.kindpng.com/imgv/TwmRbx_hand-drawn-cartoon-free-hand-drawn-crown-png/
// Adaptation required: Zooming the image
//==========================================
// End of Reference C1
//==========================================