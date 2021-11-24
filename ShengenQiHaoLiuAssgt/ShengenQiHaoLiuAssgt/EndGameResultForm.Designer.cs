
namespace ShengenQiHaoLiuAssgt
{
    partial class EndGameResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGameResultForm));
            this.newRoundButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player1Win = new System.Windows.Forms.Label();
            this.player2Win = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crownPic = new System.Windows.Forms.PictureBox();
            this.avatarPicBox1 = new System.Windows.Forms.PictureBox();
            this.avatarPicBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crownPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // newRoundButton
            // 
            this.newRoundButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRoundButton.Location = new System.Drawing.Point(87, 271);
            this.newRoundButton.Name = "newRoundButton";
            this.newRoundButton.Size = new System.Drawing.Size(222, 59);
            this.newRoundButton.TabIndex = 0;
            this.newRoundButton.Text = "Start Another Round!";
            this.newRoundButton.UseVisualStyleBackColor = true;
            this.newRoundButton.Click += new System.EventHandler(this.newRoundButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backButton.Location = new System.Drawing.Point(429, 271);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(222, 59);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back To Main Menu\r\n(This will clear win counts)";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // player1Name
            // 
            this.player1Name.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(69, 63);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(254, 23);
            this.player1Name.TabIndex = 2;
            this.player1Name.Text = "Player1";
            this.player1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Name
            // 
            this.player2Name.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(409, 63);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(254, 23);
            this.player2Name.TabIndex = 3;
            this.player2Name.Text = "Player2";
            this.player2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Win
            // 
            this.player1Win.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Win.Location = new System.Drawing.Point(168, 215);
            this.player1Win.Name = "player1Win";
            this.player1Win.Size = new System.Drawing.Size(50, 23);
            this.player1Win.TabIndex = 4;
            this.player1Win.Text = "0";
            this.player1Win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Win
            // 
            this.player2Win.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Win.Location = new System.Drawing.Point(514, 216);
            this.player2Win.Name = "player2Win";
            this.player2Win.Size = new System.Drawing.Size(50, 25);
            this.player2Win.TabIndex = 5;
            this.player2Win.Text = "0";
            this.player2Win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Wins:";
            // 
            // crownPic
            // 
            this.crownPic.BackColor = System.Drawing.Color.Transparent;
            this.crownPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.crownPic.Image = global::ShengenQiHaoLiuAssgt.Properties.Resources.cartoon_crown;
            this.crownPic.Location = new System.Drawing.Point(144, 12);
            this.crownPic.Name = "crownPic";
            this.crownPic.Size = new System.Drawing.Size(100, 50);
            this.crownPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crownPic.TabIndex = 7;
            this.crownPic.TabStop = false;
            // 
            // avatarPicBox1
            // 
            this.avatarPicBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.avatarPicBox1.Image = global::ShengenQiHaoLiuAssgt.Properties.Resources.a8;
            this.avatarPicBox1.Location = new System.Drawing.Point(144, 89);
            this.avatarPicBox1.Name = "avatarPicBox1";
            this.avatarPicBox1.Size = new System.Drawing.Size(100, 100);
            this.avatarPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPicBox1.TabIndex = 8;
            this.avatarPicBox1.TabStop = false;
            // 
            // avatarPicBox2
            // 
            this.avatarPicBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.avatarPicBox2.Image = global::ShengenQiHaoLiuAssgt.Properties.Resources.a8;
            this.avatarPicBox2.Location = new System.Drawing.Point(486, 89);
            this.avatarPicBox2.Name = "avatarPicBox2";
            this.avatarPicBox2.Size = new System.Drawing.Size(100, 100);
            this.avatarPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPicBox2.TabIndex = 9;
            this.avatarPicBox2.TabStop = false;
            // 
            // EndGameResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 361);
            this.Controls.Add(this.avatarPicBox2);
            this.Controls.Add(this.avatarPicBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2Win);
            this.Controls.Add(this.player1Win);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newRoundButton);
            this.Controls.Add(this.crownPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndGameResultForm";
            this.Text = "End Game Result";
            ((System.ComponentModel.ISupportInitialize)(this.crownPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRoundButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player1Win;
        private System.Windows.Forms.Label player2Win;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox crownPic;
        private System.Windows.Forms.PictureBox avatarPicBox1;
        private System.Windows.Forms.PictureBox avatarPicBox2;
    }
}