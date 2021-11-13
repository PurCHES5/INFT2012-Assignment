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
        public MainGameForm()
        {
            InitializeComponent();
        }

        private async void roll1_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 550);
            t.run();
            roll1.Enabled = false;
            roll2.Enabled = false;
            await Task.Delay(600);
            roll1.Enabled = true;
            roll2.Enabled = true;
        }

        private async void roll2_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dicesPanel, "Left", 300);
            t.run();
            roll1.Enabled = false;
            roll2.Enabled = false;
            await Task.Delay(600);
            roll1.Enabled = true;
            roll2.Enabled = true;
        }
    }
}
