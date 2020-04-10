namespace Lab5 {
    partial class ThirdTaskForm {
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.curvesCount = new System.Windows.Forms.NumericUpDown();
            this.beziesCount = new System.Windows.Forms.NumericUpDown();
            this.radiusBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curvesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beziesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox.Location = new System.Drawing.Point(43, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(980, 703);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // curvesCount
            // 
            this.curvesCount.Location = new System.Drawing.Point(82, 835);
            this.curvesCount.Name = "curvesCount";
            this.curvesCount.Size = new System.Drawing.Size(120, 31);
            this.curvesCount.TabIndex = 2;
            // 
            // beziesCount
            // 
            this.beziesCount.Location = new System.Drawing.Point(235, 835);
            this.beziesCount.Name = "beziesCount";
            this.beziesCount.Size = new System.Drawing.Size(120, 31);
            this.beziesCount.TabIndex = 3;
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(389, 835);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(120, 31);
            this.radiusBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 796);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Curves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 796);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bezies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 796);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.drawButton.ForeColor = System.Drawing.SystemColors.Control;
            this.drawButton.Location = new System.Drawing.Point(765, 829);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(258, 41);
            this.drawButton.TabIndex = 8;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.redrawButton_Click);
            // 
            // ThirdTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1070, 913);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiusBox);
            this.Controls.Add(this.beziesCount);
            this.Controls.Add(this.curvesCount);
            this.Controls.Add(this.pictureBox);
            this.Name = "ThirdTaskForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curvesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beziesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown curvesCount;
        private System.Windows.Forms.NumericUpDown beziesCount;
        private System.Windows.Forms.NumericUpDown radiusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawButton;
    }
}