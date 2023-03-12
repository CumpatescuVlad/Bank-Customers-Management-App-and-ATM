using EmployeePortalWinforms.BusinessLogic.Modeles;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class UpdateCustomerName : UserControl
    {
        private readonly HttpClient _httpClient;
        public UpdateCustomerName()
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

        private void updateCustomerNameBtn_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2, nullNewNameLbl, "Customer New Name Cannot Be Null!");
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            var updateNameThread = new Thread(UpdateName);
            updateNameThread.Start();
        }

        private void UpdateName()
        {
            var url = "https://localhost:7214/Portal/Update/UpdateCustomerData";
            var updateModel = new UpdateCustomerModel(textBox1.Text, "CustomerName", textBox2.Text);
            var updateContentSerialized = JsonConvert.SerializeObject(updateModel);
            var UpdateContent = new StringContent(updateContentSerialized, Encoding.UTF8, "aplication/json");
            var updateNameResult = _httpClient.PutAsync(url, UpdateContent).Result;

            if (updateNameResult.StatusCode is HttpStatusCode.OK)
            {
                succesNameUpdatedLbl.Invoke((MethodInvoker)(() => succesNameUpdatedLbl.Text = $"Customer Name Was Sucesfully Updated To :\b{textBox2.Text}"));
            }

        }
    }
}
