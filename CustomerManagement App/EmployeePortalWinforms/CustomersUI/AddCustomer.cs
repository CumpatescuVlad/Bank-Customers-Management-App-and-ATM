using EmployeePortalWinforms.Persistence;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
            textBox3.GotFocus += TextBox3_GotFocus;
            textBox4.GotFocus += TextBox4_GotFocus;
        }

        private void TextBox4_GotFocus(object? sender, EventArgs e)
        {
            nullAccountNameLbl.Text =string.Empty;
        }

        private void TextBox3_GotFocus(object? sender, EventArgs e)
        {
            nullEmailLbl.Text = string.Empty;
        }

        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            nullPhoneNumberLbl.Text = string.Empty;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
           nullNameLbl.Text = string.Empty;
        }

        private void insertCutomerBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1,nullNameLbl,"Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2,nullPhoneNumberLbl,"Customer Phone  Cannot Be Null!");
            Imput.NullImput(textBox3,nullEmailLbl,"Customer Email Cannot Be Null!");
            Imput.NullImput(textBox4,nullAccountNameLbl,"Account Name Cannot Be Null!");

            bool nullImput = String.IsNullOrEmpty(textBox1.Text)||String.IsNullOrEmpty(textBox2.Text)||String.IsNullOrEmpty(textBox3.Text)||String.IsNullOrEmpty(textBox4.Text);
            if (nullImput) 
            { 
                return; 
            }
        }
    }
}
