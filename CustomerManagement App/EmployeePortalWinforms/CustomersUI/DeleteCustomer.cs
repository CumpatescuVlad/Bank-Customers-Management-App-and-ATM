using EmployeePortalWinforms.Persistence;
using System.Net;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class DeleteCustomer : UserControl
    {
        private readonly HttpClient _httpClient;
        public DeleteCustomer()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
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
                var deleteCustomerThread = new Thread(DeleteCustomerRequest);
                deleteCustomerThread.Start();

            }
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            nullNameLbl.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imput.NullImput(textBox1, nullNameLbl, "Customer Name Cannot Be Null!");
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            var deleteCustomerThread = new Thread(DeleteCustomerRequest);
            deleteCustomerThread.Start();

        }
        private void DeleteCustomerRequest()
        {
            var url = $"https://localhost:7214/Portal/Customer/DeleteCustomer/{textBox1.Text}";
            var deleteResult = _httpClient.DeleteAsync(url).Result;

            if (deleteResult.StatusCode is HttpStatusCode.OK)
            {
                succesDeletetionMessage.Invoke((MethodInvoker)(() => succesDeletetionMessage.Text = $"Customer {textBox1.Text} was sucesfully deleted!"));
            }
        }
    }
}
