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
            btnAcepted2 = new Button();
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
            tableLayoutPanel2.Size = new Size(410, 410);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAcepted2
            // 
            btnAcepted2.BackColor = Color.DimGray;
            btnAcepted2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcepted2.ForeColor = Color.FromArgb(255, 128, 0);
            btnAcepted2.Location = new Point(788, 439);
            btnAcepted2.Name = "btnAcepted2";
            btnAcepted2.Size = new Size(185, 66);
            btnAcepted2.TabIndex = 1;
            btnAcepted2.Text = "Acepted";
            btnAcepted2.UseVisualStyleBackColor = false;
            btnAcepted2.Click += btnAcepted2_Click;
            // 
            // lblNameUser2
            // 
            lblNameUser2.AutoSize = true;
            lblNameUser2.BackColor = Color.Transparent;
            lblNameUser2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameUser2.ForeColor = Color.FromArgb(255, 128, 0);
            lblNameUser2.Location = new Point(36, 95);
            lblNameUser2.Name = "lblNameUser2";
            lblNameUser2.Size = new Size(74, 24);
            lblNameUser2.TabIndex = 2;
            lblNameUser2.Text = "Name:";
            // 
            // txtNameUser2
            // 
            txtNameUser2.BackColor = Color.DarkGray;
            txtNameUser2.Location = new Point(110, 95);
            txtNameUser2.Name = "txtNameUser2";
            txtNameUser2.Size = new Size(170, 27);
            txtNameUser2.TabIndex = 3;
            // 
            // lblUser2
            // 
            lblUser2.AutoSize = true;
            lblUser2.BackColor = Color.Transparent;
            lblUser2.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser2.Location = new Point(457, 25);
            lblUser2.Name = "lblUser2";
            lblUser2.Size = new Size(135, 38);
            lblUser2.TabIndex = 4;
            lblUser2.Text = "User 2";
            // 
            // frmPreparation2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadabattle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 577);
            Controls.Add(lblUser2);
            Controls.Add(txtNameUser2);
            Controls.Add(lblNameUser2);
            Controls.Add(btnAcepted2);
            Controls.Add(tableLayoutPanel2);
            Name = "frmPreparation2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preparation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAcepted2;
        private Label lblNameUser2;
        private TextBox txtNameUser2;
        private Label lblUser2;
    }
}