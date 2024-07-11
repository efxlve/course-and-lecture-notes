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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }

        void GetEmployees()
        {
            using (EmployeeRepository employeeRepository = new EmployeeRepository())
            {
                dgvEmployee.DataSource = employeeRepository.GetAll();
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var employeeId = (int) dgvEmployee.Rows[e.RowIndex].Cells[0].Value;
            frmEmployeeDetail frmEmployeeDetail = new frmEmployeeDetail(employeeId);
            frmEmployeeDetail.ShowDialog();
        }
    }
}
