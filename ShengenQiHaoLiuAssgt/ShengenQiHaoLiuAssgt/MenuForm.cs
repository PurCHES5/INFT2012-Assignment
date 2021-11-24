using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShengenQiHaoLiuAssgt
{
    public partial class MenuForm : Form
    {
        // Each player's name and decided goal score
        public static string player1Name;
        public static string player2Name;
        public static int goalScore;
        // true if player chooses Singleplayer, otherwise stays default(false).
        public static bool isVsCPU = false;

        // Storing all avatar images.
        public static Image[] avatarImages = new Image[11];

        // Current avatar index
        public static int avatar1 = 0;
        public static int avatar2 = 5;

        public MenuForm()
        {
            InitializeComponent();

            // Getting all images from resource and save to static attributes.
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
            // catch exceptions if the player enters an invalid input into the goal score.
            try
            {
                goalScore = Convert.ToInt32(goalScoreTextBox.Text);
            }
            catch
            {
                MessageBox.Show(InGameText.goalScoreInputWarning);
                return;
            }
            if (goalScore < 50 || goalScore > 100)
            {
                MessageBox.Show(InGameText.goalScoreInputWarning);
                return;
            }

            this.Hide();
            isVsCPU = false;
            player1Name = player1NameTextBox.Text;
            player2Name = player2NameTextBox.Text;

            //==========================================
            // Reference A1: externally sourced code
            // Purpose: Close the current form then instantiate and show another form.
            // Date: 16/11/2021
            // Source: stackoverflow
            // Author: nihique
            // url: https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
            // Adaptation required: change the Form class name and also considered changing var to Form since
            // I think here better not to use var.
            // Note: The simillar codes also reappered multiple times in other classes
            //==========================================
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Closed += (s, args) => this.Close();
            mainGameForm.Show();
            //==========================================
            // End reference A1
            //==========================================
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // catch exceptions if the player enters an invalid input into the goal score.
            try
            {
                goalScore = Convert.ToInt32(goalScoreTextBox.Text);
            }
            catch
            {
                MessageBox.Show(InGameText.goalScoreInputWarning);
                return;
            }
            if (goalScore < 50 || goalScore > 100)
            {
                MessageBox.Show(InGameText.goalScoreInputWarning);
                return;
            }

            this.Hide();
            isVsCPU = true;
            avatar2 = 10;
            player1Name = player1NameTextBox.Text;
            player2Name = "AI";
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Closed += (s, args) => this.Close();
            mainGameForm.Show();
        }

        private void avatar1Left_Click(object sender, EventArgs e)
        {
            // Loop within the avatar array.
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
