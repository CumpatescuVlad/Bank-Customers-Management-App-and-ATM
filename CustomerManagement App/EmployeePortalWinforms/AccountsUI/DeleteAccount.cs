using EmployeePortalWinforms.BusinessLogic.Modeles;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace EmployeePortalWinforms.AccountsUI
{
    public partial class DeleteAccount : UserControl
    {
        private readonly HttpClient _httpClient;
        public DeleteAccount()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            comboBox1.Items.Add("PersonalAccount");
            comboBox1.Items.Add("BusinessAccount");
            _httpClient = new HttpClient();

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
            Imput.NullImput(textBox2, nullAccountLbl, "Account Name Cannot Be Null.");
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            accountSucesfullyDeleted.Text = "Working.....";
            string typeOfAccount = comboBox1.Text;
            var deleteAccountThread = new Thread(() => DeleteRequest(typeOfAccount));
            deleteAccountThread.Start();
        }
        private void DeleteRequest(string typeOfAccount)
        {
            var deleteAccountContent = new DeleteAccountModel(textBox1.Text, textBox2.Text, typeOfAccount);
            string uri = "https://localhost:7214/Portal/Account/DeleteAccount";
            var serilizedContent = JsonConvert.SerializeObject(deleteAccountContent);

            var deleteRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                Content = new StringContent(serilizedContent, Encoding.UTF8, "application/json"),
                RequestUri = new Uri(uri),
            };
            var deleteResult = _httpClient.SendAsync(deleteRequest).Result;

            if (deleteResult.StatusCode is HttpStatusCode.OK)
            {
                accountSucesfullyDeleted.Invoke((MethodInvoker)(() => accountSucesfullyDeleted.Text = "Account Was Sucesfully Deleted."));
            }


        }
    }
}
