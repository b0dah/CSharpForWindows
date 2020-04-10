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

using System.Net.Sockets;


namespace BattleshipMultiplayer {
    public partial class GameForm : Form {

        private const int PORT = 8888;

        // LOGIC
        Player player;

        // UI
        List<Label> gameBoardLabels = new List<Label>();
        List<Button> firingBoardButtons = new List<Button>();

        // Connection
        private Socket socket;
        private BackgroundWorker messageReceiver = new BackgroundWorker();

        private BackgroundWorker moveResultMessageReceiver = new BackgroundWorker();

        private TcpListener server = null;
        private TcpClient client;

        public GameForm(bool isHost, string ip) {
            InitializeComponent();

            foreach (Control control in Controls) {
                if (control is Label && control != gameBoardLabel && control != gameProgressLabel && control != enemysBoardLabel && control != turnLabel && control != serverOrClientLabel) {                   
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

            // connection
            messageReceiver.DoWork += MessageReceiver_DoWork;
            //CheckForIllegalCrossThreadCalls = false;

            moveResultMessageReceiver.DoWork += MoveResultMessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost) {
                server = new TcpListener(System.Net.IPAddress.Any, PORT);
                server.Start();
                socket = server.AcceptSocket();
                serverOrClientLabel.Text = "Server";
            } 
            else {
                try {
                    client = new TcpClient(ip, PORT);
                    socket = client.Client;
                    messageReceiver.RunWorkerAsync();
                    serverOrClientLabel.Text = "Client";
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                    Close();
                }

            }

        }




        // CONNECTION
        private void MoveResultMessageReceiver_DoWork(object sender, DoWorkEventArgs e) {
            byte[] bufferToReceive = new byte[4];
            socket.Receive(bufferToReceive);

            int row = bufferToReceive[0];
            int column = bufferToReceive[1];
            ShotResult resultGotten = (bufferToReceive[2] == 1) ? ShotResult.Hit : ShotResult.Miss;
            bool enemyHasLost = (bufferToReceive[3] == 1);

            redrawFiringBoard(new Coordinates(row, column), resultGotten, firingBoardButtons);

            if (enemyHasLost) {
                gameProgressLabel.ForeColor = Color.Yellow;
                gameProgressLabel.Text = "You won !!!";
                finishGame();
            }
        }
    
        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e) {
            freezeFiringBoard();
            turnLabel.Text = "Opponent's\n turn!";

            receiveMove();
            turnLabel.Text = "Your turn";
            unfreezeFiringBoard();
        }

        private void receiveMove() {
            byte[] buffer = new byte[2];
            socket.Receive(buffer);

            gameProgressLabel.Text = "Opponent shot at : " + buffer[0].ToString() + ":" + buffer[1].ToString();

            // Process shot
            Coordinates opponentsShotCoordinates = new Coordinates(buffer[0], buffer[1]);
            var shotResult = player.ProcessShot(opponentsShotCoordinates);
            redrawGameBoard(opponentsShotCoordinates, shotResult, gameBoardLabels);

            // Send Shot result
            var row = buffer[0];
            var column = buffer[1];
            var playerHit = (shotResult == ShotResult.Hit) ? (byte)1 : (byte)0;
            var playerHasLost = (player.HasLost) ? (byte)1 : (byte)0;

            byte[] bufferToSend = { row, column, playerHit, playerHasLost };
            socket.Send(bufferToSend);
            moveResultMessageReceiver.RunWorkerAsync();

            if (player.HasLost) {
                gameProgressLabel.ForeColor = Color.IndianRed;
                gameProgressLabel.Text = "You lost ... Good Luck next time";
                finishGame();
            }
        }











        private void initializeGame() {
            foreach (var button in firingBoardButtons) {
                button.Enabled = true;
            }

            gameProgressLabel.ForeColor = Color.Black;
            gameProgressLabel.Text = "The game is started";
            playAgainButton.Hide();

            // CONSTRUCT THE GAME
            player = new Player("Human");

            player.PlaceShips();

            drawGameBoard(player.GameBoard, gameBoardLabels);
            drawFiringBoard(player.FiringBoard, firingBoardButtons);
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

                byte[] coordinatesToSend = {(byte)row, (byte)column };
                socket.Send(coordinatesToSend);
                messageReceiver.RunWorkerAsync();
            } 
            catch {
                gameProgressLabel.Text = "Error. Wrong Coordinates! from clicked cell";
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

        public void freezeFiringBoard() {
            foreach (var button in firingBoardButtons) {
                button.Enabled = false;
            }
        }

        public void unfreezeFiringBoard() {
            foreach (var button in firingBoardButtons) {
                if (button.Text != "X" || button.Text != "M") {
                    button.Enabled = true;
                }
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

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e) {
            messageReceiver.WorkerSupportsCancellation = true;
            messageReceiver.CancelAsync();

            if (server != null) {
                server.Stop(); 
            }
        }
    }
}
