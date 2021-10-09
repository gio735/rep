
namespace SchoolProject
{
    partial class LoggedTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedTeacher));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TeacherDataLabel = new System.Windows.Forms.Label();
            this.StudentList = new System.Windows.Forms.DataGridView();
            this.Selector = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherPictureBox = new System.Windows.Forms.PictureBox();
            this.StudentGrades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ViewButton = new System.Windows.Forms.Button();
            this.teacherLogOut = new System.Windows.Forms.Button();
            this.NoGradeDataFound = new System.Windows.Forms.Label();
            this.ChartSwitcher = new System.Windows.Forms.Button();
            this.GradeGiver = new System.Windows.Forms.Button();
            this.TargetUsername = new System.Windows.Forms.Label();
            this.MarkToAddBox = new System.Windows.Forms.TextBox();
            this.MarkToAddLabel = new System.Windows.Forms.Label();
            this.AddGradeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CancelAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherDataLabel
            // 
            this.TeacherDataLabel.AutoSize = true;
            this.TeacherDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.TeacherDataLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.TeacherDataLabel.Location = new System.Drawing.Point(9, 15);
            this.TeacherDataLabel.Name = "TeacherDataLabel";
            this.TeacherDataLabel.Size = new System.Drawing.Size(162, 37);
            this.TeacherDataLabel.TabIndex = 3;
            this.TeacherDataLabel.Text = "TeacherData";
            this.TeacherDataLabel.Click += new System.EventHandler(this.TeacherDataLabel_Click);
            // 
            // StudentList
            // 
            this.StudentList.AllowUserToAddRows = false;
            this.StudentList.AllowUserToDeleteRows = false;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selector,
            this.StudentId,
            this.StudentName,
            this.StudentLastname});
            this.StudentList.Location = new System.Drawing.Point(16, 86);
            this.StudentList.Name = "StudentList";
            this.StudentList.RowTemplate.Height = 25;
            this.StudentList.Size = new System.Drawing.Size(333, 414);
            this.StudentList.TabIndex = 4;
            // 
            // Selector
            // 
            this.Selector.HeaderText = "Select";
            this.Selector.Name = "Selector";
            this.Selector.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selector.Width = 50;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 45;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            // 
            // StudentLastname
            // 
            this.StudentLastname.HeaderText = "Lastname";
            this.StudentLastname.Name = "StudentLastname";
            this.StudentLastname.Width = 150;
            // 
            // TeacherPictureBox
            // 
            this.TeacherPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TeacherPictureBox.Image")));
            this.TeacherPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TeacherPictureBox.Name = "TeacherPictureBox";
            this.TeacherPictureBox.Size = new System.Drawing.Size(1173, 521);
            this.TeacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TeacherPictureBox.TabIndex = 5;
            this.TeacherPictureBox.TabStop = false;
            // 
            // StudentGrades
            // 
            this.StudentGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.StudentGrades.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StudentGrades.Legends.Add(legend2);
            this.StudentGrades.Location = new System.Drawing.Point(792, 244);
            this.StudentGrades.Name = "StudentGrades";
            this.StudentGrades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StudentGrades.Series.Add(series2);
            this.StudentGrades.Size = new System.Drawing.Size(345, 256);
            this.StudentGrades.TabIndex = 6;
            this.StudentGrades.Text = "chart1";
            this.StudentGrades.Visible = false;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ViewButton.ForeColor = System.Drawing.Color.Black;
            this.ViewButton.Location = new System.Drawing.Point(355, 86);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(82, 51);
            this.ViewButton.TabIndex = 7;
            this.ViewButton.Text = "View grades";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacherLogOut
            // 
            this.teacherLogOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.teacherLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.teacherLogOut.ForeColor = System.Drawing.Color.Black;
            this.teacherLogOut.Location = new System.Drawing.Point(1016, 15);
            this.teacherLogOut.Name = "teacherLogOut";
            this.teacherLogOut.Size = new System.Drawing.Size(121, 53);
            this.teacherLogOut.TabIndex = 8;
            this.teacherLogOut.Text = "Log out";
            this.teacherLogOut.UseVisualStyleBackColor = false;
            this.teacherLogOut.Click += new System.EventHandler(this.teacherLogOut_Click_1);
            // 
            // NoGradeDataFound
            // 
            this.NoGradeDataFound.AutoSize = true;
            this.NoGradeDataFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NoGradeDataFound.Location = new System.Drawing.Point(779, 219);
            this.NoGradeDataFound.Name = "NoGradeDataFound";
            this.NoGradeDataFound.Size = new System.Drawing.Size(369, 22);
            this.NoGradeDataFound.TabIndex = 9;
            this.NoGradeDataFound.Text = "There are no grade(s) for selected student(s)";
            this.NoGradeDataFound.Visible = false;
            // 
            // ChartSwitcher
            // 
            this.ChartSwitcher.BackColor = System.Drawing.SystemColors.Highlight;
            this.ChartSwitcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ChartSwitcher.ForeColor = System.Drawing.Color.Black;
            this.ChartSwitcher.Location = new System.Drawing.Point(1055, 193);
            this.ChartSwitcher.Name = "ChartSwitcher";
            this.ChartSwitcher.Size = new System.Drawing.Size(82, 45);
            this.ChartSwitcher.TabIndex = 10;
            this.ChartSwitcher.Text = "Hide";
            this.ChartSwitcher.UseVisualStyleBackColor = false;
            this.ChartSwitcher.Visible = false;
            this.ChartSwitcher.Click += new System.EventHandler(this.ChartSwitcher_Click);
            // 
            // GradeGiver
            // 
            this.GradeGiver.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradeGiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GradeGiver.ForeColor = System.Drawing.Color.Black;
            this.GradeGiver.Location = new System.Drawing.Point(355, 143);
            this.GradeGiver.Name = "GradeGiver";
            this.GradeGiver.Size = new System.Drawing.Size(82, 51);
            this.GradeGiver.TabIndex = 11;
            this.GradeGiver.Text = "Add grade";
            this.GradeGiver.UseVisualStyleBackColor = false;
            this.GradeGiver.Click += new System.EventHandler(this.GradeGiver_ClickAsync);
            // 
            // TargetUsername
            // 
            this.TargetUsername.AutoSize = true;
            this.TargetUsername.BackColor = System.Drawing.Color.Transparent;
            this.TargetUsername.ForeColor = System.Drawing.Color.Black;
            this.TargetUsername.Location = new System.Drawing.Point(488, 162);
            this.TargetUsername.Name = "TargetUsername";
            this.TargetUsername.Size = new System.Drawing.Size(35, 13);
            this.TargetUsername.TabIndex = 12;
            this.TargetUsername.Text = "label1";
            this.TargetUsername.Visible = false;
            // 
            // MarkToAddBox
            // 
            this.MarkToAddBox.Location = new System.Drawing.Point(491, 206);
            this.MarkToAddBox.Name = "MarkToAddBox";
            this.MarkToAddBox.Size = new System.Drawing.Size(173, 20);
            this.MarkToAddBox.TabIndex = 13;
            this.MarkToAddBox.Visible = false;
            // 
            // MarkToAddLabel
            // 
            this.MarkToAddLabel.AutoSize = true;
            this.MarkToAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.MarkToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MarkToAddLabel.ForeColor = System.Drawing.Color.Black;
            this.MarkToAddLabel.Location = new System.Drawing.Point(491, 187);
            this.MarkToAddLabel.Name = "MarkToAddLabel";
            this.MarkToAddLabel.Size = new System.Drawing.Size(46, 18);
            this.MarkToAddLabel.TabIndex = 14;
            this.MarkToAddLabel.Text = "Mark:";
            this.MarkToAddLabel.Visible = false;
            // 
            // AddGradeButton
            // 
            this.AddGradeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AddGradeButton.ForeColor = System.Drawing.Color.Black;
            this.AddGradeButton.Location = new System.Drawing.Point(491, 244);
            this.AddGradeButton.Name = "AddGradeButton";
            this.AddGradeButton.Size = new System.Drawing.Size(75, 32);
            this.AddGradeButton.TabIndex = 15;
            this.AddGradeButton.Text = "Add";
            this.AddGradeButton.UseVisualStyleBackColor = false;
            this.AddGradeButton.Visible = false;
            this.AddGradeButton.Click += new System.EventHandler(this.AddGradeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(589, 244);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CancelAllButton
            // 
            this.CancelAllButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CancelAllButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAllButton.Location = new System.Drawing.Point(491, 282);
            this.CancelAllButton.Name = "CancelAllButton";
            this.CancelAllButton.Size = new System.Drawing.Size(173, 29);
            this.CancelAllButton.TabIndex = 17;
            this.CancelAllButton.Text = "Cancel all";
            this.CancelAllButton.UseVisualStyleBackColor = false;
            this.CancelAllButton.Visible = false;
            this.CancelAllButton.Click += new System.EventHandler(this.CancelAllButton_Click);
            // 
            // LoggedTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelAllButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddGradeButton);
            this.Controls.Add(this.MarkToAddLabel);
            this.Controls.Add(this.MarkToAddBox);
            this.Controls.Add(this.TargetUsername);
            this.Controls.Add(this.GradeGiver);
            this.Controls.Add(this.ChartSwitcher);
            this.Controls.Add(this.NoGradeDataFound);
            this.Controls.Add(this.teacherLogOut);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.StudentGrades);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.TeacherDataLabel);
            this.Controls.Add(this.TeacherPictureBox);
            this.Name = "LoggedTeacher";
            this.Size = new System.Drawing.Size(1173, 521);
            this.Load += new System.EventHandler(this.LoggedTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TeacherDataLabel;
        private System.Windows.Forms.DataGridView StudentList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selector;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLastname;
        private System.Windows.Forms.PictureBox TeacherPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentGrades;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button teacherLogOut;
        private System.Windows.Forms.Label NoGradeDataFound;
        private System.Windows.Forms.Button ChartSwitcher;
        private System.Windows.Forms.Button GradeGiver;
        private System.Windows.Forms.Label TargetUsername;
        private System.Windows.Forms.TextBox MarkToAddBox;
        private System.Windows.Forms.Label MarkToAddLabel;
        private System.Windows.Forms.Button AddGradeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CancelAllButton;
    }
}
