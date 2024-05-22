namespace StudentGradesManagement.Forms
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.lvGrades = new System.Windows.Forms.ListView();
            this.chCODE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubjName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNoCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSubj = new System.Windows.Forms.Button();
            this.btnEditSubj = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slClasses = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSaveReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.lvGrades.Location = new System.Drawing.Point(26, 105);
            this.lvGrades.Name = "lvGrades";
            this.lvGrades.Size = new System.Drawing.Size(1174, 434);
            this.lvGrades.TabIndex = 0;
            this.lvGrades.UseCompatibleStateImageBehavior = false;
            this.lvGrades.View = System.Windows.Forms.View.Details;
            this.lvGrades.SelectedIndexChanged += new System.EventHandler(this.lvGrades_SelectedIndexChanged);
            // 
            // chCODE
            // 
            this.chCODE.Text = "Subject CODE";
            this.chCODE.Width = 162;
            // 
            // chSubjName
            // 
            this.chSubjName.Text = "Subject Name";
            this.chSubjName.Width = 180;
            // 
            // chProf
            // 
            this.chProf.Text = "Professor Name";
            this.chProf.Width = 248;
            // 
            // chGrade
            // 
            this.chGrade.DisplayIndex = 4;
            this.chGrade.Text = "Final Grade";
            this.chGrade.Width = 189;
            // 
            // chNoCredits
            // 
            this.chNoCredits.DisplayIndex = 3;
            this.chNoCredits.Text = "Credits";
            this.chNoCredits.Width = 149;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 317;
            // 
            // btnAddSubj
            // 
            this.btnAddSubj.Location = new System.Drawing.Point(117, 557);
            this.btnAddSubj.Name = "btnAddSubj";
            this.btnAddSubj.Size = new System.Drawing.Size(231, 40);
            this.btnAddSubj.TabIndex = 1;
            this.btnAddSubj.Text = "Add Subject";
            this.btnAddSubj.UseVisualStyleBackColor = true;
            this.btnAddSubj.Click += new System.EventHandler(this.btnAddSubj_Click);
            // 
            // btnEditSubj
            // 
            this.btnEditSubj.Location = new System.Drawing.Point(510, 557);
            this.btnEditSubj.Name = "btnEditSubj";
            this.btnEditSubj.Size = new System.Drawing.Size(231, 40);
            this.btnEditSubj.TabIndex = 2;
            this.btnEditSubj.Text = "Edit Subject";
            this.btnEditSubj.UseVisualStyleBackColor = true;
            this.btnEditSubj.Click += new System.EventHandler(this.btnEditSubj_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(907, 557);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(231, 40);
            this.btnDeleteSubject.TabIndex = 3;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slClasses});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1231, 42);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slClasses
            // 
            this.slClasses.Name = "slClasses";
            this.slClasses.Size = new System.Drawing.Size(301, 32);
            this.slClasses.Text = "No of classes enrolled in: 0";
            this.slClasses.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1231, 42);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSaveReport
            // 
            this.tsbSaveReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveReport.Image")));
            this.tsbSaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveReport.Name = "tsbSaveReport";
            this.tsbSaveReport.Size = new System.Drawing.Size(46, 36);
            this.tsbSaveReport.Text = "toolStripButton1";
            this.tsbSaveReport.Click += new System.EventHandler(this.tsbSaveReport_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 698);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnEditSubj);
            this.Controls.Add(this.btnAddSubj);
            this.Controls.Add(this.lvGrades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDashboard";
            this.Text = "DisplayGrades";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slClasses;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSaveReport;
    }
}