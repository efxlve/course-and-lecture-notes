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
    public partial class frmClub : Form
    {
        public frmClub()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1FDQI1S;Initial Catalog=School;Integrated Security=True");

        void list()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Clubs", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvClub.DataSource = dataTable;
        }

        void clear()
        {
            txtClubID.Text = "";
            txtClubName.Text = "";
        }

        private void frmClub_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tbl_Clubs (Club_Name) VALUES (@p1)", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtClubName.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The club has been added to the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clear();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClubID.Text = dgvClub.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtClubName.Text = dgvClub.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Tbl_Clubs WHERE Club_ID = @p1", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtClubID.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The club has been deleted from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Clubs SET Club_Name = @p1 WHERE Club_ID = @p2", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtClubName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtClubID.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The club has been updated in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clear();
        }
    }
}
