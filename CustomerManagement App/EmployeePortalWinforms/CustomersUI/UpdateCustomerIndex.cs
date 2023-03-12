namespace EmployeePortalWinforms.CustomersUI
{
    public partial class UpdateCustomerIndex : UserControl
    {
        public UpdateCustomerIndex()
        {
            InitializeComponent();
            updateCustomerName1.Hide();
            updateCustomerEmail1.Hide();
            updateCustomerPhoneNumber1.Hide();
            updateIndex.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateCustomerName1.Show();
            updateCustomerName1.BringToFront();
            updateIndex.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateCustomerPhoneNumber1.Show();
            updateCustomerPhoneNumber1.BringToFront();
            updateIndex.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateCustomerEmail1.Show();
            updateCustomerEmail1.BringToFront();
            updateIndex.Show();
        }

        private void updateIndex_Click(object sender, EventArgs e)
        {
            updateCustomerName1.Hide();
            updateCustomerEmail1.Hide();
            updateCustomerPhoneNumber1.Hide();
            updateIndex.Hide();
        }
    }
}
