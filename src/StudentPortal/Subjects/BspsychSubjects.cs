using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Subjects
{
    internal class BspsychSubjects
    {
        public List<StudentSubject> getSubjectByYearLevelAndSemester(int yearLevel, int semester)
        {
            if (yearLevel == 1 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY 50", "Introduction to Psychology", "N/A", "N/A"),
                    new StudentSubject("GNED 03", "Mathematics in the modern world ", "N/A", "N/A"),
                    new StudentSubject("GNED 05", "Purposive Communication", "N/A", "N/A"),
                    new StudentSubject("NSTP 1", "National Service Training Program 1", "N/A", "N/A"),
                    new StudentSubject("GNED 08", "Understanding the Self", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 1 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY 55", "Psychological Statistics", "N/A", "N/A"),
                    new StudentSubject("BPSY60", "Theories of Personalities", "N/A", "N/A"),
                    new StudentSubject("BIOL 5", "Biology for health science", "N/A", "N/A"),
                    new StudentSubject("Zool 1", "General Zoology", "N/A", "N/A"),
                    new StudentSubject("NSTP 2", "National Service training Program 2", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY 65", "Development Psychology", "N/A", "N/A"),
                    new StudentSubject("BPSY 70", "Filipino Psychology", "N/A", "N/A"),
                    new StudentSubject("BPSY 75 ", "Field Methods in Psychological", "N/A", "N/A"),
                    new StudentSubject("CHGO", "Gen. Chemistry w/ Organic Chemistry", "N/A", "N/A"),
                    new StudentSubject("FITT 3", "Physical Activities towards Health and Fitness 1", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY 80", "Abnormal Psychology", "N/A", "N/A"),
                    new StudentSubject("BPSY 85", "Psychological Assessment", "N/A", "N/A"),
                    new StudentSubject("BPSY 90", "Cognitive Psychological", "N/A", "N/A"),
                    new StudentSubject("GNED 14", "Panitikang Panlipunan", "N/A", "N/A"),
                    new StudentSubject("CHBH 14", "Biochemistry for health Science", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY 95", "Experimental Psychological", "N/A", "N/A"),
                    new StudentSubject("BPSY 100", "Industrial/Organization Psychological", "N/A", "N/A"),
                    new StudentSubject("GNED 07", "The Contemporary World", "N/A", "N/A"),
                    new StudentSubject("BHED 105", "Human Anatomy and Physiology", "N/A", "N/A"),
                    new StudentSubject("GNED 15", "World Literature", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 2)
            {

                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY", "Introduction to Counseling", "N/A", "N/A"),
                    new StudentSubject("BPSY", "Physiological/Biological Psychological", "N/A", "N/A"),
                    new StudentSubject("BPSY", "Clinical Psychology", "N/A", "N/A"),
                    new StudentSubject("BPSY", "Social Psychology", "N/A", "N/A"),
                    new StudentSubject("BPSY", "Research in Psychological ", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("BPSY 120", "Research in Psychological ", "N/A", "N/A"),
                    new StudentSubject("GNED 09", "Life and Works of Rizal", "N/A", "N/A"),
                    new StudentSubject("BPSY 198", "Competency Appraisal 2", "N/A", "N/A"),
                    new StudentSubject("GNED 02", "Ethics", "N/A", "N/A"),
                    new StudentSubject("GNED 13", "Retorika/Masining na Pagpapahayag", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 10", "Gender and Society", "N/A", "N/A"),
                    new StudentSubject("GNED 01", "Art Appreciation", "N/A", "N/A"),
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
