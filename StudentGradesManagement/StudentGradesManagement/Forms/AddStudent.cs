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

namespace StudentGradesManagement.Forms
{
    public partial class AddStudent : Form
    {
        public Student Student {  get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if(Student != null)
            {
                tbSName.Text = Student.studentName;
                cboxGroup.Text = Student.groupNo;
                //cboxSubject.Text = Student.Subjects();
            }
        }

        private void cboxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Student.studentName = tbSName.Text;
            Student.groupNo = cboxGroup.Text;
            //Student.Subjects() = cboxSubject.Text;
        }
    }
}
