using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShengenQiHaoLiuAssgt
{
    public partial class EndGameResultForm : Form
    {
        private static int player1Wins = 0;
        private static int player2Wins = 0;

        private int player1CrownLeft = 140;
        private int player2CrownLeft = 480;

        public EndGameResultForm()
        {
            InitializeComponent();
            player1Name.Text = MenuForm.player1Name;
            player2Name.Text = MenuForm.player2Name;
            player1Win.Text = player1Wins.ToString();
            player2Win.Text = player2Wins.ToString();

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

        public static void ClearWins()
        {
            player1Wins = 0;
            player2Wins = 0;
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

//https://www.kindpng.com/imgv/TwmRbx_hand-drawn-cartoon-free-hand-drawn-crown-png/