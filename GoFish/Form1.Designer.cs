namespace GoFish
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.listHand = new System.Windows.Forms.ListBox();
            this.askForCard = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Hand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game Progress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Books";
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(15, 316);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(327, 127);
            this.textBooks.TabIndex = 4;
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(15, 114);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(327, 167);
            this.textProgress.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(160, 20);
            this.textName.TabIndex = 7;
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(359, 51);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(163, 355);
            this.listHand.TabIndex = 8;
            // 
            // askForCard
            // 
            this.askForCard.Location = new System.Drawing.Point(359, 420);
            this.askForCard.Name = "askForCard";
            this.askForCard.Size = new System.Drawing.Size(163, 23);
            this.askForCard.TabIndex = 9;
            this.askForCard.Text = "Ask for a card";
            this.askForCard.UseVisualStyleBackColor = true;
            this.askForCard.Click += new System.EventHandler(this.askForCard_Click);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(198, 49);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(144, 23);
            this.startGame.TabIndex = 10;
            this.startGame.Text = "Start the Game!";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 475);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.askForCard);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Button askForCard;
        private System.Windows.Forms.Button startGame;
    }
}

