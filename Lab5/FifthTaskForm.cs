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
    public partial class FifthTaskForm : Form {

        enum CircleMovingMode {
            ordinary, 
            mirror,
            controlledByKeyBoard,
        }

        private int x = 100;
        private int y = 100;
        private int radius = 80;

        private Point screenCenter;
        private Point mouseLocationPoint;

        private Point circleLeftCornerPoint;
        private Rectangle rectangle;

        private int movingByKeyboardControlStep = 10;

        private CircleMovingMode MODE = CircleMovingMode.ordinary;


        public FifthTaskForm() {
            InitializeComponent();

            this.Size = new System.Drawing.Size(600, 500);
            screenCenter = new Point(pictureBox.Width/2, pictureBox.Height/2);
        }

        private void redrawButton_Click(object sender, EventArgs e) {
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;

            switch (MODE) {
                case CircleMovingMode.mirror:
                    var mouseMovedFromCenterDeltaX = mouseLocationPoint.X - screenCenter.X;
                    var mouseMovedFromCenterDeltaY = mouseLocationPoint.Y - screenCenter.Y;
                    circleLeftCornerPoint = new Point(screenCenter.X - mouseMovedFromCenterDeltaX, screenCenter.Y - mouseMovedFromCenterDeltaY);
                    break;

                case CircleMovingMode.controlledByKeyBoard:
                    break;

                default:
                    circleLeftCornerPoint = new Point(mouseLocationPoint.X - radius, mouseLocationPoint.Y - radius); ;
                    break;
            }

            rectangle = new Rectangle(circleLeftCornerPoint, new Size(2 * radius, 2 * radius));

            graphics.FillEllipse(Brushes.Cyan, rectangle);

            if (MODE == CircleMovingMode.controlledByKeyBoard)
                MODE = CircleMovingMode.ordinary;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
            mouseLocationPoint = new Point(e.Location.X, e.Location.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e) {
            if (MODE == CircleMovingMode.ordinary)
                MODE = CircleMovingMode.mirror;
            else
                MODE = CircleMovingMode.ordinary;
        }

        private void FifthTaskForm_KeyUp(object sender, KeyEventArgs e) {
            MODE = CircleMovingMode.controlledByKeyBoard;
            if (e.KeyCode == Keys.Up) circleLeftCornerPoint.Y -= movingByKeyboardControlStep;
            if (e.KeyCode == Keys.Right) circleLeftCornerPoint.X += movingByKeyboardControlStep;
            if (e.KeyCode == Keys.Down) circleLeftCornerPoint.Y += movingByKeyboardControlStep;
            if (e.KeyCode == Keys.Left) circleLeftCornerPoint.X -= movingByKeyboardControlStep;

            pictureBox.Refresh();
        }
    }
}
