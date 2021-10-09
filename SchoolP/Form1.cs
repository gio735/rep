
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

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        public static Form1 mainForm;
        public static string userData = "";
        public Panel pnlContainer { get; set; }
        XmlDocument xmlauth = new XmlDocument();
        XmlDocument studentData = new XmlDocument();
        XmlDocument teacherData = new XmlDocument();
        int lastId = 0;
        public static List<User> registeredUsers = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        public void loadRegisteredUsers()
        {
            xmlauth.Load("../../UserList.xml");
            //studentData.Load("../../StudentList.xml");
            //teacherData.Load("../../TeacherList.xml");


            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                try
                {
                    User registeredUser = new User();
                    registeredUser.Id = int.Parse(user.SelectSingleNode("id").InnerText);
                    lastId = registeredUser.Id;
                    registeredUser.Username = user.SelectSingleNode("username").InnerText;
                    registeredUser.Name = user.SelectSingleNode("name").InnerText;
                    registeredUser.Lastname = user.SelectSingleNode("lastname").InnerText;
                    registeredUser.Password = user.SelectSingleNode("password").InnerText;
                    registeredUser.Status = user.SelectSingleNode("status").InnerText;
                    registeredUser.Course = user.SelectSingleNode("course").InnerText;
                    List<int> grades = new List<int>();
                    try
                    {
                        foreach (XmlNode grade in user.SelectSingleNode("grades"))
                        {
                            grades.Add(int.Parse(grade.InnerText));
                        }
                    }
                    catch
                    {

                    }


                    foreach (int grade in grades)
                    {
                        Grade registeredGrade = new Grade(int.Parse(user.SelectSingleNode("id").InnerText), user.SelectSingleNode("course").InnerText, grade);
                        registeredUser.Grades.Add(registeredGrade);
                    }
                    registeredUsers.Add(registeredUser);
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_register.BackColor = Color.Transparent;
            label_usernameRegister.BackColor = Color.Transparent;
            label_passwordRegister.BackColor = Color.Transparent;
            label_lastnameRegister.BackColor = Color.Transparent;
            label_confirmPasswordRegister.BackColor = Color.Transparent;
            label_statusRegister.BackColor = Color.Transparent;
            label_additionalInformationRegister.BackColor = Color.Transparent;
            label_login.BackColor = Color.Transparent;
            label_usernameLogin.BackColor = Color.Transparent;
            label_passwordLogin.BackColor = Color.Transparent;
            label_responseRegister.BackColor = Color.Transparent;
            label_responseLogin.BackColor = Color.Transparent;
            label_responseRegister.BackColor = Color.Transparent;
            label_nameRegister.BackColor = Color.Transparent;
            label_authorization.BackColor = Color.Transparent;
            label_register.ForeColor = Color.DeepSkyBlue;
            label_usernameRegister.ForeColor = Color.DeepSkyBlue;
            label_passwordRegister.ForeColor = Color.DeepSkyBlue;
            label_lastnameRegister.ForeColor = Color.DeepSkyBlue;
            label_confirmPasswordRegister.ForeColor = Color.DeepSkyBlue;
            label_statusRegister.ForeColor = Color.DeepSkyBlue;
            label_additionalInformationRegister.ForeColor = Color.DeepSkyBlue;
            label_login.ForeColor = Color.DeepSkyBlue;
            label_usernameLogin.ForeColor = Color.DeepSkyBlue;
            label_passwordLogin.ForeColor = Color.DeepSkyBlue;
            label_responseRegister.ForeColor = Color.DeepSkyBlue;
            label_responseLogin.ForeColor = Color.DeepSkyBlue;
            label_responseRegister.ForeColor = Color.DeepSkyBlue;
            label_nameRegister.ForeColor = Color.DeepSkyBlue;
            label_authorization.ForeColor = Color.DeepSkyBlue;
            pnlContainer = panelConteiner;
            mainForm = this;
            textBox_confirmPasswordRegister.PasswordChar = '*';
            textBox_passwordLogin.PasswordChar = '*';
            textBox_passwordRegister.PasswordChar = '*';
            label_responseLogin.Hide();
            label_responseRegister.Hide();
            loadRegisteredUsers();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (User user in registeredUsers)
            {
                if (user.Username == textBox_usernameLogin.Text && user.Password == textBox_passwordLogin.Text)
                {
                    success = true;
                    if (user.Status.ToLower() == "student")
                    {
                        userData = user.Username + "  " + user.Status;

                        LoggedFormStudent loggedStudent = new LoggedFormStudent(user);
                        loggedStudent.Dock = DockStyle.Fill;
                        panelConteiner.Controls.Add(loggedStudent);
                        panelConteiner.Show();
                        panelConteiner.Controls["LoggedFormStudent"].BringToFront();
                    }
                    else
                    {
                        userData = $"{user.Name} {user.Lastname}\n{user.Status} - {user.Course}";
                        success = true;
                        LoggedTeacher loggedTeacher = new LoggedTeacher(user);
                        loggedTeacher.Dock = DockStyle.Fill;
                        panelConteiner.Controls.Add(loggedTeacher);
                        panelConteiner.Show();
                        panelConteiner.Controls["LoggedTeacher"].BringToFront();
                    }

                }
            }
            if (!success)
            {
                label_responseLogin.ForeColor = Color.Red;
                label_responseLogin.Text = "Response: Could not log in";
            }
            label_responseLogin.Show();
            HideLabel(label_responseLogin);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            bool success = true;
            foreach (User user in registeredUsers)
            {

                if (user.Username == textBox_usernameRegister.Text)
                {
                    label_responseRegister.ForeColor = Color.Red;
                    label_responseRegister.Text = "Response: Username already taken";
                    success = false;
                    break;
                }
            }
            if (textBox_passwordRegister.Text != textBox_confirmPasswordRegister.Text)
            {
                label_responseRegister.ForeColor = Color.Red;
                label_responseRegister.Text = "Response: Passwords do not match";
                success = false;
            }
            if (textBox_confirmPasswordRegister.Text == string.Empty || textBox_passwordRegister.Text == string.Empty || textBox_usernameRegister.Text == string.Empty || textBox_nameRegister.Text == string.Empty || textBox_lastnameRegister.Text == string.Empty)
            {
                label_responseRegister.ForeColor = Color.Red;
                label_responseRegister.Text = "Response: Some fields are not filled";
                success = false;
            }
            if (success)
            {
                label_responseRegister.Show();

                XmlNode newUser = xmlauth.CreateElement("user");

                XmlNode newUserId = xmlauth.CreateElement("id");
                newUserId.InnerText = (lastId + 1).ToString();
                newUser.AppendChild(newUserId);

                XmlNode newUsername = xmlauth.CreateElement("username");
                newUsername.InnerText = textBox_usernameRegister.Text;
                newUser.AppendChild(newUsername);

                XmlNode newName = xmlauth.CreateElement("name");
                newName.InnerText = textBox_nameRegister.Text;
                newUser.AppendChild(newName);

                XmlNode newLastname = xmlauth.CreateElement("lastname");
                newLastname.InnerText = textBox_lastnameRegister.Text;
                newUser.AppendChild(newLastname);

                XmlNode newPassword = xmlauth.CreateElement("password");
                newPassword.InnerText = textBox_passwordRegister.Text;
                newUser.AppendChild(newPassword);

                XmlNode newStatus = xmlauth.CreateElement("status");
                newStatus.InnerText = comboBox_statusRegister.Text;
                newUser.AppendChild(newStatus);

                XmlNode newCourse = xmlauth.CreateElement("course");
                newCourse.InnerText = comboBox_courseRegister.Text;
                newUser.AppendChild(newCourse);
                XmlNode newGrades = xmlauth.CreateElement("grades");
                newUser.AppendChild(newGrades);



                xmlauth.DocumentElement.AppendChild(newUser);
                xmlauth.Save("../../UserList.xml");

                label_responseRegister.ForeColor = Color.Green;
                label_responseRegister.Text = "Response: Registration completed";
                textBox_confirmPasswordRegister.Text = string.Empty;
                textBox_passwordRegister.Text = string.Empty;
                textBox_usernameRegister.Text = string.Empty;
                textBox_nameRegister.Text = string.Empty;
                textBox_lastnameRegister.Text = string.Empty;
                comboBox_courseRegister.Text = string.Empty;
                comboBox_statusRegister.Text = string.Empty;
                if (newStatus.InnerText == "Student")
                {
                    xmlauth.Load("../../CourseData.xml");
                    try
                    {
                        foreach (XmlNode course in xmlauth.SelectSingleNode("courses").ChildNodes)
                        {
                            if (course.SelectSingleNode("name").InnerText == comboBox_courseRegister.Text)
                            {
                                newUserId = xmlauth.CreateElement("studentId");
                                newUserId.InnerText = (lastId + 1).ToString();
                                course.SelectSingleNode("students").AppendChild(newUserId);
                                xmlauth.Save("../../CourseData.xml");
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                loadRegisteredUsers();
            }
            label_responseRegister.Show();
            HideLabel(label_responseRegister);
        }

        private void label_responseRegister_Click(object sender, EventArgs e)
        {

        }

        private void label_responseLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBox_usernameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_courseRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_statusRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public async Task HideLabel(object target)
        {
            await Task.Delay(5000);
            if (label_responseRegister == target)
            {
                label_responseRegister.Hide();
            }
            if (label_responseLogin == target)
            {
                label_responseLogin.Hide();
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_register_Click(object sender, EventArgs e)
        {

        }

        private void label_passwordRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
