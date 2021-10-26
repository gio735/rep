using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SchoolP
{
    public partial class LoggedTeacher : UserControl
    {
        private bool _isProcessing;
        private int _leftToGrade;
        private User _currentlyGrading;
        private bool _allGotCanceled;
        XmlDocument xmlauth = new XmlDocument();
        private User currentUser;
        static int homeworkId = 0;
        public LoggedTeacher(User user)
        {
            InitializeComponent();
            TeacherDataLabel.Text = Form1.userData;
            TeacherDataLabel.ForeColor = Color.DeepSkyBlue;
            NoGradeDataFound.BackColor = Color.Transparent;
            NoGradeDataFound.ForeColor = Color.DeepSkyBlue;
            currentUser = user;

            xmlauth.Load("../../CourseData.xml");
            try
            {
                foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
                {
                    if (course.SelectSingleNode("teacherId").InnerText == currentUser.Id.ToString())
                    {
                        XmlNode students = course.SelectSingleNode("students");
                        foreach (XmlNode studentid in students)
                        {
                            User student = FindStudentWithId(int.Parse(studentid.InnerText));
                            if (student.Status != "Teacher")
                            {
                                StudentList.Rows.Add(false, student.Id, student.Name, student.Lastname);
                            }
                        }
                    }
                }
                
            }
            catch
            {

            }
        }
        private void GetLastHomeworkId()
        {

        }

        private void LoggedTeacher_Load(object sender, EventArgs e)
        {
            xmlauth.Load("../../CourseData.xml");
        }

        private void teacherLogOut_Click(object sender, EventArgs e)
        {
            Form1.mainForm.pnlContainer.Controls["LoggedTeacher"].Dispose();
            Form1.mainForm.pnlContainer.Hide();
        }

        private void StudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeacherDataLabel_Click(object sender, EventArgs e)
        {

        }
        private User FindStudentWithId(int id)
        {
            foreach (User user in Form1.registeredUsers)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in StudentList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    ids.Add(int.Parse(row.Cells[1].Value.ToString()));
                }
            }
            StudentGrades.Series.Clear();
            foreach (int id in ids)
            {
                int i = 0;

                User currentStudent = FindStudentWithId(id);
                StudentGrades.Series.Add(currentStudent.Username);
                foreach (Grade grade in currentStudent.Grades)
                {
                    i++;
                    StudentGrades.Series[currentStudent.Username].Points.AddXY(i, grade.Mark);
                }
                if (currentStudent.Grades.Count == 0)
                {
                    StudentGrades.Series.RemoveAt(StudentGrades.Series.Count - 1);
                }
            }
            if (StudentGrades.Series.Count != 0)
            {
                StudentGrades.Show();
                ChartSwitcher.Show();
            }
            else
            {
                ChartSwitcher.Hide();
                ChartSwitcher.Text = "Hide";
                StudentGrades.Hide();
                NoGradeDataFound.Show();
                HideLabel();
            }

        }

        private void teacherLogOut_Click_1(object sender, EventArgs e)
        {
            Form1.mainForm.pnlContainer.Controls["LoggedTeacher"].Dispose();
            Form1.mainForm.pnlContainer.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ChartSwitcher_Click(object sender, EventArgs e)
        {
            if (ChartSwitcher.Text == "Hide")
            {
                StudentGrades.Hide();
                ChartSwitcher.Text = "Show";
            }
            else
            {
                StudentGrades.Show();
                ChartSwitcher.Text = "Hide";
            }
        }
        public async Task HideLabel()
        {
            await Task.Delay(2500);
            NoGradeDataFound.Hide();
        }

        private async void GradeGiver_ClickAsync(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in StudentList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    ids.Add(int.Parse(row.Cells[1].Value.ToString()));
                }
            }
            if (ids.Count > 0) { GradeGiver.Hide(); }
            _leftToGrade = ids.Count;
            foreach (int id in ids)
            {
                
                await GradeSingleStudent(FindStudentWithId(id));
                if (_allGotCanceled)
                {
                    _allGotCanceled = false;
                    break;
                }
            }
            GradeGiver.Show();
        }

        private async Task GradeSingleStudent(User currentStudent)
        {
            _currentlyGrading = currentStudent;
            TargetUsername.Text = currentStudent.Username;
            TargetUsername.Show();
            MarkToAddLabel.Show();
            MarkToAddBox.Show();
            AddGradeButton.Show();
            CancelButton.Show();
            if (_leftToGrade > 1)
            {
                CancelAllButton.Show();
            }
            _isProcessing = true;
            await Repeat(_isProcessing);
            CancelAllButton.Hide();
            if (_leftToGrade == 0)
            {
                TargetUsername.Hide();
                MarkToAddLabel.Hide();
                MarkToAddBox.Hide();
                AddGradeButton.Hide();
                CancelButton.Hide();
            }
        }
        private async Task Repeat(bool mustRepeat)
        {
            await Task.Delay(250);
            if (mustRepeat)
            {
                await Repeat(_isProcessing);
            }

        }

        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../UserList.xml");
            XmlNode newGrade = xmlauth.CreateElement("grade");
            newGrade.InnerText = MarkToAddBox.Text;
            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                if (user.SelectSingleNode("id").InnerText == _currentlyGrading.Id.ToString())
                {
                    user.SelectSingleNode("grades").AppendChild(newGrade);
                    _currentlyGrading.Grades.Add(new Grade(_currentlyGrading.Id, _currentlyGrading.Course,int.Parse(MarkToAddBox.Text)));
                    xmlauth.Save("../../UserList.xml");
                    _leftToGrade--;
                    _isProcessing = false;
                    break;
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _leftToGrade--;
            _isProcessing = false;
        }

        private void CancelAllButton_Click(object sender, EventArgs e)
        {
            _leftToGrade = 0;
            _allGotCanceled = true;
            _isProcessing = false;
        }

        private void TeacherPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void HomeworkManagement_Click(object sender, EventArgs e)
        {
            TeacherHomeworkForm teacherHomeworkForm = new TeacherHomeworkForm(currentUser);
            teacherHomeworkForm.Dock = DockStyle.Fill;
            Form1.mainForm.pnlContainer.Controls.Add(teacherHomeworkForm);
            Form1.mainForm.pnlContainer.Show();
            Form1.mainForm.pnlContainer.Controls["TeacherHomeworkForm"].BringToFront();
        }

        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
