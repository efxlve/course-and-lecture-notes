using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_School
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter student = new DataSet1TableAdapters.DataTable1TableAdapter();

        void list()
        {
            dgvStudent.DataSource = student.StudentList();
        }

        void clear()
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtStudentSurname.Text = "";
            cmbClub.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1FDQI1S;Initial Catalog=School;Integrated Security=True");

        private void frmStudent_Load(object sender, EventArgs e)
        {
            list();

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Clubs", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cmbClub.DisplayMember = "Club_Name";
            cmbClub.ValueMember = "Club_ID";
            cmbClub.DataSource = dataTable;
            connection.Close();
        }

        string gender = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            student.StudentAdd(txtStudentName.Text, txtStudentSurname.Text, byte.Parse(cmbClub.SelectedValue.ToString()), gender);
            MessageBox.Show("The student has been added to the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            student.StudentDelete(int.Parse(txtStudentID.Text));
            MessageBox.Show("The student has been deleted from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clear();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStudentSurname.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbClub.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            string chosen = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (chosen == "Female")
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            student.StudentUpdate(txtStudentName.Text, txtStudentSurname.Text, byte.Parse(cmbClub.SelectedValue.ToString()), gender,int.Parse(txtStudentID.Text));
            MessageBox.Show("The student has been updated in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            list();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
            {
                gender = "Male";
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked == true)
            {
                gender = "Female";
            }
        }
    }
}
