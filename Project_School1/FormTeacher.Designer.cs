namespace Project_School1
{
    partial class FormTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLesson = new System.Windows.Forms.Button();
            this.BtnClub = new System.Windows.Forms.Button();
            this.BtnExam = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.BtnStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLesson
            // 
            this.BtnLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLesson.Location = new System.Drawing.Point(12, 12);
            this.BtnLesson.Name = "BtnLesson";
            this.BtnLesson.Size = new System.Drawing.Size(312, 73);
            this.BtnLesson.TabIndex = 0;
            this.BtnLesson.Text = "Lesson ";
            this.BtnLesson.UseVisualStyleBackColor = true;
            this.BtnLesson.Click += new System.EventHandler(this.BtnLesson_Click);
            // 
            // BtnClub
            // 
            this.BtnClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClub.Location = new System.Drawing.Point(12, 115);
            this.BtnClub.Name = "BtnClub";
            this.BtnClub.Size = new System.Drawing.Size(312, 73);
            this.BtnClub.TabIndex = 1;
            this.BtnClub.Text = "Club ";
            this.BtnClub.UseVisualStyleBackColor = true;
            this.BtnClub.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnExam
            // 
            this.BtnExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExam.Location = new System.Drawing.Point(12, 211);
            this.BtnExam.Name = "BtnExam";
            this.BtnExam.Size = new System.Drawing.Size(312, 73);
            this.BtnExam.TabIndex = 2;
            this.BtnExam.Text = "Exam Mark";
            this.BtnExam.UseVisualStyleBackColor = true;
            this.BtnExam.Click += new System.EventHandler(this.BtnExam_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTeacher.Location = new System.Drawing.Point(12, 308);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Size = new System.Drawing.Size(312, 73);
            this.BtnTeacher.TabIndex = 3;
            this.BtnTeacher.Text = "Teacher";
            this.BtnTeacher.UseVisualStyleBackColor = true;
            // 
            // BtnStudent
            // 
            this.BtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStudent.Location = new System.Drawing.Point(12, 405);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Size = new System.Drawing.Size(312, 73);
            this.BtnStudent.TabIndex = 4;
            this.BtnStudent.Text = "Student";
            this.BtnStudent.UseVisualStyleBackColor = true;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(409, 508);
            this.Controls.Add(this.BtnStudent);
            this.Controls.Add(this.BtnTeacher);
            this.Controls.Add(this.BtnExam);
            this.Controls.Add(this.BtnClub);
            this.Controls.Add(this.BtnLesson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLesson;
        private System.Windows.Forms.Button BtnClub;
        private System.Windows.Forms.Button BtnExam;
        private System.Windows.Forms.Button BtnTeacher;
        private System.Windows.Forms.Button BtnStudent;
    }
}