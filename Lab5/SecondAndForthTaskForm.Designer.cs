namespace Lab5 {
    partial class SecondAndForthTaskForm {
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rBox = new System.Windows.Forms.NumericUpDown();
            this.gBox = new System.Windows.Forms.NumericUpDown();
            this.bBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repaintButton = new System.Windows.Forms.Button();
            this.freezeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dynamicRadiusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox.Location = new System.Drawing.Point(43, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(980, 703);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(82, 835);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(120, 31);
            this.rBox.TabIndex = 2;
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(235, 835);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(120, 31);
            this.gBox.TabIndex = 3;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(389, 835);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(120, 31);
            this.bBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 796);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "r";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 796);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 796);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "b";
            // 
            // repaintButton
            // 
            this.repaintButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.repaintButton.ForeColor = System.Drawing.SystemColors.Control;
            this.repaintButton.Location = new System.Drawing.Point(788, 810);
            this.repaintButton.Name = "repaintButton";
            this.repaintButton.Size = new System.Drawing.Size(166, 41);
            this.repaintButton.TabIndex = 8;
            this.repaintButton.Text = "repaint";
            this.repaintButton.UseVisualStyleBackColor = false;
            this.repaintButton.Click += new System.EventHandler(this.repaintButton_Click);
            // 
            // freezeButton
            // 
            this.freezeButton.Location = new System.Drawing.Point(590, 810);
            this.freezeButton.Name = "freezeButton";
            this.freezeButton.Size = new System.Drawing.Size(167, 41);
            this.freezeButton.TabIndex = 9;
            this.freezeButton.Text = "freeze";
            this.freezeButton.UseVisualStyleBackColor = true;
            this.freezeButton.Click += new System.EventHandler(this.freezeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dynamicRadiusButton
            // 
            this.dynamicRadiusButton.Location = new System.Drawing.Point(590, 861);
            this.dynamicRadiusButton.Name = "dynamicRadiusButton";
            this.dynamicRadiusButton.Size = new System.Drawing.Size(167, 40);
            this.dynamicRadiusButton.TabIndex = 10;
            this.dynamicRadiusButton.Text = "dynamic radius";
            this.dynamicRadiusButton.UseVisualStyleBackColor = true;
            this.dynamicRadiusButton.Click += new System.EventHandler(this.dynamicRadiusButton_Click);
            // 
            // SecondTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1070, 913);
            this.Controls.Add(this.dynamicRadiusButton);
            this.Controls.Add(this.freezeButton);
            this.Controls.Add(this.repaintButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "SecondTaskForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown rBox;
        private System.Windows.Forms.NumericUpDown gBox;
        private System.Windows.Forms.NumericUpDown bBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button repaintButton;
        private System.Windows.Forms.Button freezeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button dynamicRadiusButton;
    }
}