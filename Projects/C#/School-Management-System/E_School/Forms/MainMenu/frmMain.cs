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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmStudentNote frm = new frmStudentNote();
            frm.ID = textBox1.Text;
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmTeacher frm = new frmTeacher();
            frm.Show();
            this.Hide();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
