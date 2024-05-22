using StudentGradesManagement.Classes;
using StudentGradesManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManagement
{
    public partial class MainForm : Form
    {
        public Dashboard Dashboard {  get; set; }
        public MainForm()
        {
            Dashboard = new Dashboard();
            InitializeComponent();
        }

        private void DisplayStudents()
        {
            lvStudent.Items.Clear();
            foreach (var student in Dashboard.Students)
            {
                ListViewItem lvi = new ListViewItem(student.studentId.ToString());
                lvi.SubItems.Add(student.studentName);
                lvi.SubItems.Add(student.groupNo);
                lvi.Tag = student;
                lvStudent.Items.Add(lvi);
            }
        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            Student student = new Student();
            form.Student = student;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Students.Add(student);
                DisplayStudents();
            }
        }

        private void btnDisplayDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();

            if (lvStudent.SelectedItems.Count == 1)
            {
                Student student = lvStudent.SelectedItems[0].Tag as Student;
                form.Student = student;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplayStudents();
                }
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, Dashboard);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StudentGrades sg = new StudentGrades(); 
            sg.ShowDialog();
        }

        private void delete_Student_Click(object sender, EventArgs e)
        {

            if (lvStudent.SelectedItems.Count == 1)
            {
                Student student = lvStudent.SelectedItems[0].Tag as Student;
                Dashboard.Students.Remove(student);
                DisplayStudents();
            }
        }
    }
}
