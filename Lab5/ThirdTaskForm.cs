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
    public partial class ThirdTaskForm : Form {

        private Pen[] pens = { Pens.Fuchsia, Pens.Black, Pens.Magenta, Pens.CadetBlue };
        private int rightBound;
        private int bottomBound;



        public ThirdTaskForm() {
            InitializeComponent();

            this.Size = new System.Drawing.Size(600, 500);

            rightBound = pictureBox.Width;
            bottomBound = pictureBox.Height;

        }

        private void redrawButton_Click(object sender, EventArgs e) {
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;

            var curves = (int)curvesCount.Value;
            var bezies = (int)beziesCount.Value;
            var circles = (int)radiusBox.Value;

            Random random = new Random(Guid.NewGuid().GetHashCode());

            // Arcs
            for (var i=0; i<curves; i++) {
                var pen = pens[random.Next(pens.Length)];

                var x = random.Next(rightBound) + 1;
                var width = random.Next(rightBound - x) + 1; 
                var startAngle = random.Next(180) + 1;

                var y = random.Next(bottomBound) + 1; 
                var height = random.Next(bottomBound - y) + 1;
                var sweepAngle = random.Next(180) + 1;

                graphics.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
            }

            // Beziers
            for (var i = 0; i < bezies; i++) {
                var pen = Pens.Red;

                var first = new Point(random.Next(rightBound) + 1,  random.Next(bottomBound) + 1);
                var second = new Point(random.Next(rightBound) + 1,  random.Next(bottomBound) + 1);
                var third = new Point(random.Next(rightBound) + 1,  random.Next(bottomBound) + 1);
                var forth = new Point(random.Next(rightBound) + 1, random.Next(bottomBound) + 1);

                graphics.DrawBezier(pen, first, second, third, forth);
            }

            // Circles
            for (var i = 0; i < circles; i++) {
                var pen = pens[random.Next(pens.Length)];

                var x = random.Next(rightBound) + 1;
                var width = random.Next(rightBound - x) + 1;

                var y = random.Next(bottomBound) + 1;
                var height = random.Next(bottomBound - y) + 1;

                graphics.DrawEllipse(pen, x, y, width, height);
            }


        }
    }
}
