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
        private Image[] diceImages = new Image[6];

        private int runningScoreAggr = 0;

        private int player1CumulativeScore = 0;
        private int player2CumulativeScore = 0;

        public MainGameForm()
        {
            InitializeComponent();
            player1Text.Text = MenuForm.player1Name;
            player2Text.Text = MenuForm.player2Name;
            diceImages[0] = Properties.Resources.Dice1;
            diceImages[1] = Properties.Resources.Dice2;
            diceImages[2] = Properties.Resources.Dice3;
            diceImages[3] = Properties.Resources.Dice4;
            diceImages[4] = Properties.Resources.Dice5;
            diceImages[5] = Properties.Resources.Dice6;
        }

        private async void RollMove()
        {
            dice1.Image = diceImages[0];
            dice2.Image = diceImages[0];
            roll1.Enabled = false;
            roll2.Enabled = false;
            passDice1.Enabled = false;
            passDice2.Enabled = false;
            await Task.Delay(600);
            roll1.Enabled = true;
            roll2.Enabled = true;
            passDice1.Enabled = true;
            passDice2.Enabled = true;
            diceText.Text = InGameText.diceWaiting;
        }

        private async Task<int[]> RollDice()
        {
            diceText.Text = InGameText.diceRolling;
            roll1.Enabled = false;
            roll2.Enabled = false;
            passDice1.Enabled = false;
            passDice2.Enabled = false;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                dice1.Image = diceImages[random.Next(0, 5)];
                dice2.Image = diceImages[random.Next(0, 5)];
            }

            int dice1FinalResult = random.Next(0, 5);
            int dice2FinalResult = random.Next(0, 5);
            int[] finalResults = { dice1FinalResult, dice2FinalResult };

            dice1.Image = diceImages[dice1FinalResult];
            dice2.Image = diceImages[dice2FinalResult];
            diceText.Text = 
                $"{dice1FinalResult + 1} + {dice2FinalResult + 1} = {dice1FinalResult + dice2FinalResult + 2}";

            roll1.Enabled = true;
            roll2.Enabled = true;
            passDice1.Enabled = true;
            passDice2.Enabled = true;

            return finalResults;
        }

        private void AddRunningScore(int[] diceResults)
        {
            int diceResultsAggr = diceResults[0] + diceResults[1] + 2;
            runningScoreList.Text = 
                runningScoreList.Text.Insert(0, $"{diceResults[0] + 1} + {diceResults[1] + 1} = {diceResultsAggr}\r\n\r\n");

            runningScoreAggr += diceResultsAggr;
            runningScoreAggrLabel.Text = runningScoreAggr.ToString();
        }

        private bool GroanOrSnake(int[] diceResults)
        {
            if (diceResults[0] == 0 && diceResults[1] == 0)
            {
                return true;
            }
            else if (diceResults[0] == 0 || diceResults[1] == 0)
            {
                return true;
            }

            return false;
        }


        private async void roll1_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();
            GroanOrSnake(diceResults);
            AddRunningScore(diceResults);
        }

        private async void roll2_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();
            AddRunningScore(diceResults);
        }

        private void passDice1_Click(object sender, EventArgs e)
        {
            diceText.Text = InGameText.dicePassing;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 550);
            t.run();

            player1CumulativeScore += runningScoreAggr;
            runningScoreAggr = 0;
            runningScoreList.Text = "";
            runningScoreAggrLabel.Text = "0"; 
            player1CumulativeScoreLabel.Text = player1CumulativeScore.ToString();

            RollMove();
        }

        private void passDice2_Click(object sender, EventArgs e)
        {
            diceText.Text = InGameText.dicePassing;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 300);
            t.run();

            player2CumulativeScore += runningScoreAggr;
            runningScoreAggr = 0;
            runningScoreList.Text = "";
            runningScoreAggrLabel.Text = "0";
            player2CumulativeScoreLabel.Text = player2CumulativeScore.ToString();

            RollMove();
        }
    }
}


//<div>Icons made by <a href="https://www.flaticon.com/authors/dimi-kazak" title="Dimi Kazak">Dimi Kazak</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>