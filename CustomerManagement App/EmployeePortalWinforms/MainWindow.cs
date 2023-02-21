namespace EmployeePortalWinforms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            customersIndex1.Hide();
            functionsIndex1.Hide();
            accountsIndex1.Hide();
            mainWindowBTN.Hide();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void customersBTN_Click(object sender, EventArgs e)
        {
            customersIndex1.Show();
            customersIndex1.BringToFront();
            mainWindowBTN.Show();
        }

        private void functionsBTN_Click(object sender, EventArgs e)
        {
            functionsIndex1.Show();
            functionsIndex1.BringToFront();
            mainWindowBTN.Show();

        }

        private void accountsManagement_Click(object sender, EventArgs e)
        {
            accountsIndex1.Show();
            accountsIndex1.BringToFront();
            mainWindowBTN.Show();
        }

        private void mainWindowBTN_Click(object sender, EventArgs e)
        {
            customersIndex1.Hide();
            mainWindowBTN.Hide();
            functionsIndex1.Hide();
            accountsIndex1.Hide();
        }
    }
}