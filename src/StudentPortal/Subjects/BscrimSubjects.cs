using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Subjects
{
    internal class BscrimSubjects
    {
        public List<StudentSubject> getSubjectByYearLevelAndSemester(int yearLevel, int semester)
        {
            if (yearLevel == 1 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 02", "Ethics", "N/A", "N/A"),
                    new StudentSubject("GNED 2", "Art Appreciation", "N/A", "N/A"),
                    new StudentSubject("GNED 3", "Mathematics in the Modern World", "N/A", "N/A"),
                    new StudentSubject("GNED 4", "Mga Babasahin Hinggil sa Kasaysayan ng Pilipinas", "N/A", "N/A"),
                    new StudentSubject("CRIM 1", "Introduction to Criminology", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 1 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("GNED 5", "Purposive Communication", "N/A", "N/A"),
                    new StudentSubject("GNED 6", "Science, Technology and Society", "N/A", "N/A"),
                    new StudentSubject("GNED 10", "Gender and Society", "N/A", "N/A"),
                    new StudentSubject("CRIM 2", "Theories of Crime Causation", "N/A", "N/A"),
                    new StudentSubject("CLAW 2", "Human Rights Education", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("CRIM 3", "Human Behavior & Victimology", "N/A", "N/A"),
                    new StudentSubject("LEAD 2", "Comparative Models in Policing", "N/A", "N/A"),
                    new StudentSubject("LEAD 3", "Introduction to Industrial Security Administration", "N/A", "N/A"),
                    new StudentSubject("CDIN 1", "Fundamentals of Investigation and Intelligence", "N/A", "N/A"),
                    new StudentSubject("CDIN 2", "Specialized Crime Investigation 1 with Legal Medicine", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 2 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("CRIM 4", "Professional Conduct & Ethical Std.", "N/A", "N/A"),
                    new StudentSubject("CRIM 5", "Juvenile Del. & Juvenile Justice System", "N/A", "N/A"),
                    new StudentSubject("LEAD 4", "Law Enforcement Operations and Planning with Crime Mapping", "N/A", "N/A"),
                    new StudentSubject("CDIN 3", "Specialized Crime Investigation 2", "N/A", "N/A"),
                    new StudentSubject("CHEM 5", "General Chemistry (Organic)", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("FOSC 3", "Forensic Chemistry & Toxicology", "N/A", "N/A"),
                    new StudentSubject("FOSC 4", "Questioned Document Examination", "N/A", "N/A"),
                    new StudentSubject("CLAW 4-A", "Dispute Resolution & Crises/Incidents Mgmt.", "N/A", "N/A"),
                    new StudentSubject("CDIN 4", "Special Penal Laws ", "N/A", "N/A"),
                    new StudentSubject("CDIN 5", "Traffic Management and Accident Investigation with Driving", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 3 && semester == 2)
            {

                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("CRIM 7", "Criminological Research 1 (Res.Methods w/ Applied Statistics)", "N/A", "N/A"),
                    new StudentSubject("CLAW 5", "Evidence", "N/A", "N/A"),
                    new StudentSubject("FOSC 5", "Lie Detection Techniques", "N/A", "N/A"),
                    new StudentSubject("CDIN 6", "Fire Protection and Arson Investigation", "N/A", "N/A"),
                    new StudentSubject("CDIN 7", "Vice and Drug Education and Control", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 1)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("FOSC 6", "Forensic Ballistics", "N/A", "N/A"),
                    new StudentSubject("CLAW 6", "Criminal Procedure & Court Testimony", "N/A", "N/A"),
                    new StudentSubject("CDIN 9", "Introduction to Cybercrime and Digital Forensic Investigation", "N/A", "N/A"),
                    new StudentSubject("CDIN 10", "Environmental Laws & Protection with Disaster Risk Mitigation", "N/A", "N/A"),
                    new StudentSubject("CRIM 8", "Environmental Laws & Protection with Disaster Risk Mitigation", "N/A", "N/A")
                };
                return subjects;
            }
            else if (yearLevel == 4 && semester == 2)
            {
                List<StudentSubject> subjects = new List<StudentSubject>()
                {
                    new StudentSubject("CRIM 199", "Internship (On-the Job Training1&2) (540 Field Hours)", "N/A", "N/A"),
                    new StudentSubject("CRIM 198", "Competency Appraisal 2", "N/A", "N/A"),
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
