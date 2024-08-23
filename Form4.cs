using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace battleShip
{
    public partial class frmBattle : Form
    {
        private System.Windows.Forms.Timer gameTimer; // Timer 
        private int elapsedTime; // Variable time in seconds
        private Label lblTimer;
        private GameData gameData; // Contains the data
        private List<string> player1Figures;
        private List<string> player2Figures;
        private Button[,] player2Buttons; // Set of buttons representing the player 2 board
        private Button[,] player1Buttons; // Set of buttons representing the player 1 board
        private bool isPlayer1Turn = true; // Turn
        private HashSet<string> player1AttackedPositions = new HashSet<string>(); //Does not perform duplicate attacks
        private HashSet<string> player2AttackedPositions = new HashSet<string>(); //Ddoes not perform duplicate attacks

        public frmBattle(GameData gameData)
        {
            InitializeComponent();
            this.gameData = gameData; // Assign the game data
            InitializeBattleBoards(); // Initialize game boards
            ShowPlayerBoard(); // Show the appropriate player board
            player1Figures = gameData.Player1Figures; // Place player 1's ship positions
            player2Figures = gameData.Player2Figures; // Place player 2's ship positions
            InitializeGameTimer(); // Initialize and start the game timer
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_KeyDown);
            InitializeExitAndPlayAgainButtons();
        }
        #region Methods
        private void InitializeGameTimer()
        {
            // Set up the game timer
            gameTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // Timer interval set to 1 second
            };
            gameTimer.Tick += GameTimer_Tick;
            // Initialize the elapsed time and the timer label
            elapsedTime = 0;
            lblTimer = new Label
            {
                BackColor = Color.Transparent,
                Location = new Point(10, 10),
                Size = new Size(100, 30),
                Font = new Font("Algerian", 12, FontStyle.Bold),
                Text = "Tiempo: 0s"
            };
            this.Controls.Add(lblTimer);
            gameTimer.Start();
        }
        private void InitializeBattleBoards()
        {
            // Set up the battle boards for both players
            InitializeTableLayoutPanel(tableLayoutPanelPlayer1, out player1Buttons);
            InitializeTableLayoutPanel(tableLayoutPanelPlayer2, out player2Buttons);
            tableLayoutPanelPlayer1.Visible = false; // Hide player 1's board at the start
        }
        private void InitializeTableLayoutPanel(TableLayoutPanel panel, out Button[,] buttons)
        {
            panel.ColumnCount = 5;
            panel.RowCount = 5;
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // Set column and row styles to fill the panel space evenly
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // 20% width for each column
            }
            for (int i = 0; i < panel.RowCount; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // 20% height for each row
            }
            string[] rows = { "A", "B", "C", "D", "E" };
            int[] columns = { 1, 2, 3, 4, 5 };
            panel.Controls.Clear();
            buttons = new Button[rows.Length, columns.Length]; // Create the button array
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    Button button = new Button
                    {
                        Text = $"{rows[i]}{columns[j]}",
                        BackColor = Color.LightGray,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0)
                    };
                    panel.Controls.Add(button, j, i); // Add button to panel
                    buttons[i, j] = button; // Store button in the array
                }
            }
        }
        private void ShowPlayerBoard()
        {
            if (isPlayer1Turn)
            {
                tableLayoutPanelPlayer2.Visible = true;
                tableLayoutPanelPlayer1.Visible = false;
                lblTurno.Text = $"Turno de {gameData.Player1Name} para atacar";
            }
            else
            {
                tableLayoutPanelPlayer1.Visible = true;
                tableLayoutPanelPlayer2.Visible = false;
                lblTurno.Text = $"Turno de {gameData.Player2Name} para atacar";
            }
        }
        private bool AttackPosition(string position, Button[,] buttons, List<string> figures)
        {
            int row = position[0] - 'A'; // Convert row letter to index
            int column = int.Parse(position.Substring(1)) - 1; // Convert column number to index
            if (row >= 0 && row < 5 && column >= 0 && column < 5) // Check if the position is within limits
            {
                Button button = buttons[row, column]; // Get the button at the specified position
                if (figures.Contains(position))
                {
                    button.BackColor = Color.Yellow;
                    figures.Remove(position);
                    return true;
                }
                else
                {
                    button.BackColor = Color.Red;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Posición fuera de rango.");
                return false;
            }
        }
        private bool IsValidPosition(string position)
        {
            if (position.Length < 2) return false;
            char row = position[0];
            string columnStr = position.Substring(1);
            return (row >= 'A' && row <= 'E') && int.TryParse(columnStr, out int column) && column >= 1 && column <= 5; // Validate position
        }
        private void InitializeExitAndPlayAgainButtons()
        {
            btnExitGame.Click += (sender, e) => Application.Exit();
            this.Controls.Add(btnExitGame);
            btnPlayAgain.Click += btnplayAgain_Click;
            this.Controls.Add(btnPlayAgain);
        }
        private void btnplayAgain_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y reinicia la aplicación
            this.Close();
            Application.Restart();
        }
        private void DisableGameControls()
        {
            // Disable the attack button
            btnAttack.Enabled = false;

            // Disable the text box
            txtPosition.Enabled = false;

            // Disable the table layouts
            tableLayoutPanelPlayer1.Enabled = false;
            tableLayoutPanelPlayer2.Enabled = false;
        }
        #endregion

        #region Events
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime++; // Increment the elapsed time
            lblTimer.Text = $"Tiempo: {elapsedTime} s"; // Update the timer label text
        }

        private bool CheckVictory()
        {
            return player2Figures.Count == 0 || player1Figures.Count == 0;
        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            bool bang = false;
            string position = txtPosition.Text.Trim().ToUpper(); // Get and format the attack position
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Por favor ingrese una posición para atacar.");
                return;
            }
            if (!IsValidPosition(position))
            {
                MessageBox.Show("Posición inválida.");
                return;
            }
            if (isPlayer1Turn && player1AttackedPositions.Contains(position))
            {
                MessageBox.Show("El jugador 1 ya atacó esta posición.");
                return;
            }
            else if (!isPlayer1Turn && player2AttackedPositions.Contains(position))
            {
                MessageBox.Show("El jugador 2 ya atacó esta posición.");
                return;
            }
            if (isPlayer1Turn)
            {
                player1AttackedPositions.Add(position); // Record the attack position for player 1
                bang = AttackPosition(position, player2Buttons, player2Figures); // Attack player 2's board
            }
            else
            {
                player2AttackedPositions.Add(position); // Record the attack position for player 2
                bang = AttackPosition(position, player1Buttons, player1Figures); // Attack player 1's board
            }
            txtPosition.Text = ""; // Clear the input field
            if (CheckVictory())
            {
                gameTimer.Stop(); // Stop the game timer
                string winnerName = isPlayer1Turn ? gameData.Player1Name : gameData.Player2Name;
                MessageBox.Show($"El jugador {winnerName} ha ganado en {elapsedTime} segundos!");
                DisableGameControls(); // Call method to disable game controls
                return;
            }
            if (!bang)
            {
                isPlayer1Turn = !isPlayer1Turn; // Change turn if there is no hit
            }
            ShowPlayerBoard(); // Update the displayed board
        }
        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string position = txtPosition.Text.Trim().ToUpper(); // Get and format attack position

                if (!string.IsNullOrEmpty(position))
                {
                    btnAttack_Click(this, new EventArgs());
                    e.SuppressKeyPress = true; // Avoid the 'ding' sound
                }
                else
                {
                    e.SuppressKeyPress = true; // Avoid 'ding' sound even if empty
                }
            }
        }
        private void frmBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the form
        }
        #endregion
    }
}
