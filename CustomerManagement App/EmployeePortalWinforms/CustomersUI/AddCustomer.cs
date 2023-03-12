using EmployeePortalWinforms.BusinessLogic.Modeles;
using EmployeePortalWinforms.Persistence;
using Newtonsoft.Json;
using System.Net;
using System.Text;


namespace EmployeePortalWinforms.CustomersUI
{
    public partial class AddCustomer : UserControl
    {
        private readonly HttpClient _httpClient;

        public AddCustomer()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
            textBox3.GotFocus += TextBox3_GotFocus;
            textBox4.GotFocus += TextBox4_GotFocus;
            _httpClient = new HttpClient();

        }

        private void TextBox4_GotFocus(object? sender, EventArgs e)
        {
            nullAccountNameLbl.Text = string.Empty;
        }

        private void TextBox3_GotFocus(object? sender, EventArgs e)
        {
            nullEmailLbl.Text = string.Empty;
        }

        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            nullPhoneNumberLbl.Text = string.Empty;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void insertCutomerBTN_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            Imput.NullImput(textBox2, nullPhoneNumberLbl, "Customer Phone  Cannot Be Null!");
            Imput.NullImput(textBox3, nullEmailLbl, "Customer Email Cannot Be Null!");
            Imput.NullImput(textBox4, nullAccountNameLbl, "Account Name Cannot Be Null!");

            bool nullImput = String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text);
            if (nullImput)
            {
                return;
            }
            var postCustomerThread = new Thread(PostCustomer);
            postCustomerThread.Start();
        }
        private void PostCustomer()
        {
            var url = "https://localhost:7214/Portal/Customer/AddNewCustomer";
            var customerModel = new AddCustomerModel(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text);
            var customerData = JsonConvert.SerializeObject(customerModel);
            var content = new StringContent(customerData, Encoding.UTF8, "application/json");
            var customerResult = _httpClient.PostAsync(url, content).Result;

            if (customerResult.StatusCode is HttpStatusCode.Created)
            {
                succesCustomerInsertionMessage.Invoke((MethodInvoker)(() => succesCustomerInsertionMessage.Text = "Customer Was Sucesfully Added"));
            }


        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
