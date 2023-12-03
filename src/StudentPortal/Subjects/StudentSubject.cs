using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Subjects
{
    internal class StudentSubject
    {
        private string courseCode;
        private string courseName;
        private string midterm;
        private string finals;

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string Midterm { get => midterm; set => midterm = value; }
        public string Finals { get => finals; set => finals = value; }

        public StudentSubject(String courseCode, string courseName, string midterm, string finals ) {
            this.courseCode = courseCode;
            this.courseName = courseName;
            this.midterm = midterm;
            this.finals = finals;
        }

    }
}
