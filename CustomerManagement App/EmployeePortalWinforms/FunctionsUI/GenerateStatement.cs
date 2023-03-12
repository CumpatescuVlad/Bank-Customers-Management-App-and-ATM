using EmployeePortalWinforms.Persistence;

namespace EmployeePortalWinforms.FunctionsUI
{
    public partial class GenerateStatement : UserControl
    {
        public GenerateStatement()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
            textBox3.GotFocus += TextBox3_GotFocus;
        }

        private void TextBox3_GotFocus(object? sender, EventArgs e)
        {
            nullAccountIBANLbl.Text = string.Empty;
        }

        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            nullAccountNameLbl.Text = string.Empty;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void GenerateStatement_Load(object sender, EventArgs e)
        {

        }

        private void generateStatementBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2, nullAccountNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox3, nullAccountIBANLbl, "Customer Name Cannot Be Null!");

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                return;
            }

        }
    }
}
