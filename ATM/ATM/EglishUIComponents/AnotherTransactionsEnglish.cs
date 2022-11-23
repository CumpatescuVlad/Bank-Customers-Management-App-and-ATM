using ATM.App_functionality;

namespace ATM
{
    public partial class AnotherTransactionsEnglish : UserControl
    {
        Temp temp = new Temp();
        public AnotherTransactionsEnglish()
        {
            InitializeComponent();
        }

        private void YEsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NOBTN_Click(object sender, EventArgs e)
        {
            temp.DisposeFile("Amount.txt");
            temp.DisposeFile("AccountIBAN.txt");
            temp.DisposeFile("AccountName.txt");
            temp.DisposeFile("TypeOfRecipt.txt");
            temp.DisposeFile("AccountNumber.txt");
            temp.DisposeFile("CustomerName.txt");
            temp.DisposeFile("CreditCardPIN.txt");
            temp.DisposeFile("DepositedAmount.txt");
            temp.DisposeFile("WithdrawedAmount.txt");
            temp.DisposeFile("CreditCardNumber.txt");

            Environment.Exit(0);
        }
    }
}
