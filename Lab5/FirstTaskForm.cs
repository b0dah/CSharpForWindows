using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5 {
    public partial class FirstTaskForm : Form {
        public FirstTaskForm() {
            InitializeComponent();

            this.Size = new System.Drawing.Size(600, 500);
        }

        private void redrawButton_Click(object sender, EventArgs e) {
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;

            var x = (int)xBox.Value;
            var y = (int)yBox.Value;
            var radius = (int)radiusBox.Value;

            //Rectangle rectangle = new Rectangle(new Point(x-radius, y-radius), );
            Rectangle rectangle = new Rectangle(new Point(x,y), new Size(2*radius, 2*radius));

            graphics.FillEllipse(Brushes.Cyan, rectangle);
        }
    }
}
