namespace StudentGradesManagement.Forms
{
    partial class AddStudent
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
            this.studName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjName = new System.Windows.Forms.Label();
            this.studGroup = new System.Windows.Forms.Label();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.cboxSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // studName
            // 
            this.studName.AutoSize = true;
            this.studName.Location = new System.Drawing.Point(42, 59);
            this.studName.Name = "studName";
            this.studName.Size = new System.Drawing.Size(148, 25);
            this.studName.TabIndex = 0;
            this.studName.Text = "Student Name";
            this.studName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 31);
            this.textBox1.TabIndex = 1;
            // 
            // subjName
            // 
            this.subjName.AutoSize = true;
            this.subjName.Location = new System.Drawing.Point(42, 211);
            this.subjName.Name = "subjName";
            this.subjName.Size = new System.Drawing.Size(84, 25);
            this.subjName.TabIndex = 2;
            this.subjName.Text = "Subject";
            // 
            // studGroup
            // 
            this.studGroup.AutoSize = true;
            this.studGroup.Location = new System.Drawing.Point(42, 132);
            this.studGroup.Name = "studGroup";
            this.studGroup.Size = new System.Drawing.Size(71, 25);
            this.studGroup.TabIndex = 3;
            this.studGroup.Text = "Group";
            this.studGroup.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboxGroup
            // 
            this.cboxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Items.AddRange(new object[] {
            "1070",
            "1071",
            "1072",
            "1073"});
            this.cboxGroup.Location = new System.Drawing.Point(214, 132);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(245, 33);
            this.cboxGroup.TabIndex = 4;
            // 
            // cboxSubject
            // 
            this.cboxSubject.FormattingEnabled = true;
            this.cboxSubject.Location = new System.Drawing.Point(214, 202);
            this.cboxSubject.Name = "cboxSubject";
            this.cboxSubject.Size = new System.Drawing.Size(245, 33);
            this.cboxSubject.TabIndex = 5;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 446);
            this.Controls.Add(this.cboxSubject);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.studGroup);
            this.Controls.Add(this.subjName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.studName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label subjName;
        private System.Windows.Forms.Label studGroup;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.ComboBox cboxSubject;
    }
}