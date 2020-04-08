using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife {

    public partial class mainForm : Form {

        private const int ROWS = 100;
        private const int COLUMNS = 100;
        private int DENSITY = 10;
        private const int CELLWIDTH = 6;

        private Brush BRUSH = Brushes.Cyan;

        // Game stuff
        private GameOfLife game;
        private int generation;
        private bool pauseStatus;
        private List<bool[,]> gridStates = new List<bool[,]> ();

        public mainForm() {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void mainForm_Load(object sender, EventArgs e) {
            this.Size = new System.Drawing.Size(790, 660);
            restartButton.Text = "Start";
            densityLabel.Text = densitySlider.Value.ToString();
            pauseButton.Hide();
            //game = new GameOfLife(ROWS, COLUMNS, CELLWIDTH, DENSITY, BRUSH);
            //generation = 0;
            //spawnTimer.Start();

        }



        private void gridPictureBox_Paint(object sender, PaintEventArgs e) {
            if (game != null) {
                game.drawGrid(e.Graphics);
            }
            //g.DrawLine(System.Drawing.Pens.Red, gridPictureBox.Left, gridPictureBox.Top, gridPictureBox.Right, gridPictureBox.Bottom);
            //g.FillRectangle(System.Drawing.Brushes.Red, 10, 10, 100, 100);
        }

        private void spawnTimer_Tick(object sender, EventArgs e) {

            gridStates.Add((bool[,]) game.getGrid().Clone());

            // if state repeated
            if ( gridStates.Count >= 3 && game.gridStateEqualsTo(gridStates[gridStates.Count - 3]) || 
                    gridStates.Count >= 7 && game.gridStateEqualsTo(gridStates[gridStates.Count - 7]) ) {
                pauseGame();
                MessageBox.Show("Game's over");
            }
            else {
                generation++;
                game.swapToNewGeneration();
                generationLabel.Text = generation.ToString();
                Refresh();
            }

        }

        private void restartGame() {
            DENSITY = 21 - densitySlider.Value;
            game = new GameOfLife(ROWS, COLUMNS, CELLWIDTH, DENSITY, BRUSH);
            gridStates = new List<bool[,]>();
            generation = 0;
            pauseButton.Text = "Pause";
            pauseButton.Show();
            pauseStatus = false;
            spawnTimer.Start();
            Refresh();
        }

        private void pauseGame() {
            pauseStatus = !pauseStatus;
            if (pauseStatus) {
                spawnTimer.Stop();
                pauseButton.Text = "Start";
            }
            else {
                spawnTimer.Start();
                pauseButton.Text = "Pause";
            }
        }

        private void restartButton_Click(object sender, EventArgs e) {
            restartButton.Text = "Restart";
            restartGame();
        }

        private void pauseButton_Click(object sender, EventArgs e) {
            pauseGame();
        }

        private void densitySlider_Scroll(object sender, EventArgs e) {
            densityLabel.Text = densitySlider.Value.ToString();
        }
    }
}
