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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 837);
            this.Controls.Add(this.delete_Student);
            this.Controls.Add(this.Edit_Student);
            this.Controls.Add(this.Add_Student);
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Student;
        private System.Windows.Forms.Button Edit_Student;
        private System.Windows.Forms.Button delete_Student;
    }
}

