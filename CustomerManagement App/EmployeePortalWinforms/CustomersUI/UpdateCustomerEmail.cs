using EmployeePortalWinforms.BusinessLogic.Modeles;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;

using System.Net;

using System.Text;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class UpdateCustomerEmail : UserControl
    {
        private readonly HttpClient _httpClient;
        public UpdateCustomerEmail()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
            _httpClient = new HttpClient();
        }

        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            nullEmailLbl.Text = string.Empty;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void updateEmail_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2, nullEmailLbl, "Customer Email Cannot Be Null!");
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }

            var updateEmailThread = new Thread(UpdateEmail);
            updateEmailThread.Start();

        }
        private  void UpdateEmail()
        {
            var url = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var updateModel = new UpdateCustomerModel(textBox1.Text, "CustomerEmail", textBox2.Text);
            var updateContentSerialized = JsonConvert.SerializeObject(updateModel);
            var UpdateContent = new StringContent(updateContentSerialized, Encoding.UTF8, "aplication/json");
            var updateEmailResult = _httpClient.PutAsync(url, UpdateContent).Result;

            if (updateEmailResult.StatusCode is HttpStatusCode.OK)
            {
                succesUpdateEmailLbl.Invoke((MethodInvoker)(() => succesUpdateEmailLbl.Text = $"Customer Email Was Sucesfully Updated To :\b{textBox2.Text}"));
            }

        }
    }
}
