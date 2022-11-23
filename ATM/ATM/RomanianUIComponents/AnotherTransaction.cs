using ATM.App_functionality;

namespace ATM
{
    public partial class AnotherTransaction : UserControl
    {
        Temp temp = new Temp();
        public AnotherTransaction()
        {
            InitializeComponent();
        }

        private void daBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void nuBtn_Click(object sender, EventArgs e)
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
