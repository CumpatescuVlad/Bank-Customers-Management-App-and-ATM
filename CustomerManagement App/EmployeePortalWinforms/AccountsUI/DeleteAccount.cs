using EmployeePortalWinforms.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePortalWinforms.AccountsUI
{
    public partial class DeleteAccount : UserControl
    {
        public DeleteAccount()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void deleteAccountBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null.");
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
        }
    }
}
