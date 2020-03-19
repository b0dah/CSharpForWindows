using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool humanIsActivePlayer = true; // true means "human"
        Button[] boardButtons;
        //List<String> board = new List<String>() { "O", "1", "X", "X", "4", "X", "6", "O", "O" };
        Game game;

        public Form1()
        {
            InitializeComponent();
            boardButtons = new Button[] { b0, b1, b2, b3, b4, b5, b6, b7, b8 };
            game = new Game();
        }

        public void PlayAgainButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Played Again!");
            //label1.Text = "Played Again!";

            game = new Game();
            winnerLabel.Text = "";

            try {
                foreach (Control control in Controls) {
                    if (control is Button && control.Name != "PlayAgainButton") {
                        Button button = (Button)control;
                        button.Enabled = true;
                        button.Text = "";
                    }
                }
            }
            catch {
            }
          
        }

        private void boardCellClicked(object sender, EventArgs e) {
            Button clickedButton = (Button)sender;

            clickedButton.Text = "X";
            clickedButton.Enabled = false;

            String clickedButtonName = clickedButton.Name;
            int clickedCellIndex = int.Parse(clickedButtonName.Substring(clickedButtonName.Length-1));

            Console.WriteLine("Clicked : " + clickedCellIndex.ToString());

            Tuple<GameResult, int> moveResult = game.move(clickedCellIndex);
            GameResult gameState = moveResult.Item1;
            int aiMovedToIndex = moveResult.Item2;

            switch (gameState) {
                case GameResult.humanWon:
                    winnerLabel.Text = "YOU WON!";
                    disableAllButtons();
                    break;
                case GameResult.tie:
                    // visual move to aimoved ...
                    if (aiMovedToIndex != -1) takeTheCell(aiMovedToIndex, "O");
                    winnerLabel.Text = "THAT'S A TIE!";
                    disableAllButtons();
                    break;
                case GameResult.aiWon:
                    // visual move to aimoved ...
                    winnerLabel.ForeColor = Color.LightSalmon;
                    winnerLabel.Text = "U LOST!";
                    if (aiMovedToIndex != -1) takeTheCell(aiMovedToIndex, "O");
                    disableAllButtons();
                    break;
                default:
                    // visual move to aimoved ...
                    if (aiMovedToIndex != -1) takeTheCell(aiMovedToIndex, "O");
                    break;
            }

        }

        private void takeTheCell(int index, String symbol) {
            boardButtons[index].Text = "O";
            boardButtons[index].Enabled = false;
        }

        private void disableAllButtons() {
            try {
                foreach (Control control in Controls) {
                    if (control is Button && control.Name != "PlayAgainButton") {
                        Button button = (Button)control;
                        button.Enabled = false;
                    }
                }
            }
            catch {
            }
        }
    }
}
