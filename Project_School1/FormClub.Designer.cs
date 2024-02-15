namespace Project_School1
{
    partial class FormClub
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtClubId = new System.Windows.Forms.TextBox();
			this.TxtClubName = new System.Windows.Forms.TextBox();
			this.BtnList = new System.Windows.Forms.Button();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(1, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(636, 168);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			//this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(141, 284);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Club ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(116, 330);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Club Name";
			// 
			// TxtClubId
			// 
			this.TxtClubId.Location = new System.Drawing.Point(220, 278);
			this.TxtClubId.Name = "TxtClubId";
			this.TxtClubId.Size = new System.Drawing.Size(219, 26);
			this.TxtClubId.TabIndex = 3;
			// 
			// TxtClubName
			// 
			this.TxtClubName.Location = new System.Drawing.Point(220, 324);
			this.TxtClubName.Name = "TxtClubName";
			this.TxtClubName.Size = new System.Drawing.Size(219, 26);
			this.TxtClubName.TabIndex = 4;
			// 
			// BtnList
			// 
			this.BtnList.Location = new System.Drawing.Point(12, 377);
			this.BtnList.Name = "BtnList";
			this.BtnList.Size = new System.Drawing.Size(136, 44);
			this.BtnList.TabIndex = 5;
			this.BtnList.Text = "LİST";
			this.BtnList.UseVisualStyleBackColor = true;
			this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.Location = new System.Drawing.Point(167, 377);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(136, 44);
			this.BtnUpdate.TabIndex = 6;
			this.BtnUpdate.Text = "UPDATE";
			this.BtnUpdate.UseVisualStyleBackColor = true;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.Location = new System.Drawing.Point(328, 377);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(136, 44);
			this.BtnAdd.TabIndex = 7;
			this.BtnAdd.Text = "ADD";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.Location = new System.Drawing.Point(485, 377);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(136, 44);
			this.BtnDelete.TabIndex = 8;
			this.BtnDelete.Text = "DELETE";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// FormClub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(633, 446);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.BtnList);
			this.Controls.Add(this.TxtClubName);
			this.Controls.Add(this.TxtClubId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormClub";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormClub";
			this.Load += new System.EventHandler(this.FormClub_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClubId;
        private System.Windows.Forms.TextBox TxtClubName;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
    }
}