using ProjectA.Models;
using ProjectA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA.Forms
{
    public partial class frmEmployeeDetail : Form
    {
        int employeeId;
        public frmEmployeeDetail(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }

        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {
            GetEmployeeById();
            GetCustomersByEmployeeId();
        }

        void GetEmployeeById()
        {
            using (EmployeeRepository employeeRepository = new EmployeeRepository())
            {
                Employee dataItem = employeeRepository.GetDataById(employeeId);
                if (dataItem != null)
                {
                    txtTitle.Text = dataItem.Title;
                    txtFirstName.Text = dataItem.FirstName;
                    txtLastName.Text = dataItem.LastName;
                    txtBirthDate.Text = dataItem.BirthDate.ToString("dd.MM.yyyy");
                    txtHireDate.Text = dataItem.HireDate.ToString("dd.MM.yyyy");

                    txtCountry.Text = dataItem.Country;
                    txtCity.Text = dataItem.City;
                    txtState.Text = dataItem.State;
                    txtAddress.Text = dataItem.Address;

                    txtPostalCode.Text = dataItem.PostalCode;
                    txtPhone.Text = dataItem.Phone;
                    txtFax.Text = dataItem.Fax;
                    txtEmail.Text = dataItem.Email;
                }
            }
        }
        
        void GetCustomersByEmployeeId()
        {
            using (CustomerRepository customerRepository = new CustomerRepository())
            {
                dgvCustomers.DataSource = customerRepository.GetAllByEmployeeId(employeeId);
            }
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerId = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
            frmInvoiceDetail frmInvoiceDetail = new frmInvoiceDetail(customerId);
            frmInvoiceDetail.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (EmployeeRepository employeeRepository = new EmployeeRepository())
            {
                employeeRepository.UpdateEmployee(txtPostalCode.Text,txtPhone.Text, txtFax.Text, txtEmail.Text, employeeId);
                MessageBox.Show("Your contact information has been updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
