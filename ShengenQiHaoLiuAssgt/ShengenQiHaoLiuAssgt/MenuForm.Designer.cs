
namespace ShengenQiHaoLiuAssgt
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.goalScoreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 130);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "1 vs 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 130);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Singleplayer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.goalScoreTextBox);
            this.panel1.Controls.Add(this.player2NameTextBox);
            this.panel1.Controls.Add(this.player1NameTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 397);
            this.panel1.TabIndex = 0;
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameTextBox.Location = new System.Drawing.Point(474, 90);
            this.player2NameTextBox.MaxLength = 12;
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(150, 27);
            this.player2NameTextBox.TabIndex = 3;
            this.player2NameTextBox.Text = "Player2";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameTextBox.Location = new System.Drawing.Point(84, 90);
            this.player1NameTextBox.MaxLength = 12;
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(150, 27);
            this.player1NameTextBox.TabIndex = 2;
            this.player1NameTextBox.Text = "Player1";
            // 
            // goalScoreTextBox
            // 
            this.goalScoreTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalScoreTextBox.Location = new System.Drawing.Point(389, 163);
            this.goalScoreTextBox.MaxLength = 3;
            this.goalScoreTextBox.Name = "goalScoreTextBox";
            this.goalScoreTextBox.Size = new System.Drawing.Size(50, 27);
            this.goalScoreTextBox.TabIndex = 4;
            this.goalScoreTextBox.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Goal Score:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 398);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Groan Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goalScoreTextBox;
    }
}

