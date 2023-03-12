namespace EmployeePortalWinforms.FunctionsUI
{
    public partial class FunctionsIndex : UserControl
    {
        public FunctionsIndex()
        {
            InitializeComponent();
            indexBTN.Hide();
            pinCodeRegeneration1.Hide();
            generateStatement1.Hide();

        }

        private void regeneratePinCode_Click(object sender, EventArgs e)
        {
            pinCodeRegeneration1.Show();
            pinCodeRegeneration1.BringToFront();
            indexBTN.Show();
        }

        private void statementBtn_Click(object sender, EventArgs e)
        {
            generateStatement1.Show();
            generateStatement1.BringToFront();
            indexBTN.Show();
        }

        private void indexBTN_Click(object sender, EventArgs e)
        {
            pinCodeRegeneration1.Hide();
            generateStatement1.Hide();
            indexBTN.Hide();
        }
    }
}
