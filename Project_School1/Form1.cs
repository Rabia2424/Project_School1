using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_School1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormStudentNot fr = new FormStudentNot();
            fr.no = textBox1.Text;
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormTeacher fr = new FormTeacher();
            fr.Show();
            this.Hide();
        }

		
	}
}
