using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    [Serializable]
    public class Subject
    {
        public string subjectCODE { get; set; }
        public string subjectName { get; set; }
        public string profName { get; set; }
        public int finalGrade { get; set; }
        public int noCredits { get; set; }

        public Subject() { }

        public Subject(string subjectName, int finalGrade) : this()
        {
            this.subjectName = subjectName;
            this.finalGrade = finalGrade;
        }
        public void AutoSubj()
        {
            switch (subjectName)
            {
                case "Programare evolutivă și algoritmi genetici":
                    this.subjectCODE = "IE090";
                    this.noCredits = 4;
                    this.profName = "Denis Mihai";
                    break;
                case "Managementul riscului în afaceri internaționale":
                    this.subjectCODE = "IE091";
                    this.noCredits = 3;
                    this.profName = "John Lecter";
                    break;
                case "Structuri de date":
                    this.subjectCODE = "IE092";
                    this.noCredits = 4;
                    this.profName = "Katarina Bendon";
                    break;
                case "Programare multiparadigmă - Java":
                    this.subjectCODE = "IE093";
                    this.noCredits = 4;
                    this.profName = "Marian Georgescu";
                    break;
                case "Programarea aplicațiilor Windows":
                    this.subjectCODE = "IE094";
                    this.noCredits = 4;
                    this.profName = "Tomas Angelescu";
                    break;
                case "SGBD Oracle":
                    this.subjectCODE = "IE095";
                    this.noCredits = 4;
                    this.profName = "Jeriza Popescu";
                    break;
                case "Macroeconomie cantitativă":
                    this.subjectCODE = "IE096";
                    this.noCredits = 4;
                    this.profName = "Majorie Handau";
                    break;
            }
        }
    }
}
