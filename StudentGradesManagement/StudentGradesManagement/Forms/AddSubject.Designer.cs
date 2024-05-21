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
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Id";
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
            this.btnOk.Location = new System.Drawing.Point(67, 377);
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
            this.btnCancel.Location = new System.Drawing.Point(308, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(268, 54);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(235, 31);
            this.nudId.TabIndex = 6;
            this.nudId.ValueChanged += new System.EventHandler(this.nudId_ValueChanged);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(268, 129);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(235, 31);
            this.tbSName.TabIndex = 7;
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
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 490);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.tbPName);
            this.Controls.Add(this.tbSName);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.NumericUpDown nudCredits;
    }
}