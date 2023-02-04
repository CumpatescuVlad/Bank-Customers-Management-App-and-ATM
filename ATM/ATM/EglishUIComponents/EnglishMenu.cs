using ATM.App_functionality;

namespace ATM
{
    public partial class EnglishMenu : UserControl
    {
        ATMOperations atm = new ATMOperations();
        Temp temp = new Temp();
        public EnglishMenu()
        {
            InitializeComponent();
            yesBtn.Hide();
            NOBtn.Hide();
            backWardsBtn.Hide();
            DepositOrWithdrawBox.Hide();
            executeDepositBtn.Hide();
            executeWithdrawBtn.Hide();
            reciptMessageEnglish1.Hide();
            anotherTransactionsEnglish1.Hide();
        }

        #region UIBehaviour

        private void depositBtn_Click(object sender, EventArgs e)
        {
            HideElements("Enter Amount In RON.\n\n\n\nDeposit");
            temp.CreateFile("TypeOfRecipt.txt", "DepositRecipt");
            DepositOrWithdrawBox.Show();
            executeDepositBtn.Show();
            backWardsBtn.Show();
        }

        private void backWardsBtn_Click(object sender, EventArgs e)
        {
            ShowElements();
            executeDepositBtn.Hide();
            executeWithdrawBtn.Hide();
            reciptMessageEnglish1.Show();
            reciptMessageEnglish1.BringToFront();
            anotherTransactionsEnglish1.Show();
            anotherTransactionsEnglish1.BringToFront();
        }

        private void DepositOrWithdrawBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            HideElements("Enter Amount In RON.\n\n\n\nWithdraw");
            temp.CreateFile("TypeOfRecipt.txt", "WithdrawRecipt");
            DepositOrWithdrawBox.Show();
            executeWithdrawBtn.Show();
            backWardsBtn.Show();
        }

        private void yesBtn_Click(object sender, EventArgs e)
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

        private void NOBtn_Click(object sender, EventArgs e)
        {
            ShowElements();
        }
        public void HideElements(string message)
        {
            soldBtn.Hide();
            depositBtn.Hide();
            cancelBtn.Hide();
            withdrawBtn.Hide();
            MSG.Text = message;




        }
        public void ShowElements()
        {
            soldBtn.Show();
            depositBtn.Show();
            cancelBtn.Show();
            withdrawBtn.Show();
            MSG.Text = "Select Operation";
            backWardsBtn.Hide();
            DepositOrWithdrawBox.Hide();
            yesBtn.Hide();
            NOBtn.Hide();


        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            HideElements("Do You Want To Cancel?");
            yesBtn.Show();
            NOBtn.Show();
            backWardsBtn.Hide();


        }
        #endregion

        private void soldBtn_Click(object sender, EventArgs e)
        {
            HideElements($"Account Sold\n\n\n\nAvailabble Cash\n{atm.Sold(temp.ReadFile("AccountIBAN.txt"))}");
            temp.CreateFile("TypeOfRecipt.txt", "SoldRecipt");
            backWardsBtn.Show();
        }


        private void executeWithdrawBtn_Click(object sender, EventArgs e)
        {
            int currentAmount = int.Parse(temp.ReadFile("Amount.txt"));
            int amountToWithdraw = int.Parse(DepositOrWithdrawBox.Text);
            if (amountToWithdraw < 0 || amountToWithdraw > currentAmount)
            {
                MessageBox.Show("Insuficcient Funds.");
                return;
            }
            temp.CreateFile("Amount.txt", $"{currentAmount - amountToWithdraw}");
            atm.Withdraw(temp.ReadFile("AccountIBAN.txt"), int.Parse(temp.ReadFile("Amount.txt")));
            atm.InsertTransactionRecord(temp.ReadFile("AccountIBAN.txt"), amountToWithdraw, "Withdraw");
            temp.CreateFile("WithdrawedAmount.txt", $"{amountToWithdraw}");

            DepositOrWithdrawBox.Clear();
            //Send Email NOW

        }

        private void executeDepositBtn_Click(object sender, EventArgs e)
        {
            int currentAmount = int.Parse(temp.ReadFile("Amount.txt"));
            int amountToDeposit = int.Parse(DepositOrWithdrawBox.Text);
            if (amountToDeposit < 0)
            {
                MessageBox.Show("Introduce A Valid Number.");
                return;
            }
            temp.CreateFile("Amount.txt", $"{currentAmount += amountToDeposit}");
            atm.Deposit(temp.ReadFile("AccountIBAN.txt"), int.Parse(temp.ReadFile("Amount.txt")));
            atm.InsertTransactionRecord(temp.ReadFile("AccountIBAN.txt"), amountToDeposit, "Deposit");
            temp.CreateFile("DepositedAmount.txt", $"{amountToDeposit}");

            DepositOrWithdrawBox.Clear();
            //Send Email Now

        }
    }
}
