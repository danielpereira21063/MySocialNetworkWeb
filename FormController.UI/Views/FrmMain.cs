namespace FormController.UI.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCloseProgram_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sair", "Deseja realmente sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnGenerateAllData_Click(object sender, EventArgs e)
        {

        }

        private void BtnGerateProfilePictures_Click(object sender, EventArgs e)
        {
            var seedImageProfilePicture = new SeedImageProfilePicture();

            seedImageProfilePicture.Show();
        }
    }
}