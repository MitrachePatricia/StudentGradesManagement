﻿namespace StudentGradesManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Add_Student = new System.Windows.Forms.Button();
            this.btnEditStud = new System.Windows.Forms.Button();
            this.delete_Student = new System.Windows.Forms.Button();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.chStudId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Student
            // 
            this.Add_Student.Location = new System.Drawing.Point(139, 56);
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(194, 47);
            this.Add_Student.TabIndex = 0;
            this.Add_Student.Text = "Add Student";
            this.Add_Student.UseVisualStyleBackColor = true;
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // btnEditStud
            // 
            this.btnEditStud.Location = new System.Drawing.Point(457, 56);
            this.btnEditStud.Name = "btnEditStud";
            this.btnEditStud.Size = new System.Drawing.Size(194, 47);
            this.btnEditStud.TabIndex = 1;
            this.btnEditStud.Text = "Edit Student";
            this.btnEditStud.UseVisualStyleBackColor = true;
            this.btnEditStud.Click += new System.EventHandler(this.btnEditStud_Click);
            // 
            // delete_Student
            // 
            this.delete_Student.Location = new System.Drawing.Point(762, 56);
            this.delete_Student.Name = "delete_Student";
            this.delete_Student.Size = new System.Drawing.Size(194, 47);
            this.delete_Student.TabIndex = 2;
            this.delete_Student.Text = "Delete Student";
            this.delete_Student.UseVisualStyleBackColor = true;
            this.delete_Student.Click += new System.EventHandler(this.delete_Student_Click);
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStudId,
            this.chName,
            this.chGroup});
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.HideSelection = false;
            this.lvStudent.Location = new System.Drawing.Point(74, 125);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(912, 513);
            this.lvStudent.TabIndex = 3;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
            this.lvStudent.DoubleClick += new System.EventHandler(this.btnDisplayDashboard_Click);
            this.lvStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvStudent_MouseDoubleClick);
            // 
            // chStudId
            // 
            this.chStudId.Text = "Student ID";
            this.chStudId.Width = 213;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 242;
            // 
            // chGroup
            // 
            this.chGroup.Text = "Group";
            this.chGroup.Width = 208;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 80);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 680);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lvStudent);
            this.Controls.Add(this.delete_Student);
            this.Controls.Add(this.btnEditStud);
            this.Controls.Add(this.Add_Student);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Student;
        private System.Windows.Forms.Button btnEditStud;
        private System.Windows.Forms.Button delete_Student;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.ColumnHeader chStudId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chGroup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
    }
}

