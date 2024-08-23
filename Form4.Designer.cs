namespace battleShip
{
    partial class frmBattle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanelPlayer1 = new TableLayoutPanel();
            tableLayoutPanelPlayer2 = new TableLayoutPanel();
            txtPosition = new TextBox();
            btnAttack = new Button();
            lblTurno = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            btnPlayAgain = new Button();
            btnExitGame = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanelPlayer1
            // 
            tableLayoutPanelPlayer1.BackColor = Color.Transparent;
            tableLayoutPanelPlayer1.ColumnCount = 5;
            tableLayoutPanelPlayer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.Location = new Point(322, 126);
            tableLayoutPanelPlayer1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelPlayer1.Name = "tableLayoutPanelPlayer1";
            tableLayoutPanelPlayer1.RowCount = 5;
            tableLayoutPanelPlayer1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer1.Size = new Size(450, 450);
            tableLayoutPanelPlayer1.TabIndex = 0;
            // 
            // tableLayoutPanelPlayer2
            // 
            tableLayoutPanelPlayer2.BackColor = Color.Transparent;
            tableLayoutPanelPlayer2.ColumnCount = 5;
            tableLayoutPanelPlayer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.Location = new Point(322, 126);
            tableLayoutPanelPlayer2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelPlayer2.Name = "tableLayoutPanelPlayer2";
            tableLayoutPanelPlayer2.RowCount = 5;
            tableLayoutPanelPlayer2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelPlayer2.Size = new Size(450, 450);
            tableLayoutPanelPlayer2.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.LightGray;
            txtPosition.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(452, 30);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(106, 43);
            txtPosition.TabIndex = 2;
         
            // 
            // btnAttack
            // 
            btnAttack.BackColor = Color.DarkGray;
            btnAttack.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttack.ForeColor = Color.Black;
            btnAttack.Location = new Point(564, 21);
            btnAttack.Margin = new Padding(3, 4, 3, 4);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(101, 61);
            btnAttack.TabIndex = 3;
            btnAttack.Text = "Atacar";
            btnAttack.UseVisualStyleBackColor = false;
            btnAttack.Click += btnAttack_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.Font = new Font("Algerian", 12F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(255, 128, 0);
            lblTurno.Location = new Point(389, 97);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(0, 22);
            lblTurno.TabIndex = 4;
            // 
            // GameTimer
            // 
            GameTimer.Tick += GameTimer_Tick;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(890, 576);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(148, 47);
            btnPlayAgain.TabIndex = 5;
            btnPlayAgain.Text = "Jugar otra vez";
            btnPlayAgain.UseVisualStyleBackColor = true;
            // 
            // btnExitGame
            // 
            btnExitGame.Location = new Point(26, 587);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(117, 48);
            btnExitGame.TabIndex = 6;
            btnExitGame.Text = "Salir";
            btnExitGame.UseVisualStyleBackColor = true;
            // 
            // frmBattle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImagenPri;
            ClientSize = new Size(1063, 653);
            Controls.Add(btnExitGame);
            Controls.Add(btnPlayAgain);
            Controls.Add(tableLayoutPanelPlayer2);
            Controls.Add(lblTurno);
            Controls.Add(btnAttack);
            Controls.Add(txtPosition);
            Controls.Add(tableLayoutPanelPlayer1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmBattle";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Battle";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Timer GameTimer;
        private Button btnPlayAgain;
        private Button btnExitGame;
    }
}
