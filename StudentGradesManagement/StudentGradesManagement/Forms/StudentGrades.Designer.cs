namespace StudentGradesManagement.Forms
{
    partial class StudentGrades
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
            this.lvGrades = new System.Windows.Forms.ListView();
            this.btnAddSubj = new System.Windows.Forms.Button();
            this.btnEditSubj = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.chSubjName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNoCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCODE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvGrades
            // 
            this.lvGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCODE,
            this.chSubjName,
            this.chProf,
            this.chGrade,
            this.chNoCredits,
            this.chStatus});
            this.lvGrades.FullRowSelect = true;
            this.lvGrades.HideSelection = false;
            this.lvGrades.Location = new System.Drawing.Point(24, 12);
            this.lvGrades.Name = "lvGrades";
            this.lvGrades.Size = new System.Drawing.Size(1174, 434);
            this.lvGrades.TabIndex = 0;
            this.lvGrades.UseCompatibleStateImageBehavior = false;
            this.lvGrades.View = System.Windows.Forms.View.Details;
            this.lvGrades.SelectedIndexChanged += new System.EventHandler(this.lvGrades_SelectedIndexChanged);
            // 
            // btnAddSubj
            // 
            this.btnAddSubj.Location = new System.Drawing.Point(122, 464);
            this.btnAddSubj.Name = "btnAddSubj";
            this.btnAddSubj.Size = new System.Drawing.Size(231, 40);
            this.btnAddSubj.TabIndex = 1;
            this.btnAddSubj.Text = "Add Subject";
            this.btnAddSubj.UseVisualStyleBackColor = true;
            this.btnAddSubj.Click += new System.EventHandler(this.btnAddSubj_Click);
            // 
            // btnEditSubj
            // 
            this.btnEditSubj.Location = new System.Drawing.Point(515, 464);
            this.btnEditSubj.Name = "btnEditSubj";
            this.btnEditSubj.Size = new System.Drawing.Size(231, 40);
            this.btnEditSubj.TabIndex = 2;
            this.btnEditSubj.Text = "Edit Subject";
            this.btnEditSubj.UseVisualStyleBackColor = true;
            this.btnEditSubj.Click += new System.EventHandler(this.btnEditSubj_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(912, 464);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(231, 40);
            this.btnDeleteSubject.TabIndex = 3;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // chSubjName
            // 
            this.chSubjName.Text = "Subject Name";
            this.chSubjName.Width = 152;
            // 
            // chProf
            // 
            this.chProf.Text = "Professor Name";
            this.chProf.Width = 182;
            // 
            // chGrade
            // 
            this.chGrade.Text = "Final Grade";
            this.chGrade.Width = 134;
            // 
            // chNoCredits
            // 
            this.chNoCredits.Text = "Number of Credits";
            this.chNoCredits.Width = 192;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 94;
            // 
            // chCODE
            // 
            this.chCODE.Text = "Subject CODE";
            this.chCODE.Width = 163;
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 536);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnEditSubj);
            this.Controls.Add(this.btnAddSubj);
            this.Controls.Add(this.lvGrades);
            this.Name = "StudentGrades";
            this.Text = "DisplayGrades";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGrades;
        private System.Windows.Forms.Button btnAddSubj;
        private System.Windows.Forms.Button btnEditSubj;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.ColumnHeader chSubjName;
        private System.Windows.Forms.ColumnHeader chProf;
        private System.Windows.Forms.ColumnHeader chGrade;
        private System.Windows.Forms.ColumnHeader chNoCredits;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chCODE;
    }
}