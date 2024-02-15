namespace Project_School1
{
    partial class FormExamNot
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSituation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-27, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(117, 113);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(200, 26);
            this.TxtExam1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Exam1";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(117, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(200, 26);
            this.TxtId.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Lesson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Student ID";
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(117, 156);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(200, 26);
            this.TxtExam2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Exam2";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(427, 30);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(200, 26);
            this.TxtExam3.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Exam3";
            // 
            // TxtProje
            // 
            this.TxtProje.Location = new System.Drawing.Point(427, 75);
            this.TxtProje.Name = "TxtProje";
            this.TxtProje.Size = new System.Drawing.Size(200, 26);
            this.TxtProje.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Proje";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(427, 116);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(200, 26);
            this.TxtAverage.TabIndex = 49;
            //this.TxtAverage.TextChanged += new System.EventHandler(this.TxtAverage_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(353, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Average";
            // 
            // TxtSituation
            // 
            this.TxtSituation.Location = new System.Drawing.Point(427, 153);
            this.TxtSituation.Name = "TxtSituation";
            this.TxtSituation.Size = new System.Drawing.Size(200, 26);
            this.TxtSituation.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(349, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Situation";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(669, 12);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(117, 32);
            this.BtnCalculate.TabIndex = 52;
            this.BtnCalculate.Text = "CALCULATE";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(669, 59);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(117, 33);
            this.BtnUpdate.TabIndex = 53;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(669, 113);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 32);
            this.BtnClear.TabIndex = 54;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormExamNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(818, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtSituation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtProje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtExam3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtExam2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtExam1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExamNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExamNot";
            this.Load += new System.EventHandler(this.FormExamNot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSituation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}