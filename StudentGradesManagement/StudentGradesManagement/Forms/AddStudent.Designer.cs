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
            this.tbSName = new System.Windows.Forms.TextBox();
            this.subjName = new System.Windows.Forms.Label();
            this.studGroup = new System.Windows.Forms.Label();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.cboxSubject = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(214, 58);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(431, 31);
            this.tbSName.TabIndex = 1;
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
            this.cboxGroup.Size = new System.Drawing.Size(431, 33);
            this.cboxGroup.TabIndex = 4;
            this.cboxGroup.SelectedIndexChanged += new System.EventHandler(this.cboxGroup_SelectedIndexChanged);
            // 
            // cboxSubject
            // 
            this.cboxSubject.FormattingEnabled = true;
            this.cboxSubject.Items.AddRange(new object[] {
            "Programare evolutivă și algoritmi genetici",
            "Managementul riscului în afaceri internaționale",
            "Structuri de date",
            "Programare multiparadigmă - Java",
            "Programarea aplicațiilor Windows",
            "SGBD Oracle",
            "Macroeconomie cantitativă"});
            this.cboxSubject.Location = new System.Drawing.Point(214, 202);
            this.cboxSubject.Name = "cboxSubject";
            this.cboxSubject.Size = new System.Drawing.Size(431, 33);
            this.cboxSubject.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(184, 286);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(134, 43);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 377);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboxSubject);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.studGroup);
            this.Controls.Add(this.subjName);
            this.Controls.Add(this.tbSName);
            this.Controls.Add(this.studName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studName;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label subjName;
        private System.Windows.Forms.Label studGroup;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.ComboBox cboxSubject;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}