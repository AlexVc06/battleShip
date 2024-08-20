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
            btnAcepted = new Button();
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
            tableLayoutPanel1.Size = new Size(410, 410);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAcepted
            // 
            btnAcepted.BackColor = Color.DimGray;
            btnAcepted.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcepted.ForeColor = Color.FromArgb(255, 128, 0);
            btnAcepted.Location = new Point(788, 439);
            btnAcepted.Name = "btnAcepted";
            btnAcepted.Size = new Size(185, 66);
            btnAcepted.TabIndex = 1;
            btnAcepted.Text = "Acepted";
            btnAcepted.UseVisualStyleBackColor = false;
            btnAcepted.Click += btnAcepted_Click;
            // 
            // lblNameUser1
            // 
            lblNameUser1.AutoSize = true;
            lblNameUser1.BackColor = Color.Transparent;
            lblNameUser1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameUser1.ForeColor = Color.FromArgb(255, 128, 0);
            lblNameUser1.Location = new Point(36, 95);
            lblNameUser1.Name = "lblNameUser1";
            lblNameUser1.Size = new Size(74, 24);
            lblNameUser1.TabIndex = 2;
            lblNameUser1.Text = "Name:";
            // 
            // txtNameUser1
            // 
            txtNameUser1.BackColor = Color.DarkGray;
            txtNameUser1.Location = new Point(110, 95);
            txtNameUser1.Name = "txtNameUser1";
            txtNameUser1.Size = new Size(170, 27);
            txtNameUser1.TabIndex = 3;
            // 
            // lblUser1
            // 
            lblUser1.AutoSize = true;
            lblUser1.BackColor = Color.Transparent;
            lblUser1.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser1.Location = new Point(457, 25);
            lblUser1.Name = "lblUser1";
            lblUser1.Size = new Size(135, 38);
            lblUser1.TabIndex = 4;
            lblUser1.Text = "User 1";
            // 
            // frmPreparation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadabattle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 577);
            Controls.Add(lblUser1);
            Controls.Add(txtNameUser1);
            Controls.Add(lblNameUser1);
            Controls.Add(btnAcepted);
            Controls.Add(tableLayoutPanel1);
            Name = "frmPreparation";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preparation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAcepted;
        private Label lblNameUser1;
        private TextBox txtNameUser1;
        private Label lblUser1;
    }
}