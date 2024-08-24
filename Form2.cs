using System;
using System.Drawing;
using System.Windows.Forms;

namespace battleShip
{
    public partial class frmPreparation : Form
    {
        private GameData gameData;
        private Button[,] buttons;
        private int figurePresent = 0;
        private bool placeFigure = true;

        public frmPreparation(GameData gameData)
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
            this.gameData = gameData;
            // Permite que el formulario detecte las teclas presionadas
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmPreparation_KeyDown);

        }

        #region Methods

        private void InitializeTableLayoutPanel()
        {
            string[] rows = { "A", "B", "C", "D", "E" };
            int[] columns = { 1, 2, 3, 4, 5 };
            buttons = new Button[rows.Length, columns.Length];
            tableLayoutPanel1.RowCount = rows.Length;
            tableLayoutPanel1.ColumnCount = columns.Length;

            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    Button button = new Button
                    {
                        Text = $"{rows[i]}{columns[j]}",
                        Dock = DockStyle.Fill
                    };
                    button.Click += Button_Click;
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                    buttons[i, j] = button;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }

        private void ShowSilhouette(int initialColumn, int initialRow, Color color, int length, bool isLShape = false)
        {
            ClearSilhouette();
            if (isLShape)
            {
                if (initialRow + 1 < 5 && initialColumn + 1 < 5 && CheckAvailableSpaceL(initialRow, initialColumn))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        buttons[initialRow + i, initialColumn].BackColor = color;
                    }
                    buttons[initialRow + 1, initialColumn + 1].BackColor = color;
                }
            }
            else
            {
                if (initialRow + length - 1 < 5 && CheckAvailableSpace(initialRow, initialColumn, length))
                {
                    for (int i = 0; i < length; i++)
                    {
                        buttons[initialRow + i, initialColumn].BackColor = color;
                    }
                }
            }
        }

        private void ClearSilhouette()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].BackColor == Color.LightPink ||
                        buttons[i, j].BackColor == Color.LightBlue ||
                        buttons[i, j].BackColor == Color.LightGreen)
                    {
                        buttons[i, j].BackColor = DefaultBackColor;
                    }
                }
            }
        }

        private bool AddFigure4Buttons(int initialColumn, int initialRow)
        {
            if (initialRow + 3 >= 5 || !CheckAvailableSpace(initialRow, initialColumn, 4)) return false;

            for (int i = 0; i < 4; i++)
            {
                string position = $"{(char)('A' + initialRow + i)}{initialColumn + 1}";
                gameData.Player1Figures.Add(position);
                buttons[initialRow + i, initialColumn].BackColor = Color.Red;
                buttons[initialRow + i, initialColumn].Text = "V";
                buttons[initialRow + i, initialColumn].Enabled = false;
            }

            return true;
        }

        private bool AddFigure_L(int initialColumn, int initialRow)
        {
            if (initialRow + 1 >= 5 || initialColumn + 1 >= 5 || !CheckAvailableSpaceL(initialRow, initialColumn)) return false;

            for (int i = 0; i < 2; i++)
            {
                string position = $"{(char)('A' + initialRow + i)}{initialColumn + 1}";
                gameData.Player1Figures.Add(position);
                buttons[initialRow + i, initialColumn].BackColor = Color.Blue;
                buttons[initialRow + i, initialColumn].Text = "L";
                buttons[initialRow + i, initialColumn].Enabled = false;
            }
            string lShapePosition = $"{(char)('A' + initialRow + 1)}{initialColumn + 2}";
            gameData.Player1Figures.Add(lShapePosition);
            buttons[initialRow + 1, initialColumn + 1].BackColor = Color.Blue;
            buttons[initialRow + 1, initialColumn + 1].Text = "L";
            buttons[initialRow + 1, initialColumn + 1].Enabled = false;

            return true;
        }

        private bool AddFigure2Buttons(int initialColumn, int initialRow)
        {
            if (initialRow + 1 >= 5 || !CheckAvailableSpace(initialRow, initialColumn, 2)) return false;

            for (int i = 0; i < 2; i++)
            {
                string position = $"{(char)('A' + initialRow + i)}{initialColumn + 1}";
                gameData.Player1Figures.Add(position);
                buttons[initialRow + i, initialColumn].BackColor = Color.Green;
                buttons[initialRow + i, initialColumn].Text = "T";
                buttons[initialRow + i, initialColumn].Enabled = false;
            }
            return true;
        }

        private bool CheckAvailableSpace(int initialRow, int initialColumn, int length)
        {
            if (initialRow + length - 1 >= 5) return false;

            for (int i = 0; i < length; i++)
            {
                if (!buttons[initialRow + i, initialColumn].Enabled) return false;
            }
            return true;
        }

        private bool CheckAvailableSpaceL(int initialRow, int initialColumn)
        {
            if (initialRow + 1 >= 5 || initialColumn + 1 >= 5) return false;

            return buttons[initialRow, initialColumn].Enabled &&
                   buttons[initialRow + 1, initialColumn].Enabled &&
                   buttons[initialRow + 1, initialColumn + 1].Enabled;
        }

        #endregion

        #region Events

        private void Button_Click(object sender, EventArgs e)
        {
            if (!placeFigure) return;

            Button selectedButton = sender as Button;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == selectedButton)
                    {
                        if (figurePresent == 0 && AddFigure4Buttons(j, i))
                        {
                            figurePresent = 1;
                        }
                        else if (figurePresent == 1 && AddFigure_L(j, i))
                        {
                            figurePresent = 2;
                        }
                        else if (figurePresent == 2 && AddFigure2Buttons(j, i))
                        {
                            placeFigure = false;
                        }
                        return;
                    }
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (!placeFigure) return;

            Button hoveredButton = sender as Button;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == hoveredButton)
                    {
                        if (figurePresent == 0)
                        {
                            ShowSilhouette(j, i, Color.LightPink, 4);
                        }
                        else if (figurePresent == 1)
                        {
                            ShowSilhouette(j, i, Color.LightBlue, 2, true);
                        }
                        else if (figurePresent == 2)
                        {
                            ShowSilhouette(j, i, Color.LightGreen, 2);
                        }
                        return;
                    }
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (!placeFigure) return;
            ClearSilhouette();
        }

        private void btnAcepted_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameUser1.Text))
            {
                MessageBox.Show("Please enter your name before continuing.");
                return;
            }
            if (figurePresent < 2 || placeFigure)
            {
                MessageBox.Show("Please place all the figures before continuing.");
                return;
            }
            gameData.Player1Name = txtNameUser1.Text;
            frmPreparation2 preparationForm2 = new frmPreparation2(gameData);
            preparationForm2.Show();
            this.Hide();
        }

        private void txtNameUser1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void frmPreparation_KeyDown(object sender, KeyEventArgs e)
        {
            // Si el usuario presiona Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Simula el clic en el botón btnAcepted
                btnAcepted_Click(this, new EventArgs());

                // Evita que el sonido 'ding' se reproduzca al presionar Enter
                e.SuppressKeyPress = true;
            }
        }

        #endregion


    }
}
