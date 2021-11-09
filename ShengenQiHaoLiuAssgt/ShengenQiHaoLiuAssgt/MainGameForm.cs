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

        private void roll1_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(dice1, "Left", 610);
            t.add(dice2, "Left", 680);
            t.run();
        }

        private void roll2_Click(object sender, EventArgs e)
        {

        }
    }
}
