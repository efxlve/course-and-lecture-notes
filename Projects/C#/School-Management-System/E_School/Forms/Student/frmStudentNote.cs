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
    public partial class frmStudentNote : Form
    {
        public frmStudentNote()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1FDQI1S;Initial Catalog=School;Integrated Security=True");

        public string ID;
        
        private void frmStudent_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Lesson_Name, Note_Exam1, Note_Exam2, Note_Exam3, Note_ProjectNote, Note_Average, Note_Status FROM Tbl_Notes INNER JOIN Tbl_Lessons ON Tbl_Notes.Note_LessonID = Tbl_Lessons.Lesson_ID WHERE Note_StudentID = @p1", connection);
            cmd.Parameters.AddWithValue("@p1", ID);
            //this.Text = ID.ToString();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
