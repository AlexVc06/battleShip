﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace battleShip
{
    public partial class frmPreparation2 : Form
    {
        private GameData gameData;
        private Button[,] buttons;
        private int figurePresent = 0;
        private bool placeFigure = true;

        public frmPreparation2(GameData gameData)
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
            this.gameData = gameData;
        }

        private void InitializeTableLayoutPanel()
        {
            string[] rows = { "A", "B", "C", "D", "E" };
            int[] columns = { 1, 2, 3, 4, 5 };
            buttons = new Button[rows.Length, columns.Length];
            tableLayoutPanel2.RowCount = rows.Length;
            tableLayoutPanel2.ColumnCount = columns.Length;

            tableLayoutPanel2.Controls.Clear();

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
                    tableLayoutPanel2.Controls.Add(button, j, i);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!placeFigure) return;
            Button bbuttonSelect = sender as Button;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == bbuttonSelect)
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
            Button botonSeleccionado = sender as Button;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == botonSeleccionado)
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
            Clear_silhouette();
        }

        void ShowSilhouette(int initialColumn, int initialRow, Color color, int length, bool isLShape = false)
        {
            Clear_silhouette();
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

        private bool AddFigure4Buttons(int initialColumn, int initialRow)
        {
            if (initialRow + 3 >= 5 || !CheckAvailableSpace(initialRow, initialColumn, 4)) return false;

            // Save positions in GameData
            for (int i = 0; i < 4; i++)
            {
                string position = $"{(char)('A' + initialRow + i)}{initialColumn + 1}";
                gameData.Player2Figures.Add(position); // Add occupied positions
                buttons[initialRow + i, initialColumn].BackColor = Color.Red;
                buttons[initialRow + i, initialColumn].Text = "V";
                buttons[initialRow + i, initialColumn].Enabled = false;
            }
            return true;
        }

        private bool AddFigure_L(int initialColumn, int initialRow)
        {
            if (initialRow + 1 >= 5 || initialColumn + 1 >= 5 || !CheckAvailableSpaceL(initialRow, initialColumn)) return false;

            // Save positions in GameData
            for (int i = 0; i < 2; i++)
            {
                string position = $"{(char)('A' + initialRow + i)}{initialColumn + 1}";
                gameData.Player2Figures.Add(position); // Add occupied positions
                buttons[initialRow + i, initialColumn].BackColor = Color.Blue;
                buttons[initialRow + i, initialColumn].Text = "L";
                buttons[initialRow + i, initialColumn].Enabled = false;
            }
            string lShapePosition = $"{(char)('A' + initialRow + 1)}{initialColumn + 2}";
            gameData.Player2Figures.Add(lShapePosition); // Add position figure "L"
            buttons[initialRow + 1, initialColumn + 1].BackColor = Color.Blue;
            buttons[initialRow + 1, initialColumn + 1].Text = "L";
            buttons[initialRow + 1, initialColumn + 1].Enabled = false;

            return true;
        }

        private bool AddFigure2Buttons(int initialColumn, int initialRow)
        {
            if (initialRow + 1 >= 5 || !CheckAvailableSpace(initialRow, initialColumn, 2)) return false;

            // Save positions in GameData
            for (int i = 0; i < 2; i++)
            {
                string position = $"{(char)('A' + initialRow + i)}{initialColumn + 1}";
                gameData.Player2Figures.Add(position); // Add occupied positions
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
            if (!buttons[initialRow, initialColumn].Enabled ||
                !buttons[initialRow + 1, initialColumn].Enabled ||
                !buttons[initialRow + 1, initialColumn + 1].Enabled)
            {
                return false;
            }
            return true;
        }

        private void btnAcepted2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameUser2.Text))
            {
                MessageBox.Show("Please enter your name before continuing.");
                return;
            }
            if (figurePresent < 2 || placeFigure)
            {
                MessageBox.Show("Please place all the figures before continuing.");
                return;
            }
            gameData.Player2Name = txtNameUser2.Text;
            frmBattle battleForm = new frmBattle(gameData);
            battleForm.Show();
            this.Hide();
        }
    }
}
