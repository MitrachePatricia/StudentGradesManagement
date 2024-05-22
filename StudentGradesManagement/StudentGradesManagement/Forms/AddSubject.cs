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
    public partial class AddSubject : Form
    {
        public Subject Subject {  get; set; }
        public AddSubject()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            cbSubjName.Text = Subject.subjectName;
            nudGrade.Value = Subject.finalGrade;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Subject.subjectName = cbSubjName.Text;
            Subject.AutoSubj();
            Subject.finalGrade = (int)nudGrade.Value;
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSubjectCODE_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void nudGrade_Validating(object sender, CancelEventArgs e)
        {
            if (nudGrade.Value < 1 || nudGrade.Value > 10)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "This grade is not acceptable!!");
            }
        }

        private void nudGrade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
