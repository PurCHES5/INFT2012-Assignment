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

        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            player1Name = player1NameTextBox.Text;
            player2Name = player2NameTextBox.Text;
            goalScore = Convert.ToInt32(goalScoreTextBox.Text);
            MainGameForm mainGameForm = new MainGameForm();
            mainGameForm.Closed += (s, args) => this.Close();
            mainGameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainGameForm mainGameForm = new MainGameForm();
            //mainGameForm.Show();
        }
    }
}

//https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
