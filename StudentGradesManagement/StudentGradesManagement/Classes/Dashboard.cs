using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    public class Dashboard
    {
        public string dashboardId {  get; set; }
        public int finalGrade {  get; set; }

        public Boolean hasCheated { get; set; }

        public int studentId;
        public int subjectId;
        public List<Student> Students { get; set; }

        public Dashboard()
        {
            Students = new List<Student>();
        }
    }
}
