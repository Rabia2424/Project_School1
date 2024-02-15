﻿using System;
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
    public partial class FormLesson : Form
    {
        public FormLesson()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_LessonTableAdapter ds = new DataSet1TableAdapters.Tbl_LessonTableAdapter();
        private void FormLesson_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.LessonList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ds.LessonAdd(TxtLessonName.Text);
            MessageBox.Show("Lesson Added");
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.LessonList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ds.LessonDelete(byte.Parse(TxtLessonId.Text));
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.LessonUpdate(TxtLessonName.Text, byte.Parse(TxtLessonId.Text));
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtLessonId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtLessonName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
