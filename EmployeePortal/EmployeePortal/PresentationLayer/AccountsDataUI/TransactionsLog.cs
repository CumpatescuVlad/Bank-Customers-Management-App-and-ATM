using AccountOperations;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class TransactionsLog : UserControl
    {
        private readonly AccountManagement manage = new AccountManagement();


        public TransactionsLog()
        {
            InitializeComponent();
            HideElements();

        }

        private void searchTransactionsLog_Click(object sender, EventArgs e)
        {

            if (Errors.BoxIsEmpty(accountNumberBox.Text) is true || Errors.BoxIsEmpty(customerFullNameBox.Text) is true)
            {
                return;
            }
            else if (Errors.IsNumber(customerFullNameBox) is true)
            {
                MessageBox.Show("Name Cannot Contain Numbers.");

                return;
            }

            richTextBox1.Text = manage.ShowDefaultTransactions(customerFullNameBox.Text, accountNumberBox.Text);

            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Customer Not Found!");
                return;

            }
            manage.ShowTransactionsOrdered(customerFullNameBox.Text, accountNumberBox.Text, "Amount Desc");
            manage.ShowTransactionsOrdered(customerFullNameBox.Text, accountNumberBox.Text, "Date Asc");
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
