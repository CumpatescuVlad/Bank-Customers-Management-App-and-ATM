using ATM.App_functionality;

namespace ATM
{
    public partial class StandByMenu : UserControl
    {
        ATMOperations operation = new ATMOperations();

        public StandByMenu()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(creditCardNumberBox.Text))
            {
                MessageBox.Show("Please Enter A Value.");

                return;
            }

            operation.ReadCreditCardData(creditCardNumberBox.Text);

            this.Hide();
        }
    }
}
