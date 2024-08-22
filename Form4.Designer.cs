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
            tableLayoutPanelPlayer1 = new TableLayoutPanel();
            tableLayoutPanelPlayer2 = new TableLayoutPanel();
            txtPosition = new TextBox();
            btnAttack = new Button();
            lblTurno = new Label();
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
            tableLayoutPanelPlayer1.Location = new Point(322, 97);
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
            tableLayoutPanelPlayer2.Location = new Point(322, 97);
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
            txtPosition.Location = new Point(415, 38);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(155, 27);
            txtPosition.TabIndex = 2;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(600, 29);
            btnAttack.Margin = new Padding(3, 4, 3, 4);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(86, 45);
            btnAttack.TabIndex = 3;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTurno.Location = new Point(28, 46);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(0, 28);
            lblTurno.TabIndex = 4;
            // 
            // frmBattle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImagenPri;
            ClientSize = new Size(1063, 577);
            Controls.Add(tableLayoutPanelPlayer2);
            Controls.Add(lblTurno);
            Controls.Add(btnAttack);
            Controls.Add(txtPosition);
            Controls.Add(tableLayoutPanelPlayer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBattle";
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
    }
}