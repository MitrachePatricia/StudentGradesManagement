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

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Subject.subjectCODE = tbSubjectCODE.Text;
            Subject.subjectName = cbSubjName.Text;
            Subject.profName = tbPName.Text;
            Subject.noCredits = (int)nudCredits.Value;
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
            if (tbSubjectCODE.Text[0] != 'I' || tbSubjectCODE.Text[1] != 'E')
            {
                e.Cancel = true;
                errorSubjCODE.SetError((Control)sender, "This subject is not part of the 'Informatic Economics' profile.");
            }
        }
    }
}
