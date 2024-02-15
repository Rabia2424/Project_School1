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
using System.Data.SqlClient;

namespace Project_School1
{
    public partial class FormExamNot : Form
    {
        public FormExamNot()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Rabia\SQLEXPRESS;Initial Catalog=Project_School;Integrated Security=True");


        DataSet1TableAdapters.Tbl_NotTableAdapter  ds = new DataSet1TableAdapters.Tbl_NotTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotList(int.Parse(TxtId.Text));
        }

        private void FormExamNot_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Lesson", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "lessonName";
            comboBox1.ValueMember = "lessonId";
            comboBox1.DataSource = dt;
            connection.Close();
        }

        int notId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtExam1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtExam2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtExam3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtAverage.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtSituation.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.NotUpdate(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(TxtId.Text), byte.Parse(TxtExam1.Text), byte.Parse(TxtExam2.Text), byte.Parse(TxtExam3.Text), byte.Parse(TxtProje.Text), decimal.Parse(TxtAverage.Text), bool.Parse(TxtSituation.Text),notId);
        }


       
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3, proje;
            double average;
            //string situation;
            exam1 = Convert.ToInt32(TxtExam1.Text);
            exam2 = Convert.ToInt32(TxtExam2.Text);
            exam3 = Convert.ToInt32(TxtExam3.Text);
            proje = Convert.ToInt32(TxtProje.Text);
            average = (exam1 + exam2 + exam3 + proje) / 4;
            TxtAverage.Text = average.ToString();
            if (average >= 50)
            {
                TxtSituation.Text = "True";
            }
            else
            {
                TxtSituation.Text = "False";
            }
        }
    }
}
