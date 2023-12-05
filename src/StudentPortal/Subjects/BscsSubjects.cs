using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Subjects
{
    internal class BscsSubjects
    {
        public List<StudentSubject> getSubjectByYearLevelAndSemester(int yearLevel, int semester)
        {
            if (yearLevel == 1 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 02", "Ethics", "N/A", "N/A"),
                    new StudentSubject("GNED 05", "Purposive Communication", "N/A", "N/A"),
                    new StudentSubject("GNED 11", "Kontekswalisadong komunikasyon sa Filipino", "N/A", "N/A"),
                    new StudentSubject("COSC 50A", "Discrete Structure", "N/A", "N/A"),
                    new StudentSubject("DCIT 21A", "Introduction to computing", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 1 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("ITEC 50A", "Web System and Technologies 1", "N/A", "N/A"),
                    new StudentSubject("GNED 01", "ARTS APPRECIATION", "N/A", "N/A"),
                    new StudentSubject("GNED 12", "DALUMAT NG/SA FILIPINO", "N/A", "N/A"),
                    new StudentSubject("GNED 03", "MATHEMATICS IN THE MODERN WORLD", "N/A", "N/A"),
                    new StudentSubject("DCIT 23A", "Computer Programming 2 ", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 4", "MGA BABASAHIN HINGIL SA KASAYSAYAN NG FILIPINO", "N/A", "N/A"),
                    new StudentSubject("MATH  1A", "Analytic Geometry", "N/A", "N/A"),
                    new StudentSubject("COSC 55A", "Discrete Structure 2", "N/A", "N/A"),
                    new StudentSubject("COSC 60B", "Digital Login Design", "N/A", "N/A"),
                    new StudentSubject("DCIT 50A", "Object Oriented Programming", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 8", "UNDERSTANDING THE SELF", "N/A", "N/A"),
                    new StudentSubject("GNED 14", "Panitikang Panlipunan", "N/A", "N/A"),
                    new StudentSubject("MATH 2A", "Calculus", "N/A", "N/A"),
                    new StudentSubject("COSC 65B", "Architecture and Organization", "N/A", "N/A"),
                    new StudentSubject("COSC 70A", "Software Engineering 1", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("MATH 3A", "Linear Algebra", "N/A", "N/A"),
                    new StudentSubject("COSC 75A", "Software Engineering II", "N/A", "N/A"),
                    new StudentSubject("COSC 80B", "Operating System", "N/A", "N/A"),
                    new StudentSubject("COSC 85A", "Network and Communication", "N/A", "N/A"),
                    new StudentSubject("COSC 101", "CS elective 1(Computer Graphics and  Visual Computing ", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 2)
            {

                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 9", "RIZAL: LIFE, WORKS, AND WRITING", "N/A", "N/A"),
                    new StudentSubject("MATH 4B", "Experimental Statistics", "N/A", "N/A"),
                    new StudentSubject("COSC 90", "Design Analysis and Algorithm", "N/A", "N/A"),
                    new StudentSubject("COSC 95", "Programming Languages", "N/A", "N/A"),
                    new StudentSubject("COSC 106", "CS Elective 2(Introduction to game development)", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("ITEC 80D", "Human Computer Interaction", "N/A", "N/A"),
                    new StudentSubject("COSC 100B", "Automata Theory and Formal Languages", "N/A", "N/A"),
                    new StudentSubject("COSC 105", "Intelligent System", "N/A", "N/A"),
                    new StudentSubject("COSC 111B", "CS Elective 3(Internet of Things)", "N/A", "N/A"),
                    new StudentSubject("COSC200-A", "Undergraduate Thesis 1", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 07", "The  Contemporary World", "N/A", "N/A"),
                    new StudentSubject("COCS 110", "Numerical and Symbolic Computation", "N/A", "N/A"),
                    new StudentSubject("COSC 200-B", "Undergraduate Thesis II", "N/A", "N/A")

                };
                return subjects;
            }
            else
            {
                return null;
            }
        }
    }
}
