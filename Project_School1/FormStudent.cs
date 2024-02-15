using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_School1
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Rabia\SQLEXPRESS;Initial Catalog=Project_School;Integrated Security=True");


        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FormStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.StudentList();
            
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Club", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbClub.DisplayMember = "clubName";
            CmbClub.ValueMember = "clubId";
            CmbClub.DataSource = dt;    
            connection.Close();
        }

        string gender = "";
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                gender = "Woman";
            }
            if (radioButton2.Checked == true)
            {
                gender = "Man";
            }
            ds.StudentAdd(TxtStudentName.Text, TxtStudentSurname.Text, byte.Parse(CmbClub.SelectedValue.ToString()), gender);
            MessageBox.Show("Student Added");
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.StudentList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ds.StudentDelete(int.Parse(TxtStudentId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtStudentId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtStudentName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtStudentSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbClub.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (gender == "Woman")
            {
                radioButton1.Checked = true;
            }
            if(gender == "Man")
            {
                radioButton2.Checked = true;
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.StudentUpdate(TxtStudentName.Text, TxtStudentSurname.Text, byte.Parse(CmbClub.SelectedValue.ToString()), gender, int.Parse(TxtStudentId.Text ));
        }
    }
}
