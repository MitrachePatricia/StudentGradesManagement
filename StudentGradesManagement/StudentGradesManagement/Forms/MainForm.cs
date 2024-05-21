using StudentGradesManagement.Classes;
using StudentGradesManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManagement
{
    public partial class MainForm : Form
    {
        private Dashboard Dashboard {  get; set; }
        public MainForm()
        {
            Dashboard = new Dashboard();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            Student student = new Student();
            form.Student = student;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Students.Add(student);
            }
        }
    }
}
