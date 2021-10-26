using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolP
{
    public partial class LoggedFormStudent : UserControl
    {
        User currentUser;
        public LoggedFormStudent(User user)
        {
            currentUser = user;
            InitializeComponent();
            usernameLabel.Text = Form1.userData;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.ForeColor = Color.DeepSkyBlue;
            StudentSelfChart.Series.RemoveAt(0);
            StudentSelfChart.Series.Add(user.Name);
            int i = 0;
            if (user.Grades.Count != 0)
            {
                foreach (Grade grade in user.Grades)
                {
                    i++;
                    StudentSelfChart.Series[0].Points.AddXY(i, grade.Mark);
                }
            }
            else
            {
                StudentSelfChart.Hide();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoggedFormStudent_Load(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1.mainForm.pnlContainer.Controls["LoggedFormStudent"].Dispose();
            Form1.mainForm.pnlContainer.Hide();
        }

        private void StudentPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void HomeworkManagement_Click(object sender, EventArgs e)
        {
            StudentReportForm studentReportForm = new StudentReportForm(currentUser);
            studentReportForm.Dock = DockStyle.Fill;
            Form1.mainForm.pnlContainer.Controls.Add(studentReportForm);
            Form1.mainForm.pnlContainer.Show();
            Form1.mainForm.pnlContainer.Controls["StudentReportForm"].BringToFront();
        }
    }
}
