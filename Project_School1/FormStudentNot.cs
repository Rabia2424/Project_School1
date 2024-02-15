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
    public partial class FormStudentNot : Form
    {
        public FormStudentNot()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=Rabia\SQLEXPRESS;Initial Catalog=Project_School;Integrated Security=True");
        public string no;
        private void FormStudentNot_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT lessonName,exam1,exam2,exam3,proje,average,situation FROM Tbl_Not INNER JOIN Tbl_Lesson ON Tbl_Not.lessonId=Tbl_Lesson.lessonId WHERE studentId=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", no);
            //this.Text = no.ToString();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
