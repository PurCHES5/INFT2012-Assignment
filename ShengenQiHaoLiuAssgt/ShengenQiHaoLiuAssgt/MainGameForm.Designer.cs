
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
            this.roll1 = new System.Windows.Forms.Button();
            this.roll2 = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
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
            this.dicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
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
            // history
            // 
            this.history.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(451, 119);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(130, 29);
            this.history.TabIndex = 2;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
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
            this.goalScore.Location = new System.Drawing.Point(395, 614);
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
            this.commentText.Location = new System.Drawing.Point(408, 667);
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
            this.split2.Size = new System.Drawing.Size(2, 115);
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
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
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
            this.Controls.Add(this.history);
            this.Controls.Add(this.roll2);
            this.Controls.Add(this.roll1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainGameForm";
            this.Text = "Groan";
            this.dicesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll1;
        private System.Windows.Forms.Button roll2;
        private System.Windows.Forms.Button history;
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
    }
}