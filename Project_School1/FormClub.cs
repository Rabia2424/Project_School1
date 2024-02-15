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

namespace Project_School1
{
    public partial class FormClub : Form
    {
        public FormClub()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Rabia\SQLEXPRESS;Initial Catalog=Project_School;Integrated Security=True");

        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Club ", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FormClub_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Club (clubName) values (@p1)", connection);
            cmd.Parameters.AddWithValue("@p1", TxtClubName.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Club Added"," Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtClubId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtClubName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Club where clubId=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", TxtClubId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Club Deleted","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Club set clubName=@p1 where clubId=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", TxtClubName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtClubId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Club Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

	
	}
}
