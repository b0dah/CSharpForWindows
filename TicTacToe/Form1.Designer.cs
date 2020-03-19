namespace TicTacToe
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
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.Teal;
            this.PlayAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgainButton.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PlayAgainButton.Location = new System.Drawing.Point(305, 662);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(370, 96);
            this.PlayAgainButton.TabIndex = 0;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(23, 94);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(150, 150);
            this.b0.TabIndex = 2;
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(198, 94);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(150, 150);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(373, 94);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(150, 150);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(198, 293);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(150, 150);
            this.b4.TabIndex = 5;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(23, 293);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(150, 150);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(23, 489);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(150, 150);
            this.b6.TabIndex = 7;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(198, 489);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(150, 150);
            this.b7.TabIndex = 8;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(373, 293);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(150, 150);
            this.b5.TabIndex = 9;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Verdana", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(373, 489);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(150, 150);
            this.b8.TabIndex = 10;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.boardCellClicked);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.winnerLabel.Location = new System.Drawing.Point(16, 9);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 59);
            this.winnerLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 829);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayAgainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Label winnerLabel;
    }
}

