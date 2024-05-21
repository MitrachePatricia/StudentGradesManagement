using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Classes
{
    internal class Student
    {
        public int studentId {  get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int groupNo { get; set; }

        public Student() 
        {
            Subjects = new List<Subject>();
        }

        public Student(int studentId, string firstName, string lastName, int groupNo) : this()
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.groupNo = groupNo;
        }   
        public List<Subject> Subjects { get; set; }

        
    }
}
