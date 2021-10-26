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
    public partial class StudentReportForm : UserControl
    {
        private User currentUser;
        XmlDocument xmlauth = new XmlDocument();
        XmlDocument xmlauthSecondary = new XmlDocument();
        int lastReportId;
        int SendingPhase = 1;
        public StudentReportForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            xmlauth.Load("../../Homework.xml");
            string teacherId = FindTeacherByStudentId(currentUser.Id);
            foreach (XmlNode homework in xmlauth.SelectSingleNode("homeworks").ChildNodes)
            {
                if (homework.SelectSingleNode("teacherId").InnerText == teacherId)
                {
                    homeworkList.Rows.Add(homework.SelectSingleNode("id").InnerText, teacherId, homework.SelectSingleNode("creationDate").InnerText, homework.SelectSingleNode("name").InnerText, homework.SelectSingleNode("status").InnerText);
                }
            }
            xmlauth.Load("../../ReportList.xml");
            lastReportId = int.Parse(xmlauth.SelectSingleNode("reports").LastChild.SelectSingleNode("id").InnerText);
        }

        private void homeworkList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xmlauth.Load("../../Homework.xml");
                foreach(XmlNode homework in xmlauth.SelectSingleNode("homeworks").ChildNodes)
                {
                    if (homework.SelectSingleNode("id").InnerText == homeworkList.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        ContentBox.Text = homework.SelectSingleNode("content").InnerText;
                        ContentBox.Show();
                        homeworkNameBox.Text = homework.SelectSingleNode("name").InnerText;
                        homeworkNameBox.Show();
                        if(homeworkList.SelectedRows[0].Cells[4].Value.ToString() == "valid" && !ReportSentAlready())
                        {
                            ReportCreator.Show();
                        }
                        else if (homeworkList.SelectedRows[0].Cells[4].Value.ToString() != "valid")
                        {
                            ReportCreator.Hide();
                        }
                        if (ReportSentAlready())
                        {
                            ReportViewer.Show();
                        }
                        else
                        {
                            ReportViewer.Hide();
                        }
                        break;
                    }
                }

            }
            catch
            {

            }
        }
        private bool ReportSentAlready()
        {
            xmlauthSecondary.Load("../../ReportList.xml");
            foreach(XmlNode report in xmlauthSecondary.SelectSingleNode("reports").ChildNodes)
            {
                if (report.SelectSingleNode("targetId").InnerText == homeworkList.SelectedRows[0].Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private static string FindTeacherByStudentId(int id)
        {
            XmlDocument xmlauth = new XmlDocument();
            xmlauth.Load("../../CourseData.xml");
            foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
            {
                foreach(XmlNode studentId in course.SelectSingleNode("students").ChildNodes)
                {
                    studentId.InnerText = id.ToString();
                    return course.SelectSingleNode("teacherId").InnerText;
                }
            }
            return "";
        }

        private void HomeworkViewer_Click_1(object sender, EventArgs e)
        {
            if (HomeworkViewer.Text == "Hide homeworks")
            {
                HomeworkViewer.Text = "View homeworks";
                homeworkNameBox.Hide();
                ContentBox.Hide();
                homeworkList.Hide();
            }
            else
            {
                HomeworkViewer.Text = "Hide homeworks";
                homeworkNameBox.Hide();
                homeworkList.Show();
                ContentBox.Hide();
                ContentBox.ReadOnly = true;
                ReportCreator.Hide();
                ReportViewer.Hide();
            }
        }

        private void ReturnToMonke_Click(object sender, EventArgs e)
        {
            Form1.mainForm.pnlContainer.Controls["StudentReportForm"].Dispose();
        }

        private void ReportCreator_Click(object sender, EventArgs e)
        {
            homeworkList.Hide();
            HomeworkViewer.Text = "View homeworks";
            homeworkNameBox.Hide();
            ContentBox.ReadOnly = false;
            ContentBox.Text = "";
            ReportCreator.Hide();
            ReportSender.Show();
        }

        private void ReportSender_Click(object sender, EventArgs e)
        {
            if (SendingPhase == 1)
            {
                SendingPhase++;
                SureMakingLabel.Show();
            }
            else
            {
                SendingPhase = 1;
                ContentBox.Hide();
                ReportSender.Hide();
                SureMakingLabel.Hide();
                SendReport();
            }
        }
        private void SendReport()
        {
            xmlauth.Load("../../ReportList.xml");

            XmlNode newReport = xmlauth.CreateElement("report");

            XmlNode newId = xmlauth.CreateElement("id");
            newId.InnerText = (lastReportId + 1).ToString();
            lastReportId++;
            newReport.AppendChild(newId);

            XmlNode newOwnerId = xmlauth.CreateElement("ownerId");
            newOwnerId.InnerText = currentUser.Id.ToString();
            newReport.AppendChild(newOwnerId);

            XmlNode newContent = xmlauth.CreateElement("content");
            newContent.InnerText = ContentBox.Text;
            newReport.AppendChild(newContent);

            XmlNode newDate = xmlauth.CreateElement("creationDate");
            newDate.InnerText = DateTime.Now.ToString();
            newReport.AppendChild(newDate);

            XmlNode newGrade = xmlauth.CreateElement("gradeTaken");
            newReport.AppendChild(newGrade);

            XmlNode newTarget = xmlauth.CreateElement("targetId");
            newTarget.InnerText = homeworkList.SelectedRows[0].Cells[0].Value.ToString();
            newReport.AppendChild(newTarget);

            xmlauth.DocumentElement.AppendChild(newReport);
            xmlauth.Save("../../ReportList.xml");
        }

        private void ReportViewer_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../ReportList.xml");
            foreach(XmlNode report in xmlauth.SelectSingleNode("reports").ChildNodes)
            {
                if (report.SelectSingleNode("targetId").InnerText == homeworkList.SelectedRows[0].Cells[0].Value.ToString())
                {
                    ContentBox.Text = report.SelectSingleNode("content").InnerText;
                    homeworkList.Hide();
                    ReportViewer.Hide();
                    HomeworkViewer.Text = "View homeworks";
                    break;
                }
            }
        }
    }
}
