using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    public class Subject
    {
        public string subjectCODE { get; set; }
        public string subjectName { get; set; }
        public string profName { get; set; }
        public int finalGrade { get; set; }
        public int noCredits { get; set; }

        public Subject() { }

        public Subject(string subjectCODE, string subjectName, string profName, int finalGrade, int noCredits) : this()
        {
            this.subjectCODE = subjectCODE;
            this.subjectName = subjectName;
            this.profName = profName;
            this.finalGrade = finalGrade;
            this.noCredits = noCredits;
        }
    }
}
