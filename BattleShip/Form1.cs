using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleShip.Objects;
using BattleShip.Objects.Extensions;


namespace BattleShip {
    public partial class Form1 : Form {

        // LOGIC
        Player human;
        Player ai;

        // UI
        List<Label> gameBoardLabels = new List<Label>();
        List<Button> firingBoardButtons = new List<Button>();



        public Form1() {
            InitializeComponent();
            foreach (Control control in Controls) {
                if (control is Label && control != gameBoardLabel && control != gameProgressLabel && control != enemysBoardLabel) {                   
                    //control.BackColor = Color.Red;
                    control.Text = control.Name[1].ToString();
                    gameBoardLabels.Add((Label)control);
                }
                else if (control is Button) {
                    Button button = (Button)control;
                    button.Text = button.Name[1].ToString();
                    button.Click += new EventHandler(boardCellClicked);
                    firingBoardButtons.Add((Button)control);
                }
            }

            // CONSTRUCT THE GAME
            human = new Player("Human");
            ai = new Player("ai");

            human.PlaceShips();
            ai.PlaceShips();

            drawBoard(human.GameBoard, gameBoardLabels);

           
        }

        private void boardCellClicked(object sender, EventArgs e) {
            
            Button clickedButton = (Button)sender;

            try {
                int row = int.Parse(clickedButton.Name[1].ToString()) + 1;
                int column = int.Parse(clickedButton.Name[2].ToString()) + 1;
                gameProgressLabel.Text = "Clicked: " + row.ToString() + " " + column.ToString();
            } 
            catch {
                gameProgressLabel.Text = "Error. Wrong Coordinates!";
            }
        }

        private void updateBoards(GameBoard gameBoard, FiringBoard firingBoard) {
            //foreach 
        }

        private void drawBoard(GameBoard gameBoard, List<Label> labels) {
            try {
                foreach (var label in labels) {
                    int row = int.Parse(label.Name[1].ToString()) + 1;
                    int column = int.Parse(label.Name[2].ToString()) + 1;

                    char symbol = (char)gameBoard.Cells.At(row, column).OccupationType;
                    label.Text = symbol.ToString();
                }
            }
            catch {
                gameProgressLabel.Text = "Error! Wrong coords";
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Size = new System.Drawing.Size(1000, 600);
        }

        private void gameBoard_Click(object sender, EventArgs e) {

        }

        private void button42_Click(object sender, EventArgs e) {

        }

        private void button41_Click(object sender, EventArgs e) {

        }

        private void button43_Click(object sender, EventArgs e) {

        }

        private void button44_Click(object sender, EventArgs e) {

        }

        private void button45_Click(object sender, EventArgs e) {

        }

        private void button46_Click(object sender, EventArgs e) {

        }

        private void button47_Click(object sender, EventArgs e) {

        }

        private void button48_Click(object sender, EventArgs e) {

        }

        private void button49_Click(object sender, EventArgs e) {

        }

        private void button50_Click(object sender, EventArgs e) {

        }

        private void button9_Click(object sender, EventArgs e) {

        }
    }
}
