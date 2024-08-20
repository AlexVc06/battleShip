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
            frmPreparation preparationForm = new frmPreparation();
            preparationForm.Show();
            this.Hide();
        }

    }
}
