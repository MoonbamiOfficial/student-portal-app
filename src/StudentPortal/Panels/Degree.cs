using StudentPortal.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels
{
    public partial class Degree : UserControl
    {
        public static Degree degree;
        public Degree()
        {
            InitializeComponent();
        }
        public static Degree getInstance()
        {
            if (degree == null)
            {
                degree = new Degree();
                return degree;
            }
            else
            {
                return degree;
            }
        }

        Bitmap bit;
        private void captureCardPanel()
        {
            bit = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bit, new Rectangle(0, 0, this.Width, this.Height));
        }
        //
        //  Captures the whole user control and save it as a PNG with a title of "My Card"
        //
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCard = new SaveFileDialog();
            saveCard.Filter = "PNG Image|*.png";
            saveCard.FileName = "My Card";
            saveCard.InitialDirectory = "Downloads";
            saveCard.RestoreDirectory = true;

            if(saveCard.ShowDialog() == DialogResult.OK)
            {
                downloadBtn.Hide();
                captureCardPanel();
                bit.Save(saveCard.FileName, System.Drawing.Imaging.ImageFormat.Png);
                downloadBtn.Show();
            }
        }
        private void setDegreeInformation()
        {
            studentName.Text = StudentInfo.fullname;
            studentCourse.Text = StudentInfo.course;
            studentNumber.Text = StudentInfo.stuNumber.ToString();
            string yearLevel;
            switch (StudentInfo.yearLvl)
            {
                case 1:
                    yearLevel = "1st Year";
                    break;
                case 2:
                    yearLevel = "2nd Year";
                    break;
                case 3:
                    yearLevel = "3rd Year";
                    break;
                case 4:
                    yearLevel = "4th Year";
                    break;
                default:
                    yearLevel = "did not match the cases";
                    break;
            }
            studentYearLevel.Text = yearLevel;
            studentStatus.Text = StudentInfo.status;
            switch (StudentInfo.semester)
            {
                case 1:
                    studentSemester.Text = "1st Semester";
                    break;
                case 2:
                    studentSemester.Text = "2nd Semester";
                    break;
                default:
                    studentSemester.Text = "did not match the cases";
                    break;
            }
        }
        public void setNewLabelCourseCodeColumn(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Width = 183;
            label.Height = 30;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Poppins", 12);
            label.TextAlign = ContentAlignment.MiddleCenter;

            courseCodes.Controls.Add(label);
        }
        public void setNewLabelCourseNameColumn(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Width = 464;
            label.Height = 30;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Poppins", 12);
            label.TextAlign = ContentAlignment.MiddleCenter;

            courseNames.Controls.Add(label);
        }
        public void setNewLabelMidtermColumn(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Width = 137;
            label.Height = 30;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Poppins", 12);
            label.TextAlign = ContentAlignment.MiddleCenter;
            midterms.Controls.Add(label);
        }
        public void setNewLabelFinalColumn(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Width = 136;
            label.Height = 30;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Poppins", 12);
            label.TextAlign = ContentAlignment.MiddleCenter;
            finals.Controls.Add(label);
        }
        private void Degree_Load(object sender, EventArgs e)
        {
            setDegreeInformation();
            // BSIT BSCS BSCRIM BSPSYCH
            switch(StudentInfo.course) {
                case "BSIT":
                    BsitSubjects bsitSubjects = new BsitSubjects();
                    List<StudentSubject> studentBSITSubjects = bsitSubjects.getSubjectByYearLevelAndSemester(StudentInfo.yearLvl, StudentInfo.semester);
                    foreach (StudentSubject subject in studentBSITSubjects)
                    {
                        setNewLabelCourseCodeColumn(subject.CourseCode);
                        setNewLabelCourseNameColumn(subject.CourseName);
                        setNewLabelMidtermColumn(subject.Midterm.ToString());
                        setNewLabelFinalColumn(subject.Finals.ToString());
                    }
                    break;
                case "BSCS":
                    BscsSubjects bscsSubjects = new BscsSubjects();
                    List<StudentSubject> studentBSCSSubjects = bscsSubjects.getSubjectByYearLevelAndSemester(StudentInfo.yearLvl, StudentInfo.semester);
                    foreach (StudentSubject subject in studentBSCSSubjects)
                    {
                        setNewLabelCourseCodeColumn(subject.CourseCode);
                        setNewLabelCourseNameColumn(subject.CourseName);
                        setNewLabelMidtermColumn(subject.Midterm.ToString());
                        setNewLabelFinalColumn(subject.Finals.ToString());
                    }
                    break;
                case "BSCRIM":
                    BscrimSubjects bscrimSubjects = new BscrimSubjects();
                    List < StudentSubject > studentBSCRIMSubjects = bscrimSubjects.getSubjectByYearLevelAndSemester(StudentInfo.yearLvl, StudentInfo.semester);
                    foreach (StudentSubject subject in studentBSCRIMSubjects)
                    {
                        setNewLabelCourseCodeColumn(subject.CourseCode);
                        setNewLabelCourseNameColumn(subject.CourseName);
                        setNewLabelMidtermColumn(subject.Midterm.ToString());
                        setNewLabelFinalColumn(subject.Finals.ToString());
                    }
                    break;
                case "BSPSYCH":
                    BspsychSubjects bspsychSubjects = new BspsychSubjects();
                    List<StudentSubject> studentBSPSYCHSubjects = bspsychSubjects.getSubjectByYearLevelAndSemester(StudentInfo.yearLvl, StudentInfo.semester);
                    foreach (StudentSubject subject in studentBSPSYCHSubjects)
                    {
                        setNewLabelCourseCodeColumn(subject.CourseCode);
                        setNewLabelCourseNameColumn(subject.CourseName);
                        setNewLabelMidtermColumn(subject.Midterm.ToString());
                        setNewLabelFinalColumn(subject.Finals.ToString());
                    }
                    break;
            }
        }
    }
}
