namespace StudentGradesManagement.Forms
{
    partial class AddSubject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.tbSubjectCODE = new System.Windows.Forms.TextBox();
            this.errorSubjCODE = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSubjName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubjCODE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject CODE";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(46, 129);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Subject Name";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(46, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Professor Name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credits";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(65, 459);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(173, 47);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(323, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbPName
            // 
            this.tbPName.Location = new System.Drawing.Point(268, 212);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(235, 31);
            this.tbPName.TabIndex = 8;
            // 
            // nudCredits
            // 
            this.nudCredits.Location = new System.Drawing.Point(268, 287);
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(235, 31);
            this.nudCredits.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Final Grade";
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(268, 356);
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(235, 31);
            this.nudGrade.TabIndex = 11;
            // 
            // tbSubjectCODE
            // 
            this.tbSubjectCODE.Location = new System.Drawing.Point(268, 54);
            this.tbSubjectCODE.Name = "tbSubjectCODE";
            this.tbSubjectCODE.Size = new System.Drawing.Size(235, 31);
            this.tbSubjectCODE.TabIndex = 12;
            this.tbSubjectCODE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbSubjectCODE.Validating += new System.ComponentModel.CancelEventHandler(this.tbSubjectCODE_Validating);
            // 
            // errorSubjCODE
            // 
            this.errorSubjCODE.ContainerControl = this;
            // 
            // cbSubjName
            // 
            this.cbSubjName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjName.FormattingEnabled = true;
            this.cbSubjName.Items.AddRange(new object[] {
            "Programare evolutivă și algoritmi genetici",
            "Managementul riscului în afaceri internaționale",
            "Structuri de date",
            "Programare multiparadigmă - Java",
            "Programarea aplicațiilor Windows",
            "SGBD Oracle",
            "Macroeconomie cantitativă"});
            this.cbSubjName.Location = new System.Drawing.Point(268, 120);
            this.cbSubjName.Name = "cbSubjName";
            this.cbSubjName.Size = new System.Drawing.Size(235, 33);
            this.cbSubjName.TabIndex = 13;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 587);
            this.Controls.Add(this.cbSubjName);
            this.Controls.Add(this.tbSubjectCODE);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.tbPName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubjCODE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.NumericUpDown nudCredits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.TextBox tbSubjectCODE;
        private System.Windows.Forms.ErrorProvider errorSubjCODE;
        private System.Windows.Forms.ComboBox cbSubjName;
    }
}