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
                else if (control is Button && control != playAgainButton) {
                    Button button = (Button)control;
                    button.Text = button.Name[1].ToString();
                    button.Click += new EventHandler(boardCellClicked);
                    firingBoardButtons.Add((Button)control);
                }
            }

            initializeGame();
        }

        private void initializeGame() {
            gameProgressLabel.ForeColor = Color.Black;
            gameProgressLabel.Text = "The game is started";
            playAgainButton.Hide();

            // CONSTRUCT THE GAME
            human = new Player("Human");
            ai = new Player("ai");

            human.PlaceShips();
            ai.PlaceShips();

            drawGameBoard(human.GameBoard, gameBoardLabels);
            drawFiringBoard(human.FiringBoard, firingBoardButtons);
        }

        private void finishGame() {
            foreach (var button in firingBoardButtons) {
                button.Enabled = false;
            }
            playAgainButton.Show();
        }

        private void boardCellClicked(object sender, EventArgs e) {
            
            Button clickedButton = (Button)sender;

            try {
                int row = int.Parse(clickedButton.Name[1].ToString()) + 1;
                int column = int.Parse(clickedButton.Name[2].ToString()) + 1;
                //gameProgressLabel.Text = "Clicked: " + row.ToString() + " " + column.ToString();

                // HUMAN'S TURN
                var humanShotCoordinates = new Coordinates(row, column);
                var result = ai.ProcessShot(humanShotCoordinates);
                human.ProcessShotResult(humanShotCoordinates, result);

                switch (result) {
                    case ShotResult.Miss:
                        gameProgressLabel.Text = "Miss ...";
                        break;
                    default:
                        gameProgressLabel.Text = "Hit!";
                        break;
                }

                redrawFiringBoard(humanShotCoordinates, result, firingBoardButtons);

                // AI'S TURN
                if (!ai.HasLost) {
                    var aiShotCoordinates = ai.FireShot();
                    result = human.ProcessShot(aiShotCoordinates);
                    ai.ProcessShotResult(aiShotCoordinates, result);
                    redrawGameBoard(aiShotCoordinates, result, gameBoardLabels);

                    if (human.HasLost) {
                        gameProgressLabel.ForeColor = Color.IndianRed;
                        gameProgressLabel.Text = "You lost ... Good Luck next time";
                        finishGame();
                    }
                } 
                else {
                    gameProgressLabel.ForeColor = Color.Yellow;
                    gameProgressLabel.Text = "You won !!!";
                    finishGame();
                }
            } 
            catch {
                gameProgressLabel.Text = "Error. Wrong Coordinates!";
            }
        }

        private void redrawGameBoard(Coordinates lastShot, ShotResult shotResult, List<Label> labels) {

            try {
                var firedCellLabelName = "G" + (lastShot.row - 1).ToString() + (lastShot.column - 1).ToString();
                var firedCellLabel = gameBoardLabels.Where(x => x.Name == firedCellLabelName).First();
                firedCellLabel.Text = ((char)shotResult).ToString();

                switch (shotResult) {
                    case ShotResult.Miss:
                        firedCellLabel.BackColor = Color.LightYellow;
                        break;
                    case ShotResult.Hit:
                        firedCellLabel.BackColor = Color.DarkRed;
                        break;
                }
            }
            catch {
                gameProgressLabel.Text = "Error. Wrong Coordinates!";
            }
        }

        private void redrawFiringBoard(Coordinates lastShot, ShotResult shotResult, List<Button> buttons) {

            try {
                var firedCellButtonName = "F" + (lastShot.row - 1).ToString() + (lastShot.column - 1).ToString();
                var firedCellButton = buttons.Where(x => x.Name == firedCellButtonName).First();
                firedCellButton.Text = ((char)shotResult).ToString();
                
                switch (shotResult) {
                    case ShotResult.Miss:
                        firedCellButton.BackColor = Color.LightYellow;
                        break;
                    case ShotResult.Hit:
                        firedCellButton.BackColor = Color.DarkRed;
                        break;
                }
            }
            catch {
                gameProgressLabel.Text = "Error. Wrong Coordinates!";
            }
        }

        private void drawGameBoard(GameBoard gameBoard, List<Label> labels) {
            try {
                foreach (var label in labels) {
                    int row = int.Parse(label.Name[1].ToString()) + 1;
                    int column = int.Parse(label.Name[2].ToString()) + 1;

                    char symbol = (char)gameBoard.Cells.At(row, column).OccupationType;
                    label.Text = symbol.ToString();

                    switch (symbol) {
                        case 'B':
                            label.BackColor = Color.DarkGreen;
                            break;
                        case 'C':
                            label.BackColor = Color.Orange;
                            break;
                        case 'D':
                            label.BackColor = Color.OrangeRed;
                            break;
                        case 'S':
                            label.BackColor = Color.Yellow;
                            break;
                        case 'A':
                            label.BackColor = Color.Red;
                            break;

                        case 'M':
                            label.BackColor = Color.DarkGray;
                            break;
                        case 'X':
                            label.BackColor = Color.Black;
                            break;

                        default:
                            label.BackColor = Color.White;
                            break;


                    }
                }
            }
            catch {
                gameProgressLabel.Text = "Error. Wrong Coordinates!";
            }
        }

        private void drawFiringBoard(GameBoard gameBoard, List<Button> buttons) {
            try {
                foreach (var button in buttons) {
                    int row = int.Parse(button.Name[1].ToString()) + 1;
                    int column = int.Parse(button.Name[2].ToString()) + 1;

                    char symbol = (char)gameBoard.Cells.At(row, column).OccupationType;
                    button.Text = symbol.ToString();

                    switch (symbol) {
                        case 'B':
                            button.BackColor = Color.DarkGreen;
                            break;
                        case 'C':
                            button.BackColor = Color.Orange;
                            break;
                        case 'D':
                            button.BackColor = Color.OrangeRed;
                            break;
                        case 'S':
                            button.BackColor = Color.Yellow;
                            break;
                        case 'A':
                            button.BackColor = Color.Red;
                            break;

                        case 'M':
                            button.BackColor = Color.DarkGray;
                            break;
                        case 'X':
                            button.BackColor = Color.Red;
                            break;

                        default:
                            button.BackColor = Color.White;
                            break;

                    }
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

        private void gameProgressLabel_Click(object sender, EventArgs e) {

        }

        private void playAgainButton_Click(object sender, EventArgs e) {
            initializeGame();
        }
    }
}
