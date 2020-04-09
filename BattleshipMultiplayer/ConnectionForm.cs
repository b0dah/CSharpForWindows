using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipMultiplayer {
    public partial class ConnectionForm : Form {
        public ConnectionForm() {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e) {
            GameForm gameForm = new GameForm(false, ipTextBox.Text);
            Visible = false;

            if (!gameForm.IsDisposed)
                gameForm.ShowDialog();
            Visible = true;
        }

        private void hostButton_Click(object sender, EventArgs e) {
            GameForm gameForm = new GameForm(true, ipTextBox.Text);
            Visible = false;

            if (!gameForm.IsDisposed)
                gameForm.ShowDialog();
            Visible = true;
        }
    }
}
