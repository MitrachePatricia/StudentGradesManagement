namespace StudentGradesManagement.Forms
{
    partial class AddDashboard
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCheated = new System.Windows.Forms.CheckBox();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.nudSubId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(98, 302);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(165, 47);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(355, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grade";
            // 
            // cbCheated
            // 
            this.cbCheated.AutoSize = true;
            this.cbCheated.Location = new System.Drawing.Point(232, 244);
            this.cbCheated.Name = "cbCheated";
            this.cbCheated.Size = new System.Drawing.Size(125, 29);
            this.cbCheated.TabIndex = 10;
            this.cbCheated.Text = "Cheated";
            this.cbCheated.UseVisualStyleBackColor = true;
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(331, 161);
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(207, 31);
            this.nudGrade.TabIndex = 12;
            this.nudGrade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudSubId
            // 
            this.nudSubId.Location = new System.Drawing.Point(331, 88);
            this.nudSubId.Name = "nudSubId";
            this.nudSubId.Size = new System.Drawing.Size(207, 31);
            this.nudSubId.TabIndex = 13;
            // 
            // AddDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 399);
            this.Controls.Add(this.nudSubId);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.cbCheated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "AddDashboard";
            this.Text = "AddDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCheated;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.NumericUpDown nudSubId;
    }
}