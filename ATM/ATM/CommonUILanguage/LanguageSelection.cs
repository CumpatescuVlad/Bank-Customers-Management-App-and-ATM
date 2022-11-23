using ATM.App_functionality;
using ATM.Data;

namespace ATM
{
    public partial class LanguageSelection : UserControl
    {
        Temp temp = new();
        DataSource data = new DataSource();
        ATMOperations operation = new ATMOperations();

        public LanguageSelection()
        {
            InitializeComponent();
            romanianMenu1.Hide();
            englishMenu1.Hide();
            pinBox.Hide();
            enterBtn.Hide();
            enterBtnEnglish.Hide();
            authMsg.Hide();
        }

        #region UIBehaviour
        private void button1_Click(object sender, EventArgs e)
        {

            label1.Hide();
            label2.Hide();
            pinBox.Show();
            enterBtn.Show();
            enterBtnEnglish.Hide();
            button2.Hide();
            authMsg.Show();
            authMsg.Text = "Introduceti Codul PIN";
            button1.Hide();
            temp.CreateFile("Amount.txt", operation.Sold(temp.ReadFile("AccountIBAN.txt")));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Hide();
            label2.Hide();
            pinBox.Show();
            enterBtn.Hide();
            button1.Hide();
            enterBtnEnglish.Show();
            authMsg.Show();
            authMsg.Text = "Enter Credit Card PIN";
            button2.Hide();
            temp.CreateFile("Amount.txt", operation.Sold(temp.ReadFile("AccountIBAN.txt")));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void enterBtnEnglish_Click(object sender, EventArgs e)
        {
            data.Attempts--;

            if (data.Attempts < 0)
                Environment.Exit(0);

            if (String.IsNullOrEmpty(pinBox.Text))
            {
                MessageBox.Show("PLease Enter A Value!!!");
                return;

            }
            if (temp.ReadFile("CreditCardPIN.txt") != pinBox.Text)
            {
                MessageBox.Show($"Incorrect PIN!!!\nAttempts Remaining: {data.Attempts}");

                return;
            }

            englishMenu1.Show();
            englishMenu1.BringToFront();


        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            data.Attempts--;

            if (data.Attempts < 0)
                Environment.Exit(0);

            if (String.IsNullOrEmpty(pinBox.Text))
            {
                MessageBox.Show("Va Rog Introduceti O Valoare!!!.");
                return;

            }
            if (temp.ReadFile("CreditCardPIN.txt") != pinBox.Text)
            {
                MessageBox.Show($"PIN Gresit!!!\nIncercari Ramase: {data.Attempts}");

                return;
            }

            romanianMenu1.Show();
            romanianMenu1.BringToFront();
        }


    }
}
