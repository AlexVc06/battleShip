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
            lblPlayer1Name = new Label();
            lblPlayer2Name = new Label();
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
            tableLayoutPanelPlayer1.Location = new Point(47, 97);
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
            tableLayoutPanelPlayer2.Location = new Point(587, 97);
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
            // frmBattle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImagenPri;
            ClientSize = new Size(1063, 577);
            Controls.Add(tableLayoutPanelPlayer2);
            Controls.Add(lblPlayer2Name);
            Controls.Add(lblPlayer1Name);
            Controls.Add(lblTurno);
            Controls.Add(btnAttack);
            Controls.Add(txtPosition);
            Controls.Add(tableLayoutPanelPlayer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBattle";
            Text = "Battle";
            Load += frmBattle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblTurno;
        private Label lblPlayer1Name;
        private Label lblPlayer2Name;
    }
}