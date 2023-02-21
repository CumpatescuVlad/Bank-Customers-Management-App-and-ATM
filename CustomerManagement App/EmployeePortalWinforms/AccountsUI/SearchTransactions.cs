using System;
using EmployeePortalWinforms.Persistence;

namespace EmployeePortalWinforms.AccountsUI
{
    public partial class SearchTransactions : UserControl
    {
        public SearchTransactions()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void searchTransactionsBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1,nullNameLbl,"Customer Name cannot Be Null!");
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
        }
    }
}
