using EmployeePortalWinforms.Persistence;


namespace EmployeePortalWinforms.CustomersUI
{
    public partial class DeleteCustomer : UserControl
    {
        public DeleteCustomer()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1,nullNameLbl,"Customer Name Cannot Be Null!");
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }

        }
    }
}
