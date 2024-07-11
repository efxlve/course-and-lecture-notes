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
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_NotesTableAdapter note = new DataSet1TableAdapters.Tbl_NotesTableAdapter();

        void list()
        {
            dgvNote.DataSource = note.NoteList(int.Parse(txtStudentID.Text));
        }

        void clear()
        {
            txtStudentID.Text = "";
            cmbLesson.Text = "";
            txtExam1.Text = "";
            txtExam2.Text = "";
            txtExam3.Text = "";
            txtProject.Text = "";
            txtAverage.Text = "";      
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            list();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1FDQI1S;Initial Catalog=School;Integrated Security=True");

        private void frmNote_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Lessons", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cmbLesson.DisplayMember = "Lesson_Name";
            cmbLesson.ValueMember = "Lesson_ID";
            cmbLesson.DataSource = dataTable;
            connection.Close();
        }

        int NoteID;
        private void dgvNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteID = int.Parse(dgvNote.CurrentRow.Cells[0].Value.ToString());
            txtStudentID.Text = dgvNote.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExam1.Text = dgvNote.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtExam2.Text = dgvNote.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtExam3.Text = dgvNote.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProject.Text = dgvNote.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAverage.Text = dgvNote.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtStatus.Text = dgvNote.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        int exam1, exam2, exam3, project;
        double average;
        string status;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            exam1 = int.Parse(txtExam1.Text);
            exam2 = int.Parse(txtExam2.Text);
            exam3 = int.Parse(txtExam3.Text);
            project = int.Parse(txtProject.Text);
            average = (exam1 + exam2 + exam3 + project) / 4;
            if (average >= 50)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }
            txtAverage.Text = average.ToString();
            txtStatus.Text = status;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            note.NoteUpdate(byte.Parse(cmbLesson.SelectedValue.ToString()), int.Parse(txtStudentID.Text), byte.Parse(txtExam1.Text), byte.Parse(txtExam2.Text), byte.Parse(txtExam3.Text), byte.Parse(txtProject.Text), decimal.Parse(txtAverage.Text), bool.Parse(txtStatus.Text), NoteID);
        }
    }
}
