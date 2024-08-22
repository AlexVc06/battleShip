using System;
using System.Windows.Forms;

namespace battleShip
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            GameData gameData = new GameData();
            frmPreparation preparationForm = new frmPreparation(gameData);
            preparationForm.Show();
            this.Hide();
        }
    }
}
