using EmployeePortal.DataAccesLayer;
using EmployeePortal.Modeles;
using EmployeePortal.src;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class TransactionsLog : UserControl
    {
        private readonly ReadData readData = new ReadData();


        public TransactionsLog()
        {
            InitializeComponent();
            HideElements();

        }

        private void searchTransactionsLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(accountNumberBox.Text) || String.IsNullOrEmpty(customerFullNameBox.Text))
            {
                return;
            }

            else if (Imput.IsNumber(customerFullNameBox))
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            var transactionsModel = new TransactionModel()
            {
                AccountOwnerName = customerFullNameBox.Text,
                AccountNumber = accountNumberBox.Text,
                Order = "Date",
            };

            var transactions = readData.ReadTransactions(transactionsModel);

            richTextBox1.Text += $"{transactions.AccountOwnerName} {transactions.AccountNumber} {transactions.AccountName} {transactions.Amount} {transactions.Date}";

            if (transactions is null)
            {
                MessageBox.Show("Customer Not Found!");

                return;

            }

            ShowElements();


        }
        #region BoxesAndLabels
        private void customerFullNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region UIElements
        public void HideElements()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            richTextBox1.Hide();
            button1.Hide();
            generateStatementBtn.Hide();
            generateStatementTab1.Hide();


        }
        public void ShowElements()
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            richTextBox1.Show();
            button1.Show();
            generateStatementBtn.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideElements();
            richTextBox1.Clear();
            customerFullNameBox.Clear();
            accountNumberBox.Clear();
        }

        private void generateStatementBtn_Click(object sender, EventArgs e)
        {
            generateStatementTab1.Show();
            generateStatementTab1.BringToFront();

        }
        #endregion

    }
}
