using System;
using EmployeePortalWinforms.Persistence;
namespace EmployeePortalWinforms.CustomersUI
{
    public partial class UpdateCustomerPhoneNumber : UserControl
    {
        public UpdateCustomerPhoneNumber()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
        }

        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            nullNewNameLbl.Text = string.Empty;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
           nullNameLbl.Text = string.Empty;
        }

        private void updatePhoneNumber_Click(object sender, EventArgs e)
        {

            Imput.NullImput(textBox1,nullNameLbl,"Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2,nullNewNameLbl,"Customer New Name Cannot Be Null!");

            if (String.IsNullOrEmpty(textBox1.Text)||String.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }

        }
    }
}
