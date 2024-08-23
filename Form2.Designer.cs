namespace battleShip
{
    partial class frmPreparation
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReady = new Button();
            lblNameUser1 = new Label();
            txtNameUser1 = new TextBox();
            lblUser1 = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Location = new Point(321, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(450, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReady
            // 
            btnReady.BackColor = Color.DimGray;
            btnReady.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReady.ForeColor = Color.FromArgb(255, 128, 0);
            btnReady.Location = new Point(822, 479);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(185, 66);
            btnReady.TabIndex = 1;
            btnReady.Text = "Listo";
            btnReady.UseVisualStyleBackColor = false;
            btnReady.Click += btnAcepted_Click;
            // 
            // lblNameUser1
            // 
            lblNameUser1.AutoSize = true;
            lblNameUser1.BackColor = Color.Transparent;
            lblNameUser1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameUser1.ForeColor = Color.FromArgb(255, 128, 0);
            lblNameUser1.Location = new Point(12, 95);
            lblNameUser1.Name = "lblNameUser1";
            lblNameUser1.Size = new Size(104, 24);
            lblNameUser1.TabIndex = 2;
            lblNameUser1.Text = "Nombre:";
            // 
            // txtNameUser1
            // 
            txtNameUser1.BackColor = Color.DarkGray;
            txtNameUser1.Location = new Point(122, 95);
            txtNameUser1.Name = "txtNameUser1";
            txtNameUser1.Size = new Size(158, 27);
            txtNameUser1.TabIndex = 3;
            txtNameUser1.KeyPress += txtNameUser1_KeyPress;
            // 
            // lblUser1
            // 
            lblUser1.AutoSize = true;
            lblUser1.BackColor = Color.Transparent;
            lblUser1.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser1.Location = new Point(457, 25);
            lblUser1.Name = "lblUser1";
            lblUser1.Size = new Size(195, 38);
            lblUser1.TabIndex = 4;
            lblUser1.Text = "Usuario 1";
            // 
            // frmPreparation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadabattle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 653);
            Controls.Add(lblUser1);
            Controls.Add(txtNameUser1);
            Controls.Add(lblNameUser1);
            Controls.Add(btnReady);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "frmPreparation";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro jugador 1";
            KeyDown += frmPreparation_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnReady;
        private Label lblNameUser1;
        private TextBox txtNameUser1;
        private Label lblUser1;
    }
}