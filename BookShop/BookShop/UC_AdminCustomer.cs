using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UC_AdminCustomer : UserControl
    {
        private string customerID, name, address, email, username, password;
        /// <summary>
        /// This function starts to work when this form is created on runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AdminCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                List<Customer> CusList = Util.FillCustomerList();
                ListCustomers(CusList);
                dgvCustomer.Show();
                dgvCustomer.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Database db = new Database();
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public UC_AdminCustomer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function assigns datas into the datagrid for list. 
        /// </summary>
        /// <param name="_customers">This parameter is customer's list.</param>
        private void ListCustomers(List<Customer> _customers)
        {
            try
            {
                dgvCustomer.Rows.Clear();
                for (int i = 0; i < _customers.Count; i++)
                {
                    Customer tmp = new Customer(customerID, name, address, email, username, password);
                    tmp = (Customer)_customers[i];
                    dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[i].Cells[0].Value = tmp.CustomerID;
                    dgvCustomer.Rows[i].Cells[1].Value = tmp.Name;
                    dgvCustomer.Rows[i].Cells[2].Value = tmp.Username;
                    dgvCustomer.Rows[i].Cells[3].Value = tmp.Email;
                    dgvCustomer.Rows[i].Cells[4].Value = tmp.Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
