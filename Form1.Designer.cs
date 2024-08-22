namespace battleShip
{
    partial class FrmWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessageWelcome = new Label();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // lblMessageWelcome
            // 
            lblMessageWelcome.AutoSize = true;
            lblMessageWelcome.BackColor = Color.Transparent;
            lblMessageWelcome.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessageWelcome.ForeColor = SystemColors.ActiveCaptionText;
            lblMessageWelcome.Location = new Point(420, 31);
            lblMessageWelcome.Name = "lblMessageWelcome";
            lblMessageWelcome.Size = new Size(235, 38);
            lblMessageWelcome.TabIndex = 0;
            lblMessageWelcome.Text = "Battle Ship";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.DimGray;
            btnOpen.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.FromArgb(255, 128, 0);
            btnOpen.Location = new Point(460, 452);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(142, 52);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open Game";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnNext_Click;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadabattle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 577);
            Controls.Add(btnOpen);
            Controls.Add(lblMessageWelcome);
            Name = "FrmWelcome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BattleShip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMessageWelcome;
        private Button btnOpen;
    }
}
