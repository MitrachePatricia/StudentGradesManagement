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
            Dashboard.Students.Clear();
            Dashboard.dashboardId = (int)nudDID.Value;
            Dashboard.studentId = (int)nudSubId.Value;
            Dashboard.date = DateTime.Now;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
