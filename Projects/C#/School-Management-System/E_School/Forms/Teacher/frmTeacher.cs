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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            frmClub club = new frmClub();
            club.Show();
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            frmLesson lesson = new frmLesson();
            lesson.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            frmNote note = new frmNote();
            note.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
