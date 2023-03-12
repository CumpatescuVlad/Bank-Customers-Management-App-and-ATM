using EmployeePortalWinforms.BusinessLogic.Modeles;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class UpdateCustomerPhoneNumber : UserControl
    {
        private readonly HttpClient _httpClient;
        public UpdateCustomerPhoneNumber()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
            _httpClient = new HttpClient();
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

            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2, nullNewNameLbl, "Customer New Name Cannot Be Null!");

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            var updateThread = new Thread(UpdatePhoneNumber);
            updateThread.Start();
        }

        private void UpdatePhoneNumber()
        {
            var url = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var updateModel = new UpdateCustomerModel(textBox1.Text, "CustomerPhoneNumber", textBox2.Text);
            var updateContentSerialized = JsonConvert.SerializeObject(updateModel);
            var UpdateContent = new StringContent(updateContentSerialized, Encoding.UTF8, "aplication/json");
            var updatePhoneNumberResult = _httpClient.PutAsync(url, UpdateContent).Result;

            if (updatePhoneNumberResult.StatusCode is HttpStatusCode.OK)
            {
                succesPhoneUdapeLbl.Invoke((MethodInvoker)(() => succesPhoneUdapeLbl.Text = $"Customer Email Was Sucesfully Updated To :\b{textBox2.Text}"));
            }
        }
    }
}
