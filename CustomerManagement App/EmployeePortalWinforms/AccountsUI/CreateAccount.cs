using System.Net;
using EmployeePortalWinforms.BusinessLogic.Modeles;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;
using System.Text;

namespace EmployeePortalWinforms.AccountsUI
{
    public partial class CreateAccount : UserControl
    {
        private readonly HttpClient _httpClient;
        public CreateAccount()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
            comboBox1.GotFocus += ComboBox1_GotFocus;
            textBox4.GotFocus += TextBox4_GotFocus;
            comboBox1.Items.Add("PersonalAccount");
            comboBox1.Items.Add("BusinessAccount");
            _httpClient = new HttpClient();
        }

        private void ComboBox1_GotFocus(object? sender, EventArgs e)
        {
            nullTypeOfAccountLbl.Text = string.Empty;
        }

        private void TextBox4_GotFocus(object? sender, EventArgs e)
        {
            nullBallanceLbl.Text = string.Empty;
        }


        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            nullAccountNameLbl.Text = string.Empty;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void createAccountBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2, nullAccountNameLbl, "Account Name Cannot Be Null!");
            Imput.NullImput(textBox4, nullBallanceLbl, "Ballance Cannot Be Null!");
            bool isNullImput = String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(textBox4.Text);
            if (isNullImput)
            {
                return;
            }
            string typeOfAccount = comboBox1.Text;
            accountSuccesfullyAdded.Text = "Working.....";
            var createAccountThread = new Thread(()=>PostAccount(typeOfAccount));
            createAccountThread.Start();
        }

        private void PostAccount(string typeOfAccount)
        {
            var uri = "https://localhost:7214/Portal/Account/CreateAccount";
            var accountData = new CreateAccountModel(textBox1.Text, textBox2.Text,typeOfAccount, int.Parse(textBox4.Text));
            var serializedContent = JsonConvert.SerializeObject(accountData);
            var content = new StringContent(serializedContent, Encoding.UTF8, "application/json");
            var accountResult = _httpClient.PostAsync(uri, content).Result;
            if (accountResult.StatusCode is HttpStatusCode.Created)
            {
                accountSuccesfullyAdded.Invoke((MethodInvoker)(() => accountSuccesfullyAdded.Text = "Account Sucesfully Added"));
            }
        }

    }
}
