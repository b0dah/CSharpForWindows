namespace GameOfLife {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridPictureBox = new System.Windows.Forms.PictureBox();
            this.spawnTimer = new System.Windows.Forms.Timer(this.components);
            this.restartButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.generationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridPictureBox.Location = new System.Drawing.Point(21, 74);
            this.gridPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(1169, 1100);
            this.gridPictureBox.TabIndex = 0;
            this.gridPictureBox.TabStop = false;
            this.gridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPictureBox_Paint);
            // 
            // spawnTimer
            // 
            this.spawnTimer.Tick += new System.EventHandler(this.spawnTimer_Tick);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(1270, 264);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(151, 108);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1270, 655);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(151, 100);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseCompatibleTextRendering = true;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // generationLabel
            // 
            this.generationLabel.AutoSize = true;
            this.generationLabel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generationLabel.Location = new System.Drawing.Point(1269, 454);
            this.generationLabel.Name = "generationLabel";
            this.generationLabel.Size = new System.Drawing.Size(102, 116);
            this.generationLabel.TabIndex = 3;
            this.generationLabel.Text = "0";
            this.generationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 1192);
            this.Controls.Add(this.generationLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.gridPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Game of Life by Vanusick";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.Timer spawnTimer;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label generationLabel;
    }
}

