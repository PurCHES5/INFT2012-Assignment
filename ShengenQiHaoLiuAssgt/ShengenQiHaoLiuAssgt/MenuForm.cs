﻿using System;
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
    public partial class MenuForm : Form
    {
        public static string player1Name;
        public static string player2Name;

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
