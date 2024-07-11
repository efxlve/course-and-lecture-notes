using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_School
{
    public partial class frmLesson : Form
    {
        public frmLesson()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_LessonsTableAdapter lesson = new DataSet1TableAdapters.Tbl_LessonsTableAdapter();

        void clear()
        {
            txtLessonID.Text = "";
            txtLessonName.Text = "";
        }
        
        void list()
        {
            dgvLesson.DataSource = lesson.LessonList();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLesson_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lesson.LessonAdd(txtLessonName.Text);
            MessageBox.Show("The lesson has been added to the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            list();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lesson.LessonRemove(byte.Parse(txtLessonID.Text));
            MessageBox.Show("The lesson has been deleted from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            list();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lesson.LessonUpdate(txtLessonName.Text, byte.Parse(txtLessonID.Text));
            MessageBox.Show("The lesson has been updated in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            list();
        }

        private void dgvLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLessonID.Text = dgvLesson.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLessonName.Text = dgvLesson.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
