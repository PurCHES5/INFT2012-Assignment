using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// External Package dot-net-transitions
using Transitions;

namespace ShengenQiHaoLiuAssgt
{
    public partial class MainGameForm : Form
    {
        private Image[] diceImages = new Image[6];

        private int runningScoreAggr = 0;

        private int player1CumulativeScore = 0;
        private int player2CumulativeScore = 0;

        private bool isLeftSide = true;

        private bool isVsCPU = false;

        public MainGameForm()
        {
            InitializeComponent();

            isVsCPU = MenuForm.isVsCPU;
            player1Text.Text = MenuForm.player1Name;
            player2Text.Text = MenuForm.player2Name;
            goalScore.Text = "Goal Score: " + MenuForm.goalScore;
            diceImages[0] = Properties.Resources.Dice1;
            diceImages[1] = Properties.Resources.Dice2;
            diceImages[2] = Properties.Resources.Dice3;
            diceImages[3] = Properties.Resources.Dice4;
            diceImages[4] = Properties.Resources.Dice5;
            diceImages[5] = Properties.Resources.Dice6;

            roll1.Enabled = false;
            roll2.Enabled = false;
            passDice1.Enabled = false;
            passDice2.Enabled = false;

            Random random = new Random();
            isLeftSide = random.Next(0, 2) == 0;

            if (!isLeftSide)
            {
                dicesPanel.Left = 550;
            }

            EnableButtons();

            if (isVsCPU && !isLeftSide)
            {
                roll2_Click(null, null);
            }
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
            EnableButtons();

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
                dice1.Image = diceImages[random.Next(0, 6)];
                dice2.Image = diceImages[random.Next(0, 6)];
            }

            int dice1FinalResult = random.Next(0, 6);
            int dice2FinalResult = random.Next(0, 6);
            int[] finalResults = { dice1FinalResult, dice2FinalResult };

            dice1.Image = diceImages[dice1FinalResult];
            dice2.Image = diceImages[dice2FinalResult];

            int diceResultsAggr = dice1FinalResult + dice2FinalResult + 2;
            string diceResultAggrText;
            if (diceResultsAggr == 2)
            {
                diceResultAggrText = "Snake's eyes!!!";
                Transition t = new Transition(new TransitionType_Flash(5, 100));
                t.add(pictureBox1, "Left", 420);
                t.run();
            }
            else if (dice1FinalResult == 0 || dice2FinalResult == 0)
            {
                diceResultAggrText = "Groan!";
                Transition t = new Transition(new TransitionType_Flash(3, 150));
                t.add(pictureBox1, "Left", 430);
                t.run();
            }
            else
            {
                diceResultAggrText = diceResultsAggr.ToString();
            }
            diceText.Text = 
                $"{dice1FinalResult + 1} + {dice2FinalResult + 1} = {diceResultAggrText}";

            EnableButtons();

            return finalResults;
        }

        /// <summary>
        /// Add the dice results to the accumulated running score and running score history.
        /// </summary>
        /// <param name="diceResults">dice result array (2 dices, each value ranges 0-5)</param>
        private void AddRunningScore(int[] diceResults)
        {
            int diceResultsAggr = diceResults[0] + diceResults[1] + 2;
            string diceResultAggrText;
            if (diceResultsAggr == 2)
            {
                diceResultAggrText = "Snake's eyes!!!";
            }
            else if (diceResults[0] == 0 || diceResults[1] == 0)
            {
                diceResultAggrText = "Groan!";
            }
            else
            {
                diceResultAggrText = diceResultsAggr.ToString();
            }
            runningScoreList.Text = 
                runningScoreList.Text.Insert(0, $"{diceResults[0] + 1} + {diceResults[1] + 1} = {diceResultAggrText}\r\n\r\n");

            runningScoreAggr += diceResultsAggr;
            runningScoreAggrLabel.Text = runningScoreAggr.ToString();
        }

        /// <summary>
        /// Test whether the dice results resulted in a Groan or Snake eye.
        /// </summary>
        /// <param name="diceResults">dice result array (2 dices, each value ranges 0-5)</param>
        /// <returns>Returns true if Groan or Snake eye, otherwise false.</returns>
        private async Task<bool> GroanOrSnake(int[] diceResults, int player)
        {
            if (diceResults[0] == 0 && diceResults[1] == 0)
            {
                roll1.Enabled = false;
                roll2.Enabled = false;
                passDice1.Enabled = false;
                passDice2.Enabled = false;

                runningScoreAggr = 0;
                runningScoreAggrLabel.Text = "0";
                if (player == 1)
                {
                    player1CumulativeScore = 0;
                    player1CumulativeScoreLabel.Text = "0";
                }
                else
                {
                    player2CumulativeScore = 0;
                    player2CumulativeScoreLabel.Text = "0";
                }

                await Task.Delay(2000);
                if (player == 1)
                {
                    passDice1_Click(null, null);
                }
                else
                {
                    passDice2_Click(null, null);
                }
                
                return true;
            }
            else if (diceResults[0] == 0 || diceResults[1] == 0)
            {
                roll1.Enabled = false;
                roll2.Enabled = false;
                passDice1.Enabled = false;
                passDice2.Enabled = false;

                runningScoreAggr = 0;
                runningScoreAggrLabel.Text = "0";
                await Task.Delay(2000);
                if (player == 1)
                {
                    passDice1_Click(null, null);
                }
                else
                {
                    passDice2_Click(null, null);
                }
                return true;
            }

            return false;
        }

        private bool IsWin(int player)
        {
            if ((player == 1 ? player1CumulativeScore : player2CumulativeScore) + runningScoreAggr >= MenuForm.goalScore)
            {
                MessageBox.Show("Game Over!\r\n" + (player == 1 ? MenuForm.player1Name : MenuForm.player2Name) + " wins!");

                EndGameResultForm.AddWins(player);
                this.Hide();
                EndGameResultForm endGameResultForm = new EndGameResultForm();
                endGameResultForm.Closed += (s, args) => this.Close();
                endGameResultForm.Show();
                return true;
            }
            return false;
        }

        private void EnableButtons()
        {
            if (isLeftSide)
            {
                roll1.Enabled = true;
                passDice1.Enabled = true;
            }
            else
            {
                if (!isVsCPU)
                {
                    roll2.Enabled = true;
                    passDice2.Enabled = true;
                }
                else
                {
                    roll2.Enabled = false;
                    passDice2.Enabled = false;
                }
            }
        }

        private bool DecideNextMove()
        {
            if (runningScoreAggr < 15 || player1CumulativeScore - (player2CumulativeScore + runningScoreAggr) > 10)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Should be called after every OnButton Click event. Prevent auto selecting a button.
        /// </summary>
        private void RemoveAutoSelect()
        {
            pictureBox1.Focus();
        }


        private async void roll1_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();
            
            AddRunningScore(diceResults);
            RemoveAutoSelect();
            await GroanOrSnake(diceResults, 1);
            IsWin(1);
        }

        private async void roll2_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();
            AddRunningScore(diceResults);
            RemoveAutoSelect();
            bool isGroanOrSnake = await GroanOrSnake(diceResults, 2);
            bool isWin = IsWin(2);

            if (isVsCPU && !isGroanOrSnake && !isWin)
            {
                await Task.Delay(1000);
                bool nextMove = DecideNextMove();
                if (nextMove) roll2_Click(null, null);
                else passDice2_Click(null, null);
            }
        }

        private async void passDice1_Click(object sender, EventArgs e)
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

            isLeftSide = false;

            RollMove();
            RemoveAutoSelect();

            if (isVsCPU)
            {
                await Task.Delay(1000);
                roll2_Click(null, null);
            }
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

            isLeftSide = true;

            RollMove();
            RemoveAutoSelect();
        }
    }
}


//<div>Icons made by <a href="https://www.flaticon.com/authors/dimi-kazak" title="Dimi Kazak">Dimi Kazak</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>