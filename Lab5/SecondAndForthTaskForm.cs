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
    public partial class SecondTaskForm : Form {

        private Color color;
        private int delta = 1;
        private int radiusDelta = 5;

        private int x = 0;
        private int y = 0;
        private int radius = 30;
        private const int maxRadius = 100;
        private const int minRadius = 10;

        private bool dynamicRadius = false;
        private bool increasingRadiusMode = true;


        public SecondTaskForm() {
            InitializeComponent();

            this.Size = new System.Drawing.Size(600, 500);
        }

        private void redrawButton_Click(object sender, EventArgs e) {
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;

            //Rectangle rectangle = new Rectangle(new Point(x-radius, y-radius), );
            Rectangle rectangle = new Rectangle(new Point(x,y), new Size(2*radius, 2*radius));

            graphics.DrawEllipse(new Pen(color), rectangle);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            x += 2*delta;
            y += 2* delta;

            if (dynamicRadius) {
                if (increasingRadiusMode) {
                    radius += radiusDelta;
                    if (radius >= maxRadius)
                        increasingRadiusMode = false;
                }
                else {
                    radius -= radiusDelta;
                    if (radius <= minRadius)
                        increasingRadiusMode = true;
                }
            }
            pictureBox.Refresh();

        }

        private void repaintButton_Click(object sender, EventArgs e) {
            var r = (int)rBox.Value;
            var g = (int)gBox.Value;
            var b = (int)bBox.Value;

            color = Color.FromArgb(r, g, b);
            pictureBox.Refresh();
        }

        private void freezeButton_Click(object sender, EventArgs e) {
            if (timer1.Enabled) {
                timer1.Stop();
            } 
            else {
                timer1.Start();
            }
        }

        private void dynamicRadiusButton_Click(object sender, EventArgs e) {
            dynamicRadius = !dynamicRadius;
        }
    }
}
