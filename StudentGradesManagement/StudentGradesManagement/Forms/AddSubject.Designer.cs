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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.label = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.errorSubjCODE = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSubjName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubjCODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(46, 51);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Subject Name";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(65, 226);
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
            this.btnCancel.Location = new System.Drawing.Point(323, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Final Grade";
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(268, 123);
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(235, 31);
            this.nudGrade.TabIndex = 11;
            this.nudGrade.ValueChanged += new System.EventHandler(this.nudGrade_ValueChanged);
            this.nudGrade.Validating += new System.ComponentModel.CancelEventHandler(this.nudGrade_Validating);
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
            this.cbSubjName.Location = new System.Drawing.Point(268, 42);
            this.cbSubjName.Name = "cbSubjName";
            this.cbSubjName.Size = new System.Drawing.Size(235, 33);
            this.cbSubjName.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.cbSubjName);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubjCODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.ErrorProvider errorSubjCODE;
        private System.Windows.Forms.ComboBox cbSubjName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}