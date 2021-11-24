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
    public partial class MenuForm : Form
    {
        public static string player1Name;
        public static string player2Name;
        public static int goalScore;
        public static bool isVsCPU = false;

        public static Image[] avatarImages = new Image[11];

        public static int avatar1 = 0;
        public static int avatar2 = 5;

        public MenuForm()
        {
            InitializeComponent();

            avatarImages[0] = Properties.Resources.a1;
            avatarImages[1] = Properties.Resources.a2;
            avatarImages[2] = Properties.Resources.a3;
            avatarImages[3] = Properties.Resources.a4;
            avatarImages[4] = Properties.Resources.a5;
            avatarImages[5] = Properties.Resources.a6;
            avatarImages[6] = Properties.Resources.a7;
            avatarImages[7] = Properties.Resources.a8;
            avatarImages[8] = Properties.Resources.a9;
            avatarImages[9] = Properties.Resources.a10;
            avatarImages[10] = Properties.Resources.cpu;

            avatarPicBox1.Image = avatarImages[avatar1];
            avatarPicBox2.Image = avatarImages[avatar2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                goalScore = Convert.ToInt32(goalScoreTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Only use positive numbers for goal score!");
                return;
            }
            if (goalScore < 1)
            {
                MessageBox.Show("Only use positive numbers for goal score!");
                return;
            }

            this.Hide();
            isVsCPU = false;
            player1Name = player1NameTextBox.Text;
            player2Name = player2NameTextBox.Text;
            
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Closed += (s, args) => this.Close();
            mainGameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                goalScore = Convert.ToInt32(goalScoreTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Only use positive numbers for goal score!");
                return;
            }
            if (goalScore < 1)
            {
                MessageBox.Show("Only use positive numbers for goal score!");
                return;
            }

            this.Hide();
            isVsCPU = true;
            avatar2 = 10;
            player1Name = player1NameTextBox.Text;
            player2Name = "CPU";
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Closed += (s, args) => this.Close();
            mainGameForm.Show();
        }

        private void avatar1Left_Click(object sender, EventArgs e)
        {
            avatar1 = avatar1 == 0 ? 9 : avatar1 - 1;
            avatarPicBox1.Image = avatarImages[avatar1];
        }

        private void avatar1Right_Click(object sender, EventArgs e)
        {
            avatar1 = avatar1 == 9 ? 0 : avatar1 + 1;
            avatarPicBox1.Image = avatarImages[avatar1];
        }

        private void avatar2Left_Click(object sender, EventArgs e)
        {
            avatar2 = avatar2 == 0 ? 9 : avatar2 - 1;
            avatarPicBox2.Image = avatarImages[avatar2];
        }

        private void avatar2Right_Click(object sender, EventArgs e)
        {
            avatar2 = avatar2 == 9 ? 0 : avatar2 + 1;
            avatarPicBox2.Image = avatarImages[avatar2];
        }
    }
}

//https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
