using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    public class Student
    {
        public int studentId {  get; set; }

        public string studentName {  get; set; }

        public string groupNo { get; set; }

        public Student() 
        {
            Subjects = new List<Subject>();
        }

        public Student(int studentId, string studentName, string groupNo) : this()
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.groupNo = groupNo;
        }   
        public List<Subject> Subjects { get; set; }

        
    }
}
