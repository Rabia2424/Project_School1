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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClub fr = new FormClub();
            fr.Show();
        }

        private void BtnLesson_Click(object sender, EventArgs e)
        {
            FormLesson fr = new FormLesson();
            fr.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            FormStudent fr = new FormStudent();
            fr.Show();
        }

        private void BtnExam_Click(object sender, EventArgs e)
        {
            FormExamNot fr = new FormExamNot();
            fr.Show();
        }
    }
}
