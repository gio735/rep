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
    public partial class TeacherHomeworkForm : UserControl
    {
        private User currentUser;
        XmlDocument xmlauth = new XmlDocument();
        int lastHomeworkId;
        int gradePhase = 1;
        public TeacherHomeworkForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            xmlauth.Load("../../Homework.xml");
            lastHomeworkId = int.Parse(xmlauth.SelectSingleNode("homeworks").LastChild.SelectSingleNode("id").InnerText);
            foreach (XmlNode homework in xmlauth.SelectSingleNode("homeworks").ChildNodes)
            {
                if (int.Parse(homework.SelectSingleNode("teacherId").InnerText) == currentUser.Id)
                {
                    homeworkList.Rows.Add(homework.SelectSingleNode("id").InnerText, homework.SelectSingleNode("creationDate").InnerText, homework.SelectSingleNode("name").InnerText, homework.SelectSingleNode("status").InnerText);
                }
            }
        }

        private void HomeworkViewer_Click(object sender, EventArgs e)
        {
            if (HomeworkViewer.Text == "Hide homeworks")
            {
                HomeworkViewer.Text = "View homeworks";
                homeworkNameBox.Hide();
                HomeworkBox.Hide();
                homeworkList.Hide();
            }
            else
            {
                RefreshDataGrid();
                HomeworkViewer.Text = "Hide homeworks";
                homeworkNameBox.Hide();
                HomeworkBox.Hide();
                homeworkList.Show();
                studentReportList.Hide();
                StatusChanger.Hide();
                ViewReports.Hide();
                PublishHomeworkButton.Hide();
            }

        }

        private void ReturnToMonke_Click(object sender, EventArgs e)
        {
            Form1.mainForm.pnlContainer.Controls["TeacherHomeworkForm"].Dispose();
        }

        private void multiUsedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                homeworkNameBox.Text = homeworkList.SelectedRows[0].Cells[2].Value.ToString();
                homeworkNameBox.ReadOnly = true;
                homeworkNameBox.Show();
                string homeworkContent = GetHomeworkContentById(int.Parse(homeworkList.SelectedRows[0].Cells[0].Value.ToString()));
                HomeworkBox.Text = homeworkContent;
                HomeworkBox.Show();
                ViewReports.Show();
                StatusChanger.Show();
            }
            catch
            {

            }
        }

        private string GetHomeworkContentById(int id)
        {
            string answer = "";
            xmlauth.Load("../../Homework.xml");
            foreach (XmlNode homework in xmlauth.SelectSingleNode("homeworks").ChildNodes)
            {
                if (int.Parse(homework.SelectSingleNode("id").InnerText) == id)
                {
                    answer = homework.SelectSingleNode("content").InnerText;
                }
            }
            return answer;
        }

        private void ViewReports_Click(object sender, EventArgs e)
        {
            ViewReports.Hide();
            homeworkList.Hide();
            HomeworkViewer.Text = "View homeworks";
            HomeworkBox.Hide();
            homeworkNameBox.Hide();
            StatusChanger.Hide();
            studentReportList.Show();
            studentReportList.Rows.Clear();
            xmlauth.Load("../../ReportList.xml");
            foreach (XmlNode report in xmlauth.SelectSingleNode("reports").ChildNodes)
            {
                if (report.SelectSingleNode("targetId").InnerText == homeworkList.SelectedRows[0].Cells[0].Value.ToString())
                {
                    studentReportList.Rows.Add(report.SelectSingleNode("id").InnerText, report.SelectSingleNode("ownerId").InnerText, report.SelectSingleNode("creationDate").InnerText, report.SelectSingleNode("gradeTaken").InnerText);
                }
            }
        }
        private void RefreshDataGrid()
        {
            homeworkList.Rows.Clear();
            xmlauth.Load("../../Homework.xml");
            foreach (XmlNode homework in xmlauth.SelectSingleNode("homeworks").ChildNodes)
            {
                if (int.Parse(homework.SelectSingleNode("teacherId").InnerText) == currentUser.Id)
                {
                    homeworkList.Rows.Add(homework.SelectSingleNode("id").InnerText, homework.SelectSingleNode("creationDate").InnerText, homework.SelectSingleNode("name").InnerText, homework.SelectSingleNode("status").InnerText);
                }
            }
        }

        private void StatusChanger_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../Homework.xml");
            foreach (XmlNode homework in xmlauth.SelectSingleNode("homeworks").ChildNodes)
            {
                if (homework.SelectSingleNode("id").InnerText == homeworkList.SelectedRows[0].Cells[0].Value.ToString())
                {
                    if (homework.SelectSingleNode("status").InnerText == "expired")
                    {
                        homework.SelectSingleNode("status").InnerText = "valid";
                    }
                    else
                    {
                        homework.SelectSingleNode("status").InnerText = "expired";
                    }

                    break;
                }
            }
            xmlauth.Save("../../Homework.xml");
            RefreshDataGrid();
        }

        private void studentReportList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            xmlauth.Load("../../ReportList.xml");
            foreach (XmlNode report in xmlauth.SelectSingleNode("reports").ChildNodes)
            {
                if (report.SelectSingleNode("id").InnerText == studentReportList.SelectedRows[0].Cells[0].Value.ToString())
                {
                    HomeworkBox.Text = report.SelectSingleNode("content").InnerText;
                    HomeworkBox.ReadOnly = true;
                    HomeworkBox.Show();
                    if (studentReportList.SelectedRows[0].Cells[3].Value.ToString() == "")
                    {
                        gradeGiverButton.Show();
                    }

                    break;
                }
            }
        }

        private void gradeGiverButton_Click(object sender, EventArgs e)
        {
            if (gradePhase == 1)
            {
                gradeTextBox.Show();
                gradePhase++;
            }
            else
            {
                xmlauth.Load("../../ReportList.xml");
                foreach (XmlNode report in xmlauth.SelectSingleNode("reports").ChildNodes)
                {
                    if (report.SelectSingleNode("id").InnerText == studentReportList.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        report.SelectSingleNode("gradeTaken").InnerText = gradeTextBox.Text;
                        break;
                    }
                }
                xmlauth.Save("../../ReportList.xml");
                HomeworkBox.Hide();
                gradeTextBox.Hide();
                gradeGiverButton.Hide();
                studentReportList.Hide();
                gradePhase = 1;
            }
        }

        private void HomeworkAdder_Click(object sender, EventArgs e)
        {
            homeworkList.Hide();
            HomeworkViewer.Text = "View homeworks";
            HomeworkAdder.Hide();
            HomeworkBox.Show();
            HomeworkBox.Text = "";
            HomeworkBox.ReadOnly = false;
            homeworkNameBox.Show();
            homeworkNameBox.Text = "";
            homeworkNameBox.ReadOnly = false;
            PublishHomeworkButton.Show();
        }

        private void PublishHomeworkButton_Click(object sender, EventArgs e)
        {
            xmlauth.Load("../../Homework.xml");

            XmlNode newHomework = xmlauth.CreateElement("homework");

            XmlNode newId = xmlauth.CreateElement("id");
            newId.InnerText = (lastHomeworkId + 1).ToString();
            lastHomeworkId++;
            newHomework.AppendChild(newId);

            XmlNode newTeacherId = xmlauth.CreateElement("teacherId");
            newTeacherId.InnerText = currentUser.Id.ToString();
            newHomework.AppendChild(newTeacherId);

            XmlNode newName = xmlauth.CreateElement("name");
            newName.InnerText = homeworkNameBox.Text;
            newHomework.AppendChild(newName);

            XmlNode newContent = xmlauth.CreateElement("content");
            newContent.InnerText = HomeworkBox.Text;
            newHomework.AppendChild(newContent);

            XmlNode newDate = xmlauth.CreateElement("creationDate");
            newDate.InnerText = DateTime.Now.ToString();
            newHomework.AppendChild(newDate);

            XmlNode newStatus = xmlauth.CreateElement("status");
            newStatus.InnerText = "valid";
            newHomework.AppendChild(newStatus);

            xmlauth.DocumentElement.AppendChild(newHomework);
            xmlauth.Save("../../Homework.xml");

            PublishHomeworkButton.Hide();
            homeworkNameBox.Hide();
            HomeworkBox.Hide();
        }
    }
}
