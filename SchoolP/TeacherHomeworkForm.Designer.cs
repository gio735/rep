
namespace SchoolP
{
    partial class TeacherHomeworkForm
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
            this.ReturnToMonke = new System.Windows.Forms.Button();
            this.HomeworkViewer = new System.Windows.Forms.Button();
            this.homeworkList = new System.Windows.Forms.DataGridView();
            this.HomeworkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeworkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeworkBox = new System.Windows.Forms.TextBox();
            this.HomeworkAdder = new System.Windows.Forms.Button();
            this.StatusChanger = new System.Windows.Forms.Button();
            this.ViewReports = new System.Windows.Forms.Button();
            this.homeworkNameBox = new System.Windows.Forms.TextBox();
            this.studentReportList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishHomeworkButton = new System.Windows.Forms.Button();
            this.gradeGiverButton = new System.Windows.Forms.Button();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToMonke
            // 
            this.ReturnToMonke.BackColor = System.Drawing.SystemColors.Highlight;
            this.ReturnToMonke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReturnToMonke.ForeColor = System.Drawing.Color.Black;
            this.ReturnToMonke.Location = new System.Drawing.Point(1060, 17);
            this.ReturnToMonke.Name = "ReturnToMonke";
            this.ReturnToMonke.Size = new System.Drawing.Size(96, 44);
            this.ReturnToMonke.TabIndex = 1;
            this.ReturnToMonke.Text = "Return";
            this.ReturnToMonke.UseVisualStyleBackColor = false;
            this.ReturnToMonke.Click += new System.EventHandler(this.ReturnToMonke_Click);
            // 
            // HomeworkViewer
            // 
            this.HomeworkViewer.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeworkViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HomeworkViewer.ForeColor = System.Drawing.Color.Black;
            this.HomeworkViewer.Location = new System.Drawing.Point(17, 17);
            this.HomeworkViewer.Name = "HomeworkViewer";
            this.HomeworkViewer.Size = new System.Drawing.Size(96, 44);
            this.HomeworkViewer.TabIndex = 2;
            this.HomeworkViewer.Text = "View homeworks";
            this.HomeworkViewer.UseVisualStyleBackColor = false;
            this.HomeworkViewer.Click += new System.EventHandler(this.HomeworkViewer_Click);
            // 
            // homeworkList
            // 
            this.homeworkList.AllowUserToAddRows = false;
            this.homeworkList.AllowUserToDeleteRows = false;
            this.homeworkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeworkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomeworkId,
            this.HomeworkDate,
            this.StudentName,
            this.Status});
            this.homeworkList.Location = new System.Drawing.Point(17, 67);
            this.homeworkList.MultiSelect = false;
            this.homeworkList.Name = "homeworkList";
            this.homeworkList.ReadOnly = true;
            this.homeworkList.RowTemplate.Height = 25;
            this.homeworkList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.homeworkList.Size = new System.Drawing.Size(288, 414);
            this.homeworkList.TabIndex = 5;
            this.homeworkList.Visible = false;
            this.homeworkList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.multiUsedDataGrid_CellContentClick);
            // 
            // HomeworkId
            // 
            this.HomeworkId.HeaderText = "Id";
            this.HomeworkId.Name = "HomeworkId";
            this.HomeworkId.ReadOnly = true;
            this.HomeworkId.Width = 35;
            // 
            // HomeworkDate
            // 
            this.HomeworkDate.HeaderText = "Date";
            this.HomeworkDate.Name = "HomeworkDate";
            this.HomeworkDate.ReadOnly = true;
            this.HomeworkDate.Width = 75;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // HomeworkBox
            // 
            this.HomeworkBox.Location = new System.Drawing.Point(311, 67);
            this.HomeworkBox.Multiline = true;
            this.HomeworkBox.Name = "HomeworkBox";
            this.HomeworkBox.ReadOnly = true;
            this.HomeworkBox.Size = new System.Drawing.Size(608, 414);
            this.HomeworkBox.TabIndex = 7;
            this.HomeworkBox.Visible = false;
            // 
            // HomeworkAdder
            // 
            this.HomeworkAdder.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeworkAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HomeworkAdder.ForeColor = System.Drawing.Color.Black;
            this.HomeworkAdder.Location = new System.Drawing.Point(119, 18);
            this.HomeworkAdder.Name = "HomeworkAdder";
            this.HomeworkAdder.Size = new System.Drawing.Size(96, 44);
            this.HomeworkAdder.TabIndex = 8;
            this.HomeworkAdder.Text = "Add homework";
            this.HomeworkAdder.UseVisualStyleBackColor = false;
            this.HomeworkAdder.Click += new System.EventHandler(this.HomeworkAdder_Click);
            // 
            // StatusChanger
            // 
            this.StatusChanger.BackColor = System.Drawing.SystemColors.Highlight;
            this.StatusChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StatusChanger.ForeColor = System.Drawing.Color.Black;
            this.StatusChanger.Location = new System.Drawing.Point(925, 422);
            this.StatusChanger.Name = "StatusChanger";
            this.StatusChanger.Size = new System.Drawing.Size(104, 59);
            this.StatusChanger.TabIndex = 10;
            this.StatusChanger.Text = "Change status";
            this.StatusChanger.UseVisualStyleBackColor = false;
            this.StatusChanger.Visible = false;
            this.StatusChanger.Click += new System.EventHandler(this.StatusChanger_Click);
            // 
            // ViewReports
            // 
            this.ViewReports.BackColor = System.Drawing.SystemColors.Highlight;
            this.ViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewReports.ForeColor = System.Drawing.Color.Black;
            this.ViewReports.Location = new System.Drawing.Point(925, 357);
            this.ViewReports.Name = "ViewReports";
            this.ViewReports.Size = new System.Drawing.Size(104, 59);
            this.ViewReports.TabIndex = 11;
            this.ViewReports.Text = "View reports";
            this.ViewReports.UseVisualStyleBackColor = false;
            this.ViewReports.Visible = false;
            this.ViewReports.Click += new System.EventHandler(this.ViewReports_Click);
            // 
            // homeworkNameBox
            // 
            this.homeworkNameBox.Location = new System.Drawing.Point(311, 41);
            this.homeworkNameBox.Name = "homeworkNameBox";
            this.homeworkNameBox.ReadOnly = true;
            this.homeworkNameBox.Size = new System.Drawing.Size(187, 20);
            this.homeworkNameBox.TabIndex = 12;
            this.homeworkNameBox.Visible = false;
            // 
            // studentReportList
            // 
            this.studentReportList.AllowUserToAddRows = false;
            this.studentReportList.AllowUserToDeleteRows = false;
            this.studentReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentReportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.studentReportList.Location = new System.Drawing.Point(17, 67);
            this.studentReportList.MultiSelect = false;
            this.studentReportList.Name = "studentReportList";
            this.studentReportList.ReadOnly = true;
            this.studentReportList.RowTemplate.Height = 25;
            this.studentReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentReportList.Size = new System.Drawing.Size(288, 414);
            this.studentReportList.TabIndex = 13;
            this.studentReportList.Visible = false;
            this.studentReportList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentReportList_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // PublishHomeworkButton
            // 
            this.PublishHomeworkButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.PublishHomeworkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PublishHomeworkButton.ForeColor = System.Drawing.Color.Black;
            this.PublishHomeworkButton.Location = new System.Drawing.Point(925, 67);
            this.PublishHomeworkButton.Name = "PublishHomeworkButton";
            this.PublishHomeworkButton.Size = new System.Drawing.Size(104, 59);
            this.PublishHomeworkButton.TabIndex = 9;
            this.PublishHomeworkButton.Text = "Add";
            this.PublishHomeworkButton.UseVisualStyleBackColor = false;
            this.PublishHomeworkButton.Visible = false;
            this.PublishHomeworkButton.Click += new System.EventHandler(this.PublishHomeworkButton_Click);
            // 
            // gradeGiverButton
            // 
            this.gradeGiverButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.gradeGiverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gradeGiverButton.ForeColor = System.Drawing.Color.Black;
            this.gradeGiverButton.Location = new System.Drawing.Point(925, 166);
            this.gradeGiverButton.Name = "gradeGiverButton";
            this.gradeGiverButton.Size = new System.Drawing.Size(104, 43);
            this.gradeGiverButton.TabIndex = 14;
            this.gradeGiverButton.Text = "Add grade";
            this.gradeGiverButton.UseVisualStyleBackColor = false;
            this.gradeGiverButton.Visible = false;
            this.gradeGiverButton.Click += new System.EventHandler(this.gradeGiverButton_Click);
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(925, 215);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(104, 20);
            this.gradeTextBox.TabIndex = 15;
            this.gradeTextBox.Visible = false;
            // 
            // TeacherHomeworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.gradeGiverButton);
            this.Controls.Add(this.studentReportList);
            this.Controls.Add(this.homeworkNameBox);
            this.Controls.Add(this.HomeworkViewer);
            this.Controls.Add(this.HomeworkAdder);
            this.Controls.Add(this.StatusChanger);
            this.Controls.Add(this.ViewReports);
            this.Controls.Add(this.PublishHomeworkButton);
            this.Controls.Add(this.ReturnToMonke);
            this.Controls.Add(this.HomeworkBox);
            this.Controls.Add(this.homeworkList);
            this.Name = "TeacherHomeworkForm";
            this.Size = new System.Drawing.Size(1173, 521);
            ((System.ComponentModel.ISupportInitialize)(this.homeworkList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReturnToMonke;
        private System.Windows.Forms.Button HomeworkViewer;
        private System.Windows.Forms.DataGridView homeworkList;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeworkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeworkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox HomeworkBox;
        private System.Windows.Forms.Button HomeworkAdder;
        private System.Windows.Forms.Button StatusChanger;
        private System.Windows.Forms.Button ViewReports;
        private System.Windows.Forms.TextBox homeworkNameBox;
        private System.Windows.Forms.DataGridView studentReportList;
        private System.Windows.Forms.Button PublishHomeworkButton;
        private System.Windows.Forms.Button gradeGiverButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox gradeTextBox;
    }
}
