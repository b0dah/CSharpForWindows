namespace BattleshipMultiplayer {
    partial class ConnectionForm {
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
            this.connectGroupBox = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hostButton = new System.Windows.Forms.Button();
            this.connectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectGroupBox
            // 
            this.connectGroupBox.Controls.Add(this.connectButton);
            this.connectGroupBox.Controls.Add(this.ipTextBox);
            this.connectGroupBox.Controls.Add(this.label1);
            this.connectGroupBox.Location = new System.Drawing.Point(21, 31);
            this.connectGroupBox.Name = "connectGroupBox";
            this.connectGroupBox.Size = new System.Drawing.Size(560, 117);
            this.connectGroupBox.TabIndex = 0;
            this.connectGroupBox.TabStop = false;
            this.connectGroupBox.Text = "Connect to the Game";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(418, 39);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(136, 45);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(76, 46);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(326, 31);
            this.ipTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // hostButton
            // 
            this.hostButton.Location = new System.Drawing.Point(21, 173);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(560, 72);
            this.hostButton.TabIndex = 1;
            this.hostButton.Text = "Host a Game";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 257);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.connectGroupBox);
            this.Name = "ConnectionForm";
            this.Text = "BattleShip Multiplayer";
            this.connectGroupBox.ResumeLayout(false);
            this.connectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectGroupBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hostButton;
    }
}

