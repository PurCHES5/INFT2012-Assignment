using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace ShengenQiHaoLiuAssgt
{
    public partial class MainGameForm : Form
    {
        private static MainGameForm mForm = null;

        private static Image[] diceImages = new Image[6];

        private int player1RunningScoreAggr = 0;
        private int player2RunningScoreAggr = 0;

        private int player1CumulativeScore = 0;
        private int player2CumulativeScore = 0;

        public MainGameForm()
        {
            InitializeComponent();
            mForm = this;
            player1Text.Text = MenuForm.player1Name;
            player2Text.Text = MenuForm.player2Name;
            diceImages[0] = Properties.Resources.Dice1;
            diceImages[1] = Properties.Resources.Dice2;
            diceImages[2] = Properties.Resources.Dice3;
            diceImages[3] = Properties.Resources.Dice4;
            diceImages[4] = Properties.Resources.Dice5;
            diceImages[5] = Properties.Resources.Dice6;
        }

        private async static void RollMove()
        {
            mForm.dice1.Image = diceImages[0];
            mForm.dice2.Image = diceImages[0];
            mForm.roll1.Enabled = false;
            mForm.roll2.Enabled = false;
            mForm.passDice1.Enabled = false;
            mForm.passDice2.Enabled = false;
            await Task.Delay(600);
            mForm.roll1.Enabled = true;
            mForm.roll2.Enabled = true;
            mForm.passDice1.Enabled = true;
            mForm.passDice2.Enabled = true;
            mForm.diceText.Text = InGameText.diceWaiting;
        }

        private async static Task<int[]> RollDice()
        {
            mForm.diceText.Text = InGameText.diceRolling;
            mForm.roll1.Enabled = false;
            mForm.roll2.Enabled = false;
            mForm.passDice1.Enabled = false;
            mForm.passDice2.Enabled = false;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                mForm.dice1.Image = diceImages[random.Next(0, 5)];
                mForm.dice2.Image = diceImages[random.Next(0, 5)];
            }

            int dice1FinalResult = random.Next(0, 5);
            int dice2FinalResult = random.Next(0, 5);
            int[] finalResults = { dice1FinalResult, dice2FinalResult };

            mForm.dice1.Image = diceImages[dice1FinalResult];
            mForm.dice2.Image = diceImages[dice2FinalResult];
            mForm.diceText.Text = 
                $"{dice1FinalResult + 1} + {dice2FinalResult + 1} = {dice1FinalResult + dice2FinalResult + 2}";

            mForm.roll1.Enabled = true;
            mForm.roll2.Enabled = true;
            mForm.passDice1.Enabled = true;
            mForm.passDice2.Enabled = true;

            return finalResults;
        }

        private async void roll1_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();
            int diceResultsAggr = diceResults[0] + diceResults[1] + 2;
            player1RunningScoreList.Text = player1RunningScoreList.Text.Insert(0, diceResultsAggr + "\r\n\r\n");

            player1RunningScoreAggr += diceResultsAggr;
            player1RunningScoreAggrLabel.Text = player1RunningScoreAggr.ToString();
        }

        private async void roll2_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();
            int diceResultsAggr = diceResults[0] + diceResults[1] + 2;
            player2RunningScoreList.Text = player2RunningScoreList.Text.Insert(0, diceResultsAggr + "\r\n\r\n");

            player2RunningScoreAggr += diceResultsAggr;
            player2RunningScoreAggrLabel.Text = player2RunningScoreAggr.ToString();
        }

        private void passDice1_Click(object sender, EventArgs e)
        {
            diceText.Text = InGameText.dicePassing;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 550);
            t.run();

            player1CumulativeScore += player1RunningScoreAggr;
            player1RunningScoreAggr = 0;
            player1RunningScoreList.Text = "";
            player1RunningScoreAggrLabel.Text = "0"; 
            player1CumulativeScoreLabel.Text = player1CumulativeScore.ToString();

            RollMove();
        }

        private void passDice2_Click(object sender, EventArgs e)
        {
            diceText.Text = InGameText.dicePassing;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 300);
            t.run();

            player2CumulativeScore += player2RunningScoreAggr;
            player2RunningScoreAggr = 0;
            player2RunningScoreList.Text = "";
            player2RunningScoreAggrLabel.Text = "0";
            player2CumulativeScoreLabel.Text = player2CumulativeScore.ToString();

            RollMove();
        }
    }
}


//"roll the dice" by Darwin Bell is licensed with CC BY-NC 2.0. To view a copy of this license, visit https://creativecommons.org/licenses/by-nc/2.0/
