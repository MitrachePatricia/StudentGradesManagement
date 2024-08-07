﻿using StudentGradesManagement.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;


namespace StudentGradesManagement.Forms
{
    public partial class StudentDashboard : Form
    {
        private Student Student { get; set; }
        private Subject Subject { get; set; }
        private Dashboard Dashboard { get; set; }

        int counter = 0;
        private void DisplayGrades()
        {
            lvGrades.Items.Clear();
            foreach (var subject in Dashboard.Subjects)
            {
                ListViewItem lvi = new ListViewItem(subject.subjectCODE.ToString());
                lvi.SubItems.Add(subject.subjectName);
                lvi.SubItems.Add(subject.profName);
                lvi.SubItems.Add(subject.finalGrade.ToString());
                lvi.SubItems.Add(subject.noCredits.ToString());
                if (subject.finalGrade >= 5) lvi.SubItems.Add("Passed");
                else lvi.SubItems.Add("Failed");
                lvi.Tag = subject;
                lvGrades.Items.Add(lvi);
            }
        }
        public StudentDashboard()
        {
            Dashboard = new Dashboard();
            InitializeComponent();
        }

        private void btnAddSubj_Click(object sender, EventArgs e)
        {
            counter++;
            AddSubject form = new AddSubject();
            Subject subject = new Subject();
            form.Subject = subject;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Subjects.Add(subject);
                DisplayGrades();
            }
            slClasses.Text = "No of classes enrolled in: " + counter;
        }

        private void lvGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEditSubj_Click(object sender, EventArgs e)
        {
            AddSubject form = new AddSubject();
            if (lvGrades.SelectedItems.Count == 1)
            {
                Subject subject = lvGrades.SelectedItems[0].Tag as Subject;
                form.Subject = subject;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplayGrades();
                }
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (lvGrades.SelectedItems.Count == 1)
            {
                Subject subject = lvGrades.SelectedItems[0].Tag as Subject;
                Dashboard.Subjects.Remove(subject);
                DisplayGrades();
            }
            counter--;
            slClasses.Text = "No of classes enrolled in: " + counter;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbSaveReport_Click(object sender, EventArgs e)
        {
                List<Subject> subjects = new List<Subject>(Dashboard.Subjects);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text file (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                  {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        if (subjects.Count == 0)
                        {
                            sw.WriteLine("The studet is not enrolled in any classes.");
                        }
                    sw.WriteLine("The student with the id " + Dashboard.studentId +
                        ",took " + subjects.Count + " classes.");
                        foreach (Subject subject in subjects)
                        {
                        string line = "Subject: " +
                            subject.subjectName + " with code " +
                            subject.subjectCODE + " got the grade " +
                            subject.finalGrade;
                            sw.WriteLine(line);
                        }
                        sw.Close();

                    }
                }
            
        }

        private void tsbPrintReport_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
