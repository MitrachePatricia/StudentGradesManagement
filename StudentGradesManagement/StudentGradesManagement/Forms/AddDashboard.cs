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
    public partial class AddDashboard : Form
    {
        public Dashboard Dashboard { get; set; }
        public AddDashboard()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Dashboard.subjectId = (int)nudSubId.Value;
            Dashboard.finalGrade = (int)nudGrade.Value;
            Dashboard.hasCheated = cbCheated.Checked;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
