using System;
using System.Windows.Forms;
using System.Drawing;

namespace battleShip
{
    public partial class frmPreparation : Form
    {
        private Button[,] buttons;
        private int figurePresent = 0;
        private bool placeFigure = true;
        public frmPreparation()
        {
            InitializeComponent();
            this.Load += frmPreparation_Load;
        }
        private void frmPreparation_Load(object sender, EventArgs e)
        {
            string[] rows = { "A", "B", "C", "D", "E" };
            int[] columns = { 1, 2, 3, 4, 5 };
            buttons = new Button[rows.Length, columns.Length];  //Initialize the button array
            tableLayoutPanel1.RowCount = rows.Length; //Number of rows and columns
            tableLayoutPanel1.ColumnCount = columns.Length;
            tableLayoutPanel1.Controls.Clear();
            // Add buttons to the tableLayout 
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    Button button = new Button
                    {
                        Text = $"{rows[i]}{columns[j]}", //combine the row with the text for the text
                        Dock = DockStyle.Fill //button covers the entire cell
                    };
                    // Event Click
                    button.Click += Button_Click;
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                    //Add the button of the matrix and the tableLayout
                    buttons[i, j] = button;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }
        // Event when a button is clicked
        private void Button_Click(object sender, EventArgs e)
        {
            if (!placeFigure) return;
            Button bbuttonSelect = sender as Button;
            //Get position of the selected button
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == bbuttonSelect)
                    {
                        if (figurePresent == 0 && AddFigure4Buttons(j, i))  //Figure 4 buttons
                        {
                            figurePresent = 1;
                        }
                        else if (figurePresent == 1 && AddFigure_L(j, i)) // Figure in L
                        {
                            figurePresent = 2;
                        }
                        else if (figurePresent == 2 && AddFigure2Buttons(j, i)) // Figure 3 buttons
                        {
                            placeFigure = false;
                        }
                        return;
                    }
                }
            }
        }
        // Show silhouette when mouse enters a button
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (!placeFigure) return;
            Button botonSeleccionado = sender as Button;
            //Get position of the selected button
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == botonSeleccionado)
                    {
                        if (figurePresent == 0)
                        {
                            show_silhouette(j, i, Color.LightPink);
                        }
                        else if (figurePresent == 1)
                        {
                            ShowFiguresilhouette(j, i, Color.LightBlue);
                        }
                        else if (figurePresent == 2)
                        {
                            ShowFigure2ButtonSilhouette(j, i, Color.LightGreen);
                        }
                        return;
                    }
                }
            }
        }
        // When mouse leaves a button
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (!placeFigure) return;
            Clear_silhouette();
        }
        // Show silhouette for 4 button vertical figure
        void show_silhouette(int initialColumn, int initialRow, Color color)
        {
            Clear_silhouette();
            if (initialRow + 3 < 5 && CheckAvailableSpace(initialRow, initialColumn, 4)) // Check space
            {
                for (int i = 0; i < 4; i++)
                {
                    buttons[initialRow + i, initialColumn].BackColor = color;
                }
            }
        }
        // Show silhouette for L figure
        private void ShowFiguresilhouette(int initialColumn, int initialRow, Color color)
        {
            Clear_silhouette();
            if (initialRow + 1 < 5 && initialColumn + 1 < 5 && CheckAvailableSpaceL(initialRow, initialColumn)) // Check space
            {
                for (int i = 0; i < 2; i++)
                {
                    buttons[initialRow + i, initialColumn].BackColor = color;
                }
                buttons[initialRow + 1, initialColumn + 1].BackColor = color;
            }
        }
        // Show silhouette for 2 button vertical figure
        private void ShowFigure2ButtonSilhouette(int initialColumn, int initialRow, Color color)
        {
            Clear_silhouette();
            if (initialRow + 1 < 5 && CheckAvailableSpace(initialRow, initialColumn, 2)) // Check space
            {
                for (int i = 0; i < 2; i++)
                {
                    buttons[initialRow + i, initialColumn].BackColor = color;
                }
            }
        }
        // Clear all silhouettes
        void Clear_silhouette()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].BackColor == Color.LightPink || buttons[i, j].BackColor == Color.LightBlue || buttons[i, j].BackColor == Color.LightGreen)
                    {
                        buttons[i, j].BackColor = DefaultBackColor;
                    }
                }
            }
        }
        // Add 4 button figure
        private bool AddFigure4Buttons(int initialColumn, int initialRow)
        {
            if (initialRow + 3 >= 5 || !CheckAvailableSpace(initialRow, initialColumn, 4)) return false; // Check space
            for (int i = 0; i < 4; i++)
            {
                buttons[initialRow + i, initialColumn].BackColor = Color.Red;
                buttons[initialRow + i, initialColumn].Text = "V";
                buttons[initialRow + i, initialColumn].Enabled = false; // Disable button
            }
            return true;
        }
        // Add 3 button figure in L
        private bool AddFigure_L(int initialColumn, int initialRow)
        {
            if (initialRow + 1 >= 5 || initialColumn + 1 >= 5 || !CheckAvailableSpaceL(initialRow, initialColumn)) return false; // Check space
            for (int i = 0; i < 2; i++)
            {
                buttons[initialRow + i, initialColumn].BackColor = Color.Blue;
                buttons[initialRow + i, initialColumn].Text = "L";
                buttons[initialRow + i, initialColumn].Enabled = false;
            }
            buttons[initialRow + 1, initialColumn + 1].BackColor = Color.Blue;
            buttons[initialRow + 1, initialColumn + 1].Text = "L";
            buttons[initialRow + 1, initialColumn + 1].Enabled = false;
            return true;
        }
        // Add 2 button vertical figure
        private bool AddFigure2Buttons(int initialColumn, int initialRow)
        {
            if (initialRow + 1 >= 5 || !CheckAvailableSpace(initialRow, initialColumn, 2)) return false; // Check space
            for (int i = 0; i < 2; i++)
            {
                buttons[initialRow + i, initialColumn].BackColor = Color.Green;
                buttons[initialRow + i, initialColumn].Text = "T";
                buttons[initialRow + i, initialColumn].Enabled = false; // Disable button
            }
            return true;
        }
        // Check if there is space for vertical figures
        private bool CheckAvailableSpace(int initialRow, int initialColumn, int longitud)
        {
            if (initialRow + longitud - 1 >= 5) return false;
            for (int i = 0; i < longitud; i++)
            {
                if (!buttons[initialRow + i, initialColumn].Enabled) return false;
            }
            return true;
        }
        // Check if there is space for L figure
        private bool CheckAvailableSpaceL(int initialRow, int initialColumn)
        {
            if (initialRow + 1 >= 5 || initialColumn + 1 >= 5) return false;
            if (!buttons[initialRow, initialColumn].Enabled ||
                !buttons[initialRow + 1, initialColumn].Enabled ||
                !buttons[initialRow + 1, initialColumn + 1].Enabled)
            {
                return false;
            }
            return true;
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
                MessageBox.Show("Please place all the figures before continuing..");
                return;
            }
            frmPreparation2 preparation2Form = new frmPreparation2();
            preparation2Form.Show();
            this.Hide(); ;
        }
    }
}
