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
            mForm.roll1.Enabled = false;
            mForm.roll2.Enabled = false;
            await Task.Delay(600);
            mForm.roll1.Enabled = true;
            mForm.roll2.Enabled = true;
            mForm.diceText.Text = InGameText.diceWaiting;
        }

        private async static Task<int[]> RollDice()
        {
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
            await Task.Delay(1000);

            return finalResults;
        }

        private async void roll1_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();

            diceText.Text = InGameText.dicePassing;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 550);
            t.run();

            RollMove();
        }

        private async void roll2_Click(object sender, EventArgs e)
        {
            int[] diceResults = await RollDice();

            diceText.Text = InGameText.dicePassing;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 300);
            t.run();

            RollMove();
        }
    }
}
