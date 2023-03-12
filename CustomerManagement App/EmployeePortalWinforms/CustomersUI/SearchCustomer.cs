using EmployeePortalWinforms.BusinessLogic.DTOs;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class SearchCustomer : UserControl
    {
        private readonly HttpClient _httpClient;
        public SearchCustomer()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            customerInfoDisplay.Hide();
            textBox1.KeyDown += TextBox1_KeyDown;
            _httpClient = new HttpClient();
        }

        private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Return)
            {
                Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    return;
                }
                customerInfoDisplay.Show();
                customerInfoDisplay.Text = "Searching....";
                var customerThread = new Thread(() => GetCustomerInfo());
                customerThread.Start();
            }
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void searchCutomerBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            customerInfoDisplay.Show();
            customerInfoDisplay.Text = "Searching....";
            var customerThread = new Thread(() => GetCustomerInfo());
            customerThread.Start();
        }
        private async Task GetCustomerInfo()
        {
            var url = $"https://localhost:7214/Portal/Customer/Info/{textBox1.Text}";
            var customerDataResult = _httpClient.GetAsync(url).Result;
            var response = await customerDataResult.Content.ReadAsStringAsync().ConfigureAwait(false);
            var customerInfo = JsonConvert.DeserializeObject<CustomerModel>(response);

            customerInfoDisplay.Invoke((MethodInvoker)(() => customerInfoDisplay.Text = $"{customerInfo.CustomerName}  {customerInfo.CustomerPhoneNumber}  {customerInfo.CustomerEmail}"));

        }
    }
}
