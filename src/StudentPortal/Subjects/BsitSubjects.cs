using StudentPortal.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Subjects
{
    internal class BsitSubjects
    {
        public List<StudentSubject> getSubjectByYearLevelAndSemester(int yearLevel, int semester)
        {
            if (yearLevel == 1 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 02", "ETHICS", "N/A", "N/A"),
                    new StudentSubject("GNED 05", "PURPOSIVE COMMUNICATION", "N/A", "N/A"),
                    new StudentSubject("GNED 11", "KONTEKSTWALISADONG KOMUNIKASYON SA FILIPINO", "N/A", "N/A"),
                    new StudentSubject("COSC 50", "DISCRETE STRUCTURE", "N/A", "N/A"),
                    new StudentSubject("DCIT 21", "INTRODUCTION TO COMPUTING", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 1 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 06", "SCIENECE, TECHNOLOGY AND SOCIETY", "N/A", "N/A"),
                    new StudentSubject("GNED 01", "ARTS APPRECIATION", "N/A", "N/A"),
                    new StudentSubject("GNED 12", "DALUMAT NG/SA FILIPINO ", "N/A", "N/A"),
                    new StudentSubject("GNED 03", "MATHEMATICS IN THE MODERN WORLD", "N/A", "N/A"),
                    new StudentSubject("DCIT 23", "COMPUTER PROGRAMMING 2", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 4", "MGA BABASAHIN HINGIL SA KASAYSAYAN NG FILIPINO", "N/A", "N/A"),
                    new StudentSubject("GNED 7", "THE CONTEMPORARY WOLRD", "N/A", "N/A"),
                    new StudentSubject("GNED 10", "GENDER AND SOCIETY", "N/A", "N/A"),
                    new StudentSubject("ITEC 55", "PLATFORM TECHNOLOGY", "N/A", "N/A"),
                    new StudentSubject("DCIT 24", "INFORMATION MANAGEMENT", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 8", "UNDERSTANDING THE SELF", "N/A", "N/A"),
                    new StudentSubject("DCIT 25", "DATA STRUCTURE AND ALGORITHM", "N/A", "N/A"),
                    new StudentSubject("ITEC 60", "INTEGRATED PROGRAMMING AND TECHNOLOGIES 1", "N/A", "N/A"),
                    new StudentSubject("ITEC 65", "OPEN SOURCE TECHNOLOGY", "N/A", "N/A"),
                    new StudentSubject("DCIT 55", "ADVANCE DATABASE SYSTEM", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("ITEC 80", "INTRODUCTION TO HUMAN COMPUTER INTERACTION", "N/A", "N/A"),
                    new StudentSubject("ITEC 85", "INFORMATION ASSURANCE AND SECURITY 1", "N/A", "N/A"),
                    new StudentSubject("ITEC 90", "NETWORKS AND FUNDAMENTALS", "N/A", "N/A"),
                    new StudentSubject("INSY 55", "SYSTEM ANALYSIS AND DESIGN", "N/A", "N/A"),
                    new StudentSubject("DCIT 26", "APPLICATION DEVELOPMENT AND EMERGING TECHNOLOGIES", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 2)
            {

                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 9", "RIZAL: LIFE, WORKS, AND WRITING", "N/A", "N/A"),
                    new StudentSubject("ITEC 95", "Quantitative Methods (Modelling and Simulation)", "N/A", "N/A"),
                    new StudentSubject("101", "IT ELECTIVE 1 (HUMAN COMPUTER INTERACTION 2)", "N/A", "N/A"),
                    new StudentSubject("106", "IT ELECTIVE 2 (WEB SYSTEM AND TECHNOLOGIES 2)", "N/A", "N/A"),
                    new StudentSubject("100", "INFORMATION ASSURANCE AND SECURITY 2", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("DCIT 65", "SOCIAL AND PROFESSIONAL ISSUE", "N/A", "N/A"),
                    new StudentSubject("ITEC 111", "IT ELECTIVE 3(INTEGRATED PROGRAMMING AND TECHNOLOGIES 2)", "N/A", "N/A"),
                    new StudentSubject("ITEC 116", "IT ELECTIVE 4(SYSTEM AND INTEGRATION AND ARCHITECTURE 2)", "N/A", "N/A"),
                    new StudentSubject("ITEC 110", "SYSTEM ADMINISTRATION AND MAINTENANCE", "N/A", "N/A"),
                    new StudentSubject("ITEC 200B", "CAPSTONE PROJECT AND RESEARCH 2", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("ITEC 199", "PRACTICUM (MINIMUM 486 HOURS)", "N/A", "N/A"),
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
