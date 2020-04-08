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
            this.densitySlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.densityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridPictureBox.Location = new System.Drawing.Point(21, 74);
            this.gridPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(1195, 1100);
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
            this.restartButton.Location = new System.Drawing.Point(1311, 264);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(151, 108);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1311, 655);
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
            this.generationLabel.Location = new System.Drawing.Point(1310, 454);
            this.generationLabel.Name = "generationLabel";
            this.generationLabel.Size = new System.Drawing.Size(102, 116);
            this.generationLabel.TabIndex = 3;
            this.generationLabel.Text = "0";
            this.generationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // densitySlider
            // 
            this.densitySlider.Location = new System.Drawing.Point(1253, 107);
            this.densitySlider.Maximum = 20;
            this.densitySlider.Minimum = 1;
            this.densitySlider.Name = "densitySlider";
            this.densitySlider.Size = new System.Drawing.Size(209, 90);
            this.densitySlider.TabIndex = 4;
            this.densitySlider.TickFrequency = 2;
            this.densitySlider.Value = 10;
            this.densitySlider.Scroll += new System.EventHandler(this.densitySlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1290, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Density:";
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.densityLabel.Location = new System.Drawing.Point(1468, 107);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(29, 31);
            this.densityLabel.TabIndex = 6;
            this.densityLabel.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 1192);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.densitySlider);
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
            ((System.ComponentModel.ISupportInitialize)(this.densitySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.Timer spawnTimer;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label generationLabel;
        private System.Windows.Forms.TrackBar densitySlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label densityLabel;
    }
}

