
namespace SchoolP
{
    partial class AdminForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminLogOut = new System.Windows.Forms.Button();
            this.AdminDataLabel = new System.Windows.Forms.Label();
            this.TeacherChoiceBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseSelectingSomewhatComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherRejectButton = new System.Windows.Forms.Button();
            this.TeacherAcceptButton = new System.Windows.Forms.Button();
            this.TeacherCandidates = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalStudentList = new System.Windows.Forms.DataGridView();
            this.StudentRegroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherSelectorCombo = new System.Windows.Forms.ComboBox();
            this.SwitchClass = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TeacherChoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalStudentList)).BeginInit();
            this.StudentRegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminLogOut
            // 
            this.AdminLogOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.AdminLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.AdminLogOut.ForeColor = System.Drawing.Color.Black;
            this.AdminLogOut.Location = new System.Drawing.Point(1056, 21);
            this.AdminLogOut.Name = "AdminLogOut";
            this.AdminLogOut.Size = new System.Drawing.Size(97, 45);
            this.AdminLogOut.TabIndex = 1;
            this.AdminLogOut.Text = "Log out";
            this.AdminLogOut.UseVisualStyleBackColor = false;
            this.AdminLogOut.Click += new System.EventHandler(this.AdminLogOut_Click);
            // 
            // AdminDataLabel
            // 
            this.AdminDataLabel.AutoSize = true;
            this.AdminDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdminDataLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminDataLabel.Location = new System.Drawing.Point(20, 21);
            this.AdminDataLabel.Name = "AdminDataLabel";
            this.AdminDataLabel.Size = new System.Drawing.Size(51, 20);
            this.AdminDataLabel.TabIndex = 2;
            this.AdminDataLabel.Text = "label1";
            // 
            // TeacherChoiceBox
            // 
            this.TeacherChoiceBox.Controls.Add(this.label1);
            this.TeacherChoiceBox.Controls.Add(this.CourseSelectingSomewhatComboBox);
            this.TeacherChoiceBox.Controls.Add(this.TeacherRejectButton);
            this.TeacherChoiceBox.Controls.Add(this.TeacherAcceptButton);
            this.TeacherChoiceBox.Location = new System.Drawing.Point(17, 374);
            this.TeacherChoiceBox.Name = "TeacherChoiceBox";
            this.TeacherChoiceBox.Size = new System.Drawing.Size(273, 128);
            this.TeacherChoiceBox.TabIndex = 3;
            this.TeacherChoiceBox.TabStop = false;
            this.TeacherChoiceBox.Text = "teacher data";
            this.TeacherChoiceBox.Visible = false;
            this.TeacherChoiceBox.Enter += new System.EventHandler(this.TeacherChoiceBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course:";
            // 
            // CourseSelectingSomewhatComboBox
            // 
            this.CourseSelectingSomewhatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseSelectingSomewhatComboBox.FormattingEnabled = true;
            this.CourseSelectingSomewhatComboBox.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Python",
            "Java",
            "JavaScript",
            "Free Pascal",
            "OCaml"});
            this.CourseSelectingSomewhatComboBox.Location = new System.Drawing.Point(58, 53);
            this.CourseSelectingSomewhatComboBox.Name = "CourseSelectingSomewhatComboBox";
            this.CourseSelectingSomewhatComboBox.Size = new System.Drawing.Size(157, 21);
            this.CourseSelectingSomewhatComboBox.TabIndex = 2;
            // 
            // TeacherRejectButton
            // 
            this.TeacherRejectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TeacherRejectButton.ForeColor = System.Drawing.Color.Black;
            this.TeacherRejectButton.Location = new System.Drawing.Point(185, 96);
            this.TeacherRejectButton.Name = "TeacherRejectButton";
            this.TeacherRejectButton.Size = new System.Drawing.Size(82, 26);
            this.TeacherRejectButton.TabIndex = 1;
            this.TeacherRejectButton.Text = "Reject";
            this.TeacherRejectButton.UseVisualStyleBackColor = true;
            this.TeacherRejectButton.Click += new System.EventHandler(this.TeacherRejectButton_Click);
            // 
            // TeacherAcceptButton
            // 
            this.TeacherAcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TeacherAcceptButton.Location = new System.Drawing.Point(6, 96);
            this.TeacherAcceptButton.Name = "TeacherAcceptButton";
            this.TeacherAcceptButton.Size = new System.Drawing.Size(82, 26);
            this.TeacherAcceptButton.TabIndex = 0;
            this.TeacherAcceptButton.Text = "Accept";
            this.TeacherAcceptButton.UseVisualStyleBackColor = true;
            this.TeacherAcceptButton.Click += new System.EventHandler(this.TeacherAcceptButton_Click);
            // 
            // TeacherCandidates
            // 
            this.TeacherCandidates.AllowUserToAddRows = false;
            this.TeacherCandidates.AllowUserToDeleteRows = false;
            this.TeacherCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserLastname});
            this.TeacherCandidates.Location = new System.Drawing.Point(17, 79);
            this.TeacherCandidates.MultiSelect = false;
            this.TeacherCandidates.Name = "TeacherCandidates";
            this.TeacherCandidates.ReadOnly = true;
            this.TeacherCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherCandidates.Size = new System.Drawing.Size(267, 289);
            this.TeacherCandidates.TabIndex = 5;
            this.TeacherCandidates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherCandidates_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 50;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 75;
            // 
            // UserLastname
            // 
            this.UserLastname.HeaderText = "Lastname";
            this.UserLastname.Name = "UserLastname";
            this.UserLastname.ReadOnly = true;
            // 
            // GlobalStudentList
            // 
            this.GlobalStudentList.AllowUserToAddRows = false;
            this.GlobalStudentList.AllowUserToDeleteRows = false;
            this.GlobalStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GlobalStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TeacherId});
            this.GlobalStudentList.Location = new System.Drawing.Point(900, 72);
            this.GlobalStudentList.MultiSelect = false;
            this.GlobalStudentList.Name = "GlobalStudentList";
            this.GlobalStudentList.ReadOnly = true;
            this.GlobalStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GlobalStudentList.Size = new System.Drawing.Size(253, 289);
            this.GlobalStudentList.TabIndex = 6;
            this.GlobalStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GlobalStudentList_CellContentClick);
            // 
            // StudentRegroupBox
            // 
            this.StudentRegroupBox.Controls.Add(this.label2);
            this.StudentRegroupBox.Controls.Add(this.TeacherSelectorCombo);
            this.StudentRegroupBox.Controls.Add(this.SwitchClass);
            this.StudentRegroupBox.ForeColor = System.Drawing.Color.Black;
            this.StudentRegroupBox.Location = new System.Drawing.Point(900, 374);
            this.StudentRegroupBox.Name = "StudentRegroupBox";
            this.StudentRegroupBox.Size = new System.Drawing.Size(253, 128);
            this.StudentRegroupBox.TabIndex = 7;
            this.StudentRegroupBox.TabStop = false;
            this.StudentRegroupBox.Text = "student data";
            this.StudentRegroupBox.Visible = false;
            this.StudentRegroupBox.Enter += new System.EventHandler(this.StudentRegroupBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teacher:";
            // 
            // TeacherSelectorCombo
            // 
            this.TeacherSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherSelectorCombo.FormattingEnabled = true;
            this.TeacherSelectorCombo.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Python",
            "Java",
            "JavaScript",
            "Free Pascal",
            "OCaml"});
            this.TeacherSelectorCombo.Location = new System.Drawing.Point(58, 53);
            this.TeacherSelectorCombo.Name = "TeacherSelectorCombo";
            this.TeacherSelectorCombo.Size = new System.Drawing.Size(154, 21);
            this.TeacherSelectorCombo.TabIndex = 2;
            // 
            // SwitchClass
            // 
            this.SwitchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SwitchClass.Location = new System.Drawing.Point(88, 91);
            this.SwitchClass.Name = "SwitchClass";
            this.SwitchClass.Size = new System.Drawing.Size(87, 31);
            this.SwitchClass.TabIndex = 0;
            this.SwitchClass.Text = "Switch";
            this.SwitchClass.UseVisualStyleBackColor = true;
            this.SwitchClass.Click += new System.EventHandler(this.SwitchClass_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Course";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // TeacherId
            // 
            this.TeacherId.HeaderText = "TId";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Width = 40;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentRegroupBox);
            this.Controls.Add(this.GlobalStudentList);
            this.Controls.Add(this.TeacherCandidates);
            this.Controls.Add(this.TeacherChoiceBox);
            this.Controls.Add(this.AdminDataLabel);
            this.Controls.Add(this.AdminLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminForm";
            this.Size = new System.Drawing.Size(1173, 521);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TeacherChoiceBox.ResumeLayout(false);
            this.TeacherChoiceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalStudentList)).EndInit();
            this.StudentRegroupBox.ResumeLayout(false);
            this.StudentRegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdminLogOut;
        private System.Windows.Forms.Label AdminDataLabel;
        private System.Windows.Forms.GroupBox TeacherChoiceBox;
        private System.Windows.Forms.Button TeacherRejectButton;
        private System.Windows.Forms.Button TeacherAcceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CourseSelectingSomewhatComboBox;
        private System.Windows.Forms.DataGridView TeacherCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastname;
        private System.Windows.Forms.DataGridView GlobalStudentList;
        private System.Windows.Forms.GroupBox StudentRegroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TeacherSelectorCombo;
        private System.Windows.Forms.Button SwitchClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
    }
}
