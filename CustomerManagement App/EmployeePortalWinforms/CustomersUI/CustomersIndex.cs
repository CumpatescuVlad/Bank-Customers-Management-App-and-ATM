using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePortalWinforms.CustomersUI
{
    public partial class CustomersIndex : UserControl
    {
        public CustomersIndex()
        {
            InitializeComponent();
            searchCustomer1.Hide();
            addCustomer1.Hide();
            updateCustomerIndex1.Hide();
            deleteCustomer1.Hide();
            homeBTN.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchCustomer1.Show();
            searchCustomer1.BringToFront();
            homeBTN.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addCustomer1.Show();
            addCustomer1.BringToFront();
            homeBTN.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateCustomerIndex1.Show();
            updateCustomerIndex1.BringToFront();
            homeBTN.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteCustomer1.Show();
            deleteCustomer1.BringToFront();
            homeBTN.Show();
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            searchCustomer1.Hide();
            addCustomer1.Hide();
            updateCustomerIndex1.Hide();
            deleteCustomer1.Hide();
            homeBTN.Hide();
        }

        private void addCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void CustomersIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
