using ATM.App_functionality;
namespace ATM
{
    public partial class RomanianMenu : UserControl
    {
        ATMOperations atm = new ATMOperations();
        Temp temp = new Temp();

        public RomanianMenu()
        {
            InitializeComponent();
            button1.Hide();
            backWardsBtn.Hide();
            noBtn.Hide();
            depositOrWithdrawBox.Hide();
            executeDepositBtn.Hide();
            executeWithdrawBtn.Hide();
            reciptMessage1.Hide();
            anotherTransaction1.Hide();

        }
        #region UIBehaviour
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            HideElements("Doriti Sa Anulati Operatiunea?");
            button1.Show();
            noBtn.Show();
            backWardsBtn.Hide();


        }
        public void HideElements(string message)
        {
            soldBtn.Hide();
            depositBtn.Hide();
            cancelBtn.Hide();
            withdrawBtn.Hide();
            msg.Text = message;
            backWardsBtn.Show();


        }
        public void ShowElements()
        {
            soldBtn.Show();
            depositBtn.Show();
            cancelBtn.Show();
            withdrawBtn.Show();
            msg.Text = "Selectati Operatia";
            backWardsBtn.Hide();
            depositOrWithdrawBox.Hide();
            button1.Hide();
            noBtn.Hide();

        }

        private void soldBtn_Click(object sender, EventArgs e)
        {
            HideElements($"Interogare Sold\n\n\n\nAveti Disponibil\n{atm.Sold(temp.ReadFile("AccountIBAN.txt"))}");
            temp.CreateFile("TypeOfRecipt.txt", "SoldRecipt");

        }


        private void depositBtn_Click(object sender, EventArgs e)
        {
            HideElements("Introduceti Suma In Lei.\n\n\n\nDepunere Numerar");
            temp.CreateFile("TypeOfRecipt.txt", "DepositRecipt");
            depositOrWithdrawBox.Show();
            executeDepositBtn.Show();

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            HideElements("Introduceti Suma In LEi\n\n\n\nRetragere Numerar");
            temp.CreateFile("TypeOfRecipt.txt", "WithdrawRecipt");
            executeWithdrawBtn.Show();
            depositOrWithdrawBox.Show();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void noBtn_Click(object sender, EventArgs e)
        {
            ShowElements();
        }

        private void backWardsBtn_Click(object sender, EventArgs e)
        {

            ShowElements();
            executeDepositBtn.Hide();
            executeWithdrawBtn.Hide();
            depositOrWithdrawBox.Clear();
            reciptMessage1.Show();
            reciptMessage1.BringToFront();
            anotherTransaction1.Show();
            anotherTransaction1.BringToFront();


        }

        #endregion



        private void executeWithdrawBtn_Click(object sender, EventArgs e)
        {
            int currentAmount = int.Parse(temp.ReadFile("Amount.txt"));
            int amountToWithdraw = int.Parse(depositOrWithdrawBox.Text);
            if (amountToWithdraw < 0 || amountToWithdraw > currentAmount)
            {
                MessageBox.Show("Fonduri Insuficiente.");

                return;
            }

            temp.CreateFile("Amount.txt", $"{currentAmount - amountToWithdraw}");
            atm.Withdraw(temp.ReadFile("AccountIBAN.txt"), int.Parse(temp.ReadFile("Amount.txt")));
            atm.InsertTransactionRecord(temp.ReadFile("AccountIBAN.txt"), amountToWithdraw, "Withdraw");
            temp.CreateFile("WithdrawedAmount.txt", $"{amountToWithdraw}");

            depositOrWithdrawBox.Clear();
            //Send Email NOW

        }

        private void executeDepositBtn_Click(object sender, EventArgs e)
        {
            int currentAmount = int.Parse(temp.ReadFile("Amount.txt"));
            int amountToDeposit = int.Parse(depositOrWithdrawBox.Text);
            if (amountToDeposit < 0)
            {
                MessageBox.Show("Introduceti Un Numar Valid.");

                return;
            }
            temp.CreateFile("Amount.txt", $"{currentAmount += amountToDeposit}");
            atm.Deposit(temp.ReadFile("AccountIBAN.txt"), int.Parse(temp.ReadFile("Amount.txt")));
            atm.InsertTransactionRecord(temp.ReadFile("AccountIBAN.txt"), amountToDeposit, "Deposit");

            temp.CreateFile("DepositedAmount.txt", $"{amountToDeposit}");
            depositOrWithdrawBox.Clear();
            //Send Email Now

        }
    }
}
