using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
// External Package dot-net-transitions
using Transitions;

namespace ShengenQiHaoLiuAssgt
{
    public partial class MainGameForm : Form
    {
        // Storing all dice images
        private Image[] diceImages = new Image[6];

        // Current round running score aggregation.
        private int runningScoreAggr = 0;

        // Cumulative scores for each player
        private int player1CumulativeScore = 0;
        private int player2CumulativeScore = 0;

        // Is the left side player(player1) playing?
        private bool isLeftSide = true;

        // Is current game mode Singleplayer?
        private bool isVsCPU = false;

        public MainGameForm()
        {
            InitializeComponent();

            isVsCPU = MenuForm.isVsCPU;

            // Getting all images from resource and save to static attributes.
            avatarPicBox1.Image = MenuForm.avatarImages[MenuForm.avatar1];
            avatarPicBox2.Image = MenuForm.avatarImages[MenuForm.avatar2];

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

            // Randomly decide which player starts the game
            Random random = new Random();
            isLeftSide = random.Next(0, 2) == 0;

            // If player2 plays first, move the default dice position to player2
            if (!isLeftSide)
            {
                dicesPanel.Left = 550;
            }

            EnableButtons();

            // If the gamemode is Singleplayer, remove the buttons and shows the AI's strategy
            if (isVsCPU && !isLeftSide)
            {
                roll2_Click(null, null);
            }

            if (isVsCPU)
            {
                aiStrategyText.Visible = true;
                roll2.Visible = false;
                passDice2.Visible = false;
            }
        }

        /// <summary>
        /// Passing the dices to the opposite player
        /// </summary>
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

        /// <summary>
        /// Rolling the dices
        /// </summary>
        /// <returns>int array including two integers(start from 0, range0-5), 
        /// each represents the result of the dice</returns>
        private async Task<int[]> RollDice()
        {
            diceText.Text = InGameText.diceRolling;
            roll1.Enabled = false;
            roll2.Enabled = false;
            passDice1.Enabled = false;
            passDice2.Enabled = false;

            Random random = new Random();

            // Shows dice thowing animation (randomized).
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                dice1.Image = diceImages[random.Next(0, 6)];
                dice2.Image = diceImages[random.Next(0, 6)];
            }

            // Get the final result of each dices.
            int dice1FinalResult = random.Next(0, 6);
            int dice2FinalResult = random.Next(0, 6);
            int[] finalResults = { dice1FinalResult, dice2FinalResult };

            dice1.Image = diceImages[dice1FinalResult];
            dice2.Image = diceImages[dice2FinalResult];

            // Each dicexFinalResult need to add 1 when for actual calculation. Since the value is ranged (0-5)
            // and is only used for array calculation (as array starts from 0)
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
                runningScoreList.Text.Insert(
                    0, $"{diceResults[0] + 1} + {diceResults[1] + 1} = {diceResultAggrText}\r\n\r\n");

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
            if (diceResults[0] == 0 && diceResults[1] == 0) // Snake's eyes
            {
                roll1.Enabled = false;
                roll2.Enabled = false;
                passDice1.Enabled = false;
                passDice2.Enabled = false;

                // Set both running score and cumulative score to 0.
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

                // wait 2 seconds then automatically pass the dices to the next player
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
            else if (diceResults[0] == 0 || diceResults[1] == 0)    // Groan
            {
                roll1.Enabled = false;
                roll2.Enabled = false;
                passDice1.Enabled = false;
                passDice2.Enabled = false;

                // Set running score to 0 and automatically pass the dices
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

        /// <summary>
        /// Test if the the player wins (Running score + Cumulative score >= Goal score ?)
        /// </summary>
        /// <param name="player">0 is player1, 1 is player 2</param>
        /// <returns>true if the player wins, otherwise false</returns>
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

        /// <summary>
        /// Enable buttons after disabling it during animation or other actions
        /// </summary>
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

        /// <summary>
        /// Decide next move for AI, whether should throw the dices or pass it
        /// </summary>
        /// <returns>true if next move is throw dices, false if next move is pass the dices</returns>
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

            // Decide next move for the AI if not winning or getting a Groan or Snake's eyes
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

//==========================================
// Reference B1: externally sourced asset (Image)
// Purpose: Use as the icon of the program
// Date: 18/11/2021
// Source: flaticon
// Author: Dimi Kazak
// url: https://www.flaticon.com/authors/dimi-kazak
// Adaptation required: Zooming the image
// Note: The same image is used in all the other forms as form icon
//==========================================
// End of Reference B1
//==========================================