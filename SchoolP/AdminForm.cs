using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SchoolP
{
    public partial class AdminForm : UserControl
    {
        XmlDocument xmlauth = new XmlDocument();
        private User _currentAndProbablyOnlyUserHere;
        public AdminForm(User account)
        {

            InitializeComponent();
            _currentAndProbablyOnlyUserHere = account;
            AdminDataLabel.Text = Form1.userData;
            foreach (User user in Form1.registeredUsers)
            {
                if (user.Status.ToLower() == "requester")
                {
                    TeacherCandidates.Rows.Add(user.Id, user.Name, user.Lastname);
                }
                if (user.Status.ToLower() == "student")
                {
                    GlobalStudentList.Rows.Add(user.Id, user.Username, user.Course, FindStudentsTeacherWithId(user.Id));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogOut_Click(object sender, EventArgs e)
        {
            Form1.mainForm.pnlContainer.Controls["AdminForm"].Dispose();
            Form1.mainForm.pnlContainer.Hide();
        }

        private void AdminDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeacherCandidates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TeacherChoiceBox.Text = $"{TeacherCandidates.SelectedRows[0].Cells[1].Value} {TeacherCandidates.SelectedRows[0].Cells[2].Value}";
                TeacherChoiceBox.Show();
            }
            catch
            {

            }

        }

        private void TeacherAcceptButton_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../UserList.xml");

            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                bool samePerson = user.SelectSingleNode("id").InnerText == TeacherCandidates.SelectedRows[0].Cells[0].Value.ToString();
                if (samePerson)
                {
                    user.SelectSingleNode("status").InnerText = "Teacher";
                    user.SelectSingleNode("course").InnerText = TeacherChoiceBox.Text;
                    xmlauth.Save("../../UserList.xml");
                    Form1.mainForm.loadRegisteredUsers();
                    break;
                }
            }
            TeacherChoiceBox.Hide();

            xmlauth.Load("../../CourseData.xml");

            XmlNode course = xmlauth.CreateElement("courses");

            XmlNode courseName = xmlauth.CreateElement("name");
            courseName.InnerText = CourseSelectingSomewhatComboBox.Text;
            course.AppendChild(courseName);

            XmlNode courseTeacherId = xmlauth.CreateElement("teacherId");
            courseTeacherId.InnerText = TeacherCandidates.SelectedRows[0].Cells[0].Value.ToString();
            course.AppendChild(courseTeacherId);

            XmlNode courseStudents = xmlauth.CreateElement("students");
            course.AppendChild(courseStudents);

            xmlauth.DocumentElement.AppendChild(course);
            xmlauth.Save("../../CourseData.xml");
            RefreshDataGrids();
        }

        private void TeacherRejectButton_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../UserList.xml");

            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                bool samePerson = user.SelectSingleNode("id").InnerText == TeacherCandidates.SelectedRows[0].Cells[0].Value.ToString();
                if (samePerson)
                {
                    xmlauth.DocumentElement.RemoveChild(user);
                    xmlauth.Save("../../UserList.xml");
                    Form1.mainForm.loadRegisteredUsers();
                    break;
                }
            }
            TeacherChoiceBox.Hide();
            RefreshDataGrids();
        }

        private void GlobalStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StudentRegroupBox.Text = $"{GlobalStudentList.SelectedRows[0].Cells[1].Value}";
                TeacherSelectorCombo.Items.Clear();
                foreach (string choice in GetTeachersOfCourse(GlobalStudentList.SelectedRows[0].Cells[2].Value.ToString()))
                {
                    TeacherSelectorCombo.Items.Add(choice);
                }
                StudentRegroupBox.Show();
            }
            catch
            {

            }
        }

        private int FindStudentsTeacherWithId(int id)
        {
            xmlauth.Load("../../CourseData.xml");
            foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
            {
                foreach (XmlNode studentId in course.SelectSingleNode("students").ChildNodes)
                {
                    if (studentId.InnerText == id.ToString())
                    {
                        return int.Parse(course.SelectSingleNode("teacherId").InnerText);
                    }
                }
            }
            return -1;
        }
        private List<string> GetTeachersOfCourse(string targetCourse)
        {
            List<string> answer = new List<string>();
            xmlauth.Load("../../CourseData.xml");
            foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
            {
                if (course.SelectSingleNode("name").InnerText == targetCourse)
                {
                    string fullName = TeacherDataById(int.Parse(course.SelectSingleNode("teacherId").InnerText));
                    answer.Add($"{course.SelectSingleNode("teacherId").InnerText} {fullName}");
                }
            }
            return answer;
        }

        private string TeacherDataById(int id)
        {
            foreach (User user in Form1.registeredUsers)
            {
                if (user.Id == id)
                {
                    return $"{user.Name} {user.Lastname}";
                }
            }
            return "UNKNOWN";
        }

        private void StudentRegroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TeacherChoiceBox_Enter(object sender, EventArgs e)
        {

        }

        private void SwitchClass_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../CourseData.xml");
            XmlNode targetCourse = null;
            foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
            {
                bool isCurrentCourse = course.SelectSingleNode("teacherId").InnerText == GlobalStudentList.SelectedRows[0].Cells[3].Value.ToString();
                bool isTargetCourse = course.SelectSingleNode("teacherId").InnerText == TeacherSelectorCombo.Text;
                if (isTargetCourse) { targetCourse = course; }
                if (isCurrentCourse)
                {
                    foreach (XmlNode studentId in course.SelectSingleNode("students").ChildNodes)
                    {
                        bool isSameStudent = studentId.InnerText == GlobalStudentList.SelectedRows[0].Cells[0].Value.ToString();
                        if (isSameStudent)
                        {
                            course.SelectSingleNode("students").RemoveChild(studentId);
                            break;
                        }
                    }
                }
            }
            if (targetCourse != null)
            {
                XmlNode studentId = xmlauth.CreateElement("studentId");
                studentId.InnerText = GlobalStudentList.SelectedRows[0].Cells[0].Value.ToString();
                targetCourse.SelectSingleNode("students").AppendChild(studentId);
                xmlauth.Save("../../CourseData.xml");
            }
            else
            {
                foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
                {
                    string[] chosenTeacher = TeacherSelectorCombo.Text.Split(' ');
                    bool isTargetCourse = course.SelectSingleNode("teacherId").InnerText == chosenTeacher[0];
                    if (isTargetCourse)
                    {
                        targetCourse = course;
                        XmlNode studentId = xmlauth.CreateElement("studentId");
                        studentId.InnerText = GlobalStudentList.SelectedRows[0].Cells[0].Value.ToString();
                        targetCourse.SelectSingleNode("students").AppendChild(studentId);
                        xmlauth.Save("../../CourseData.xml");
                    }
                }
            }
            Form1.mainForm.loadRegisteredUsers();
            StudentRegroupBox.Hide();
            RefreshDataGrids();
        }

        private void RefreshDataGrids()
        {
            TeacherCandidates.Rows.Clear();
            GlobalStudentList.Rows.Clear();
            foreach (User user in Form1.registeredUsers)
            {
                if (user.Status.ToLower() == "requester")
                {
                    TeacherCandidates.Rows.Add(user.Id, user.Name, user.Lastname);
                }
                if (user.Status.ToLower() == "student")
                {
                    GlobalStudentList.Rows.Add(user.Id, user.Username, user.Course, FindStudentsTeacherWithId(user.Id));
                }
            }
        }
    }
}
