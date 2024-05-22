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
            this.studGroup = new System.Windows.Forms.Label();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStudId = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorStudName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStudName)).BeginInit();
            this.SuspendLayout();
            // 
            // studName
            // 
            this.studName.AutoSize = true;
            this.studName.Location = new System.Drawing.Point(42, 135);
            this.studName.Name = "studName";
            this.studName.Size = new System.Drawing.Size(148, 25);
            this.studName.TabIndex = 0;
            this.studName.Text = "Student Name";
            this.studName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(214, 134);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(431, 31);
            this.tbSName.TabIndex = 1;
            this.tbSName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSName_Validating);
            // 
            // studGroup
            // 
            this.studGroup.AutoSize = true;
            this.studGroup.Location = new System.Drawing.Point(42, 208);
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
            this.cboxGroup.Location = new System.Drawing.Point(214, 208);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(431, 33);
            this.cboxGroup.TabIndex = 4;
            this.cboxGroup.SelectedIndexChanged += new System.EventHandler(this.cboxGroup_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ID";
            // 
            // nudStudId
            // 
            this.nudStudId.Location = new System.Drawing.Point(214, 62);
            this.nudStudId.Name = "nudStudId";
            this.nudStudId.Size = new System.Drawing.Size(431, 31);
            this.nudStudId.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(184, 288);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(134, 43);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorStudName
            // 
            this.errorStudName.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 386);
            this.Controls.Add(this.nudStudId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.studGroup);
            this.Controls.Add(this.tbSName);
            this.Controls.Add(this.studName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStudName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studName;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label studGroup;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStudId;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorStudName;
    }
}