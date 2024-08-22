using System;
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
        private Button[,] player1Buttons; //Set of buttons representing the player 1 board
        private bool isPlayer1Turn = true; // Turn
        private HashSet<string> player1AttackedPositions = new HashSet<string>();
        private HashSet<string> player2AttackedPositions = new HashSet<string>();

        public frmBattle(GameData gameData)
        {
            InitializeComponent();
            this.gameData = gameData; // Assign the game data
            InitializeBattleBoards(); // Initialize game boards
            ShowPlayerBoard(); // Display the appropriate player board
            player1Figures = gameData.Player1Figures; // Place player 1's ship positions
            player2Figures = gameData.Player2Figures; // Place player 2's ship positions
            InitializeGameTimer(); // Initialize and start the game timer
        }
        private void InitializeGameTimer()
        {
            // Configurar el temporizador
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000; // 1 segundo
            gameTimer.Tick += GameTimer_Tick; // Evento al pasar el intervalo

            // Inicializar el tiempo transcurrido y el Label del temporizador
            elapsedTime = 0;

            lblTimer = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(100, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Text = "Time: 0s"
            };

            this.Controls.Add(lblTimer); // Añadir el label al formulario
            gameTimer.Start(); // Iniciar el temporizador
        }
        private void InitializeBattleBoards()
        {
            InitializeTableLayoutPanel(tableLayoutPanelPlayer1, out player1Buttons);
            InitializeTableLayoutPanel(tableLayoutPanelPlayer2, out player2Buttons);
            tableLayoutPanelPlayer1.Visible = false; // Ocult player 1 table at start
        }

        private void InitializeTableLayoutPanel(TableLayoutPanel panel, out Button[,] buttons)
        {
            panel.ColumnCount = 5;
            panel.RowCount = 5;
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panel.AutoSize = true;

            // Establecer estilos de fila y columna para que ocupen todo el espacio disponible
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // Cada columna ocupa el 20%
            }
            for (int i = 0; i < panel.RowCount; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // Cada fila ocupa el 20%
            }

            string[] rows = { "A", "B", "C", "D", "E" };
            int[] columns = { 1, 2, 3, 4, 5 };

            panel.Controls.Clear();
            buttons = new Button[rows.Length, columns.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    Button button = new Button
                    {
                        Text = $"{rows[i]}{columns[j]}",
                        Size = new Size(60, 60),
                        BackColor = Color.LightGray
                    };
                    panel.Controls.Add(button, j, i);
                    buttons[i, j] = button;
                }
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            string position = txtPosition.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please enter a position to attack.");
                return;
            }
            if (!IsValidPosition(position))
            {
                MessageBox.Show("Invalid position.");
                return;
            }

           
            if (isPlayer1Turn && player1AttackedPositions.Contains(position))
            {
                MessageBox.Show("Player 1 already attacked this position.");
                return;
            }
            else if (!isPlayer1Turn && player2AttackedPositions.Contains(position))
            {
                MessageBox.Show("Player 2 already attacked this position.");
                return;
            }

           
            if (isPlayer1Turn)
            {
                player1AttackedPositions.Add(position);
            }
            else
            {
                player2AttackedPositions.Add(position);
            }

            bool bang = false;
            if (isPlayer1Turn)
            {
                bang = AttackPosition(position, player2Buttons, player2Figures);
            }
            else
            {
                bang = AttackPosition(position, player1Buttons, player1Figures);
            }

            txtPosition.Text = "";
            if (!bang)
            {
                isPlayer1Turn = !isPlayer1Turn;
            }
            ShowPlayerBoard();
        }
        private void ShowPlayerBoard()
        {
            if (isPlayer1Turn)
            {
                // Show player 2 table
                tableLayoutPanelPlayer2.Visible = true;
                tableLayoutPanelPlayer1.Visible = false;

                // Show name player 1
                lblTurno.Text = $"{gameData.Player1Name}'s turn";
            }
            else
            {
                // Show player 1 table
                tableLayoutPanelPlayer1.Visible = true;
                tableLayoutPanelPlayer2.Visible = false;

                //  Show name player 2
                lblTurno.Text = $"{gameData.Player2Name}'s turn";
            }
        }

        private bool AttackPosition(string position, Button[,] buttons, List<string> figures)
        {
            int row = position[0] - 'A'; 
            int column = int.Parse(position.Substring(1)) - 1;

            if (row >= 0 && row < 5 && column >= 0 && column < 5)
            {
                Button button = buttons[row, column];
                if (figures.Contains(position))
                {
                    button.BackColor = Color.Red; // Mark as impacted
                    figures.Remove(position); // Delete impacted position
                    return true;
                }
                else
                {
                    button.BackColor = Color.Blue; // Mark failed
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Position out of range.");
                return false;
            }
        }

        private bool IsValidPosition(string position)
        {
            if (position.Length < 2) return false;
            char row = position[0];
            string columnStr = position.Substring(1);
            return (row >= 'A' && row <= 'E') && int.TryParse(columnStr, out int column) && column >= 1 && column <= 5;
        }

        private void frmBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
