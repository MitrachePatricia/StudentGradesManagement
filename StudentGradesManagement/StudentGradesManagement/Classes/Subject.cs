using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    internal class Subject
    {
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public string profName { get; set; }
        public int noCredits { get; set; }

        public Subject() { }

        public Subject(int subjectId, string subjectName, string profName, int noCredits) : this()
        {
            this.subjectId = subjectId;
            this.subjectName = subjectName;
            this.profName = profName;
            this.noCredits = noCredits;
        }
    }
}
