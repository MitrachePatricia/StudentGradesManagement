using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    [Serializable]
    public class Dashboard
    {
        public int dashboardId {  get; set; }

        public DateTime date { get; set; }

        public int studentId;
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public Dashboard()
        {
            Subjects = new List<Subject>();
            Students = new List<Student>();
        }
    }
}
