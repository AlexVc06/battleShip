namespace battleShip
{
    partial class frmPreparation2
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnStartGame = new Button();
            lblNameUser2 = new Label();
            txtNameUser2 = new TextBox();
            lblUser2 = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Location = new Point(321, 95);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(450, 450);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.DimGray;
            btnStartGame.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.ForeColor = Color.FromArgb(255, 128, 0);
            btnStartGame.Location = new Point(822, 462);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(185, 83);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "Iniciar juego";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
         
            // 
            // lblNameUser2
            // 
            lblNameUser2.AutoSize = true;
            lblNameUser2.BackColor = Color.Transparent;
            lblNameUser2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameUser2.ForeColor = Color.FromArgb(255, 128, 0);
            lblNameUser2.Location = new Point(12, 95);
            lblNameUser2.Name = "lblNameUser2";
            lblNameUser2.Size = new Size(104, 24);
            lblNameUser2.TabIndex = 2;
            lblNameUser2.Text = "Nombre:";
            // 
            // txtNameUser2
            // 
            txtNameUser2.BackColor = Color.DarkGray;
            txtNameUser2.Location = new Point(122, 95);
            txtNameUser2.Name = "txtNameUser2";
            txtNameUser2.Size = new Size(158, 27);
            txtNameUser2.TabIndex = 3;
            txtNameUser2.KeyPress += txtNameUser2_KeyPress;
            // 
            // lblUser2
            // 
            lblUser2.AutoSize = true;
            lblUser2.BackColor = Color.Transparent;
            lblUser2.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser2.Location = new Point(457, 25);
            lblUser2.Name = "lblUser2";
            lblUser2.Size = new Size(195, 38);
            lblUser2.TabIndex = 4;
            lblUser2.Text = "Usuario 2";
            // 
            // frmPreparation2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadabattle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 653);
            Controls.Add(lblUser2);
            Controls.Add(txtNameUser2);
            Controls.Add(lblNameUser2);
            Controls.Add(btnStartGame);
            Controls.Add(tableLayoutPanel2);
            MaximizeBox = false;
            Name = "frmPreparation2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro jugador 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnStartGame;
        private Label lblNameUser2;
        private TextBox txtNameUser2;
        private Label lblUser2;
    }
}