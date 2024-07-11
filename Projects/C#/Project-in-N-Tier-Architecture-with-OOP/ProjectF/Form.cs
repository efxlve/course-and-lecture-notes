using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace ProjectF
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityEmployee> list = LogicEmployee.LLEmployeeList();
            dgvEmployee.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityEmployee entityEmployee = new EntityEmployee();
            entityEmployee.Name = txtName.Text;
            entityEmployee.Surname = txtSurname.Text;
            entityEmployee.City = txtCity.Text;
            entityEmployee.Task = txtTask.Text;
            entityEmployee.Salary = Convert.ToInt32(txtSalary.Text);
            LogicEmployee.LLEmployeeAdd(entityEmployee);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityEmployee entityEmployee = new EntityEmployee();
            entityEmployee.Id = Convert.ToInt32(txtId.Text);
            LogicEmployee.LLEmployeeDelete(entityEmployee.Id); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityEmployee entityEmployee = new EntityEmployee();
            entityEmployee.Id = Convert.ToInt32(txtId.Text);
            entityEmployee.Name = txtName.Text;
            entityEmployee.Surname = txtSurname.Text;
            entityEmployee.City = txtCity.Text;
            entityEmployee.Task = txtTask.Text;
            entityEmployee.Salary = Convert.ToInt32(txtSalary.Text);
            LogicEmployee.LLEmployeeUpdate(entityEmployee);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtCity.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtTask.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtSalary.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
