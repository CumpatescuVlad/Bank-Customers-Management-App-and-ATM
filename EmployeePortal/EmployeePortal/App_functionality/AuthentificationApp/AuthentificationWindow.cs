using DataValidation;
using EmployeeInterface;
using System;
using System.Windows.Forms;

namespace EmployeePortal
{
    public partial class AuthentificationWindow : Form
    {
        #region Objects
        private readonly CustomerDataManagement data = new CustomerDataManagement();
        private readonly ReadEmployeeData read = new ReadEmployeeData();
        private readonly Credentials credentials = new Credentials();

        #endregion

        public AuthentificationWindow()
        {
            InitializeComponent();
            read.EmployeeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Errors.BoxIsEmpty(idBox.Text) is true || Errors.BoxIsEmpty(passwordBox.Text) is true)
            {
                return;
            }

            if (credentials.isMatching(idBox, passwordBox) is false)
            {
                data.Attempts--;
                attemptsMsg.Text = $"Wrong Password or ID , you have {data.Attempts} attempts left!";
                if (data.Attempts == 0)
                {
                    MessageBox.Show("You Excedded Maximum Number Of Attempts");
                    Temp.DisposeFile("Count.txt");
                    Environment.Exit(0);

                }

                idBox.Clear();
                passwordBox.Clear();
            }

            else if (credentials.isMatching(idBox, passwordBox) is true)
            {
                this.Close();
                Temp.DisposeFile("Count.txt");
                Temp.DisposeFile("EmployeeID.txt");
                Temp.DisposeFile("EmployeePassword.txt");
            }


        }
    }
}
