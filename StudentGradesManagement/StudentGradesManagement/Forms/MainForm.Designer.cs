namespace StudentGradesManagement
{
    partial class MainForm
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
            this.Add_Student = new System.Windows.Forms.Button();
            this.Edit_Student = new System.Windows.Forms.Button();
            this.delete_Student = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Student
            // 
            this.Add_Student.Location = new System.Drawing.Point(48, 22);
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(194, 47);
            this.Add_Student.TabIndex = 0;
            this.Add_Student.Text = "Add Student";
            this.Add_Student.UseVisualStyleBackColor = true;
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // Edit_Student
            // 
            this.Edit_Student.Location = new System.Drawing.Point(307, 22);
            this.Edit_Student.Name = "Edit_Student";
            this.Edit_Student.Size = new System.Drawing.Size(194, 47);
            this.Edit_Student.TabIndex = 1;
            this.Edit_Student.Text = "Edit Student";
            this.Edit_Student.UseVisualStyleBackColor = true;
            // 
            // delete_Student
            // 
            this.delete_Student.Location = new System.Drawing.Point(557, 22);
            this.delete_Student.Name = "delete_Student";
            this.delete_Student.Size = new System.Drawing.Size(194, 47);
            this.delete_Student.TabIndex = 2;
            this.delete_Student.Text = "Delete Student";
            this.delete_Student.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.studName,
            this.groupNo});
            this.dataGridView1.Location = new System.Drawing.Point(48, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(721, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // studentId
            // 
            this.studentId.HeaderText = "ID";
            this.studentId.MinimumWidth = 10;
            this.studentId.Name = "studentId";
            this.studentId.Width = 200;
            // 
            // studName
            // 
            this.studName.HeaderText = "Name";
            this.studName.MinimumWidth = 10;
            this.studName.Name = "studName";
            this.studName.Width = 200;
            // 
            // groupNo
            // 
            this.groupNo.HeaderText = "Group";
            this.groupNo.MinimumWidth = 10;
            this.groupNo.Name = "groupNo";
            this.groupNo.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_Student);
            this.Controls.Add(this.Edit_Student);
            this.Controls.Add(this.Add_Student);
            this.Name = "MainForm";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Student;
        private System.Windows.Forms.Button Edit_Student;
        private System.Windows.Forms.Button delete_Student;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn studName;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNo;
    }
}

