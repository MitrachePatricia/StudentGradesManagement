using StudentGradesManagement.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentGradesManagement.Forms
{
    public partial class StudentGrades : Form
    {
        private Student Student { get; set; }
        private Subject Subject { get; set; }

        private Dashboard Dashboard { get; set; }
        private void DisplayGrades()
        {
            lvGrades.Items.Clear();
            foreach (var subject in Dashboard.Subjects)
            {
                ListViewItem lvi = new ListViewItem(subject.subjectCODE.ToString());
                lvi.SubItems.Add(subject.subjectName);
                lvi.SubItems.Add(subject.profName);
                lvi.Tag = subject;
                lvGrades.Items.Add(lvi);
            }
        }
        public StudentGrades()
        {
            Dashboard = new Dashboard();
            InitializeComponent();
        }

        private void btnAddSubj_Click(object sender, EventArgs e)
        {
            AddSubject form = new AddSubject();
            Subject subject = new Subject();
            form.Subject = subject;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Subjects.Add(subject);
                DisplayGrades();
            }
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
        }
    }
}
