
namespace ShengenQiHaoLiuAssgt
{
    partial class MainGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            this.roll1 = new System.Windows.Forms.Button();
            this.roll2 = new System.Windows.Forms.Button();
            this.player1Text = new System.Windows.Forms.Label();
            this.player2Text = new System.Windows.Forms.Label();
            this.goalScore = new System.Windows.Forms.Label();
            this.commentText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.split2 = new System.Windows.Forms.Label();
            this.dicesPanel = new System.Windows.Forms.Panel();
            this.diceText = new System.Windows.Forms.Label();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.passDice1 = new System.Windows.Forms.Button();
            this.passDice2 = new System.Windows.Forms.Button();
            this.player1RunningScoreList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player2RunningScoreList = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.player1RunningScoreAggrLabel = new System.Windows.Forms.Label();
            this.player2RunningScoreAggrLabel = new System.Windows.Forms.Label();
            this.player1CumulativeScoreLabel = new System.Windows.Forms.Label();
            this.player2CumulativeScoreLabel = new System.Windows.Forms.Label();
            this.dicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roll1
            // 
            this.roll1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll1.Location = new System.Drawing.Point(100, 230);
            this.roll1.Name = "roll1";
            this.roll1.Size = new System.Drawing.Size(170, 53);
            this.roll1.TabIndex = 0;
            this.roll1.Text = "Roll!";
            this.roll1.UseVisualStyleBackColor = true;
            this.roll1.Click += new System.EventHandler(this.roll1_Click);
            // 
            // roll2
            // 
            this.roll2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roll2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll2.Location = new System.Drawing.Point(754, 230);
            this.roll2.Name = "roll2";
            this.roll2.Size = new System.Drawing.Size(170, 53);
            this.roll2.TabIndex = 1;
            this.roll2.Text = "Roll!";
            this.roll2.UseVisualStyleBackColor = true;
            this.roll2.Click += new System.EventHandler(this.roll2_Click);
            // 
            // player1Text
            // 
            this.player1Text.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Text.Location = new System.Drawing.Point(75, 75);
            this.player1Text.Name = "player1Text";
            this.player1Text.Size = new System.Drawing.Size(210, 23);
            this.player1Text.TabIndex = 3;
            this.player1Text.Text = "Player 1";
            this.player1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Text
            // 
            this.player2Text.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Text.Location = new System.Drawing.Point(724, 75);
            this.player2Text.Name = "player2Text";
            this.player2Text.Size = new System.Drawing.Size(210, 23);
            this.player2Text.TabIndex = 4;
            this.player2Text.Text = "Player 2";
            this.player2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalScore
            // 
            this.goalScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goalScore.AutoSize = true;
            this.goalScore.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalScore.Location = new System.Drawing.Point(405, 614);
            this.goalScore.Name = "goalScore";
            this.goalScore.Size = new System.Drawing.Size(216, 32);
            this.goalScore.TabIndex = 5;
            this.goalScore.Text = "Goal Score: 0";
            // 
            // commentText
            // 
            this.commentText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.commentText.AutoSize = true;
            this.commentText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentText.Location = new System.Drawing.Point(418, 666);
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(193, 18);
            this.commentText.TabIndex = 6;
            this.commentText.Text = "Player 1 Started Game";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-5, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 2);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Running Score";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Running Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cumulative Score";
            // 
            // split2
            // 
            this.split2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.split2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split2.Location = new System.Drawing.Point(510, 400);
            this.split2.Name = "split2";
            this.split2.Size = new System.Drawing.Size(2, 200);
            this.split2.TabIndex = 11;
            // 
            // dicesPanel
            // 
            this.dicesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dicesPanel.Controls.Add(this.diceText);
            this.dicesPanel.Controls.Add(this.dice2);
            this.dicesPanel.Controls.Add(this.dice1);
            this.dicesPanel.Location = new System.Drawing.Point(284, 190);
            this.dicesPanel.Name = "dicesPanel";
            this.dicesPanel.Size = new System.Drawing.Size(200, 114);
            this.dicesPanel.TabIndex = 14;
            // 
            // diceText
            // 
            this.diceText.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceText.Location = new System.Drawing.Point(14, 16);
            this.diceText.Name = "diceText";
            this.diceText.Size = new System.Drawing.Size(170, 20);
            this.diceText.TabIndex = 17;
            this.diceText.Text = "Waiting for action..";
            this.diceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dice2
            // 
            this.dice2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dice2.Image = global::ShengenQiHaoLiuAssgt.Properties.Resources.Dice1;
            this.dice2.Location = new System.Drawing.Point(105, 50);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(60, 60);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice2.TabIndex = 14;
            this.dice2.TabStop = false;
            // 
            // dice1
            // 
            this.dice1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dice1.Image = global::ShengenQiHaoLiuAssgt.Properties.Resources.Dice1;
            this.dice1.Location = new System.Drawing.Point(35, 50);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(60, 60);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice1.TabIndex = 13;
            this.dice1.TabStop = false;
            // 
            // passDice1
            // 
            this.passDice1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passDice1.Location = new System.Drawing.Point(133, 304);
            this.passDice1.Name = "passDice1";
            this.passDice1.Size = new System.Drawing.Size(100, 30);
            this.passDice1.TabIndex = 15;
            this.passDice1.Text = "Pass";
            this.passDice1.UseVisualStyleBackColor = true;
            this.passDice1.Click += new System.EventHandler(this.passDice1_Click);
            // 
            // passDice2
            // 
            this.passDice2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passDice2.Location = new System.Drawing.Point(792, 304);
            this.passDice2.Name = "passDice2";
            this.passDice2.Size = new System.Drawing.Size(100, 30);
            this.passDice2.TabIndex = 16;
            this.passDice2.Text = "Pass";
            this.passDice2.UseVisualStyleBackColor = true;
            this.passDice2.Click += new System.EventHandler(this.passDice2_Click);
            // 
            // player1RunningScoreList
            // 
            this.player1RunningScoreList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1RunningScoreList.Location = new System.Drawing.Point(129, 459);
            this.player1RunningScoreList.Name = "player1RunningScoreList";
            this.player1RunningScoreList.Size = new System.Drawing.Size(100, 100);
            this.player1RunningScoreList.TabIndex = 17;
            this.player1RunningScoreList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ShengenQiHaoLiuAssgt.Properties.Resources.diceIcon;
            this.pictureBox1.Location = new System.Drawing.Point(452, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // player2RunningScoreList
            // 
            this.player2RunningScoreList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2RunningScoreList.Location = new System.Drawing.Point(788, 459);
            this.player2RunningScoreList.Name = "player2RunningScoreList";
            this.player2RunningScoreList.Size = new System.Drawing.Size(100, 100);
            this.player2RunningScoreList.TabIndex = 19;
            this.player2RunningScoreList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-5, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1024, 2);
            this.label5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "latest throw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(935, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "latest throw";
            // 
            // player1RunningScoreAggrLabel
            // 
            this.player1RunningScoreAggrLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1RunningScoreAggrLabel.Location = new System.Drawing.Point(129, 406);
            this.player1RunningScoreAggrLabel.Name = "player1RunningScoreAggrLabel";
            this.player1RunningScoreAggrLabel.Size = new System.Drawing.Size(100, 38);
            this.player1RunningScoreAggrLabel.TabIndex = 23;
            this.player1RunningScoreAggrLabel.Text = "0";
            this.player1RunningScoreAggrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2RunningScoreAggrLabel
            // 
            this.player2RunningScoreAggrLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2RunningScoreAggrLabel.Location = new System.Drawing.Point(788, 406);
            this.player2RunningScoreAggrLabel.Name = "player2RunningScoreAggrLabel";
            this.player2RunningScoreAggrLabel.Size = new System.Drawing.Size(100, 38);
            this.player2RunningScoreAggrLabel.TabIndex = 24;
            this.player2RunningScoreAggrLabel.Text = "0";
            this.player2RunningScoreAggrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1CumulativeScoreLabel
            // 
            this.player1CumulativeScoreLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1CumulativeScoreLabel.Location = new System.Drawing.Point(404, 406);
            this.player1CumulativeScoreLabel.Name = "player1CumulativeScoreLabel";
            this.player1CumulativeScoreLabel.Size = new System.Drawing.Size(100, 38);
            this.player1CumulativeScoreLabel.TabIndex = 25;
            this.player1CumulativeScoreLabel.Text = "0";
            this.player1CumulativeScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2CumulativeScoreLabel
            // 
            this.player2CumulativeScoreLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2CumulativeScoreLabel.Location = new System.Drawing.Point(518, 406);
            this.player2CumulativeScoreLabel.Name = "player2CumulativeScoreLabel";
            this.player2CumulativeScoreLabel.Size = new System.Drawing.Size(100, 38);
            this.player2CumulativeScoreLabel.TabIndex = 26;
            this.player2CumulativeScoreLabel.Text = "0";
            this.player2CumulativeScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.player2CumulativeScoreLabel);
            this.Controls.Add(this.player1CumulativeScoreLabel);
            this.Controls.Add(this.player2RunningScoreAggrLabel);
            this.Controls.Add(this.player1RunningScoreAggrLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.player2RunningScoreList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player1RunningScoreList);
            this.Controls.Add(this.passDice2);
            this.Controls.Add(this.passDice1);
            this.Controls.Add(this.dicesPanel);
            this.Controls.Add(this.split2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentText);
            this.Controls.Add(this.goalScore);
            this.Controls.Add(this.player2Text);
            this.Controls.Add(this.player1Text);
            this.Controls.Add(this.roll2);
            this.Controls.Add(this.roll1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGameForm";
            this.Text = "Groan";
            this.dicesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll1;
        private System.Windows.Forms.Button roll2;
        private System.Windows.Forms.Label player1Text;
        private System.Windows.Forms.Label player2Text;
        private System.Windows.Forms.Label goalScore;
        private System.Windows.Forms.Label commentText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label split2;
        private System.Windows.Forms.Panel dicesPanel;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.Label diceText;
        private System.Windows.Forms.Button passDice1;
        private System.Windows.Forms.Button passDice2;
        private System.Windows.Forms.Label player1RunningScoreList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label player2RunningScoreList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label player1RunningScoreAggrLabel;
        private System.Windows.Forms.Label player2RunningScoreAggrLabel;
        private System.Windows.Forms.Label player1CumulativeScoreLabel;
        private System.Windows.Forms.Label player2CumulativeScoreLabel;
    }
}