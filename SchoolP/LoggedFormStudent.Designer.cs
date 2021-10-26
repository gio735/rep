
namespace SchoolP
{
    partial class LoggedFormStudent
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedFormStudent));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.StudentSelfChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HomeworkManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSelfChart)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AccessibleName = "";
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usernameLabel.Location = new System.Drawing.Point(15, 46);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(157, 22);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "{Form1.username}";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(1057, 21);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(111, 47);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StudentPictureBox.Image")));
            this.StudentPictureBox.Location = new System.Drawing.Point(0, 0);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(1189, 560);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPictureBox.TabIndex = 3;
            this.StudentPictureBox.TabStop = false;
            this.StudentPictureBox.Click += new System.EventHandler(this.StudentPictureBox_Click);
            // 
            // StudentSelfChart
            // 
            chartArea1.Name = "ChartArea1";
            this.StudentSelfChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StudentSelfChart.Legends.Add(legend1);
            this.StudentSelfChart.Location = new System.Drawing.Point(19, 249);
            this.StudentSelfChart.Name = "StudentSelfChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StudentSelfChart.Series.Add(series1);
            this.StudentSelfChart.Size = new System.Drawing.Size(360, 285);
            this.StudentSelfChart.TabIndex = 4;
            this.StudentSelfChart.Text = "chart1";
            // 
            // HomeworkManagement
            // 
            this.HomeworkManagement.BackColor = System.Drawing.SystemColors.Highlight;
            this.HomeworkManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HomeworkManagement.ForeColor = System.Drawing.Color.Black;
            this.HomeworkManagement.Location = new System.Drawing.Point(940, 20);
            this.HomeworkManagement.Name = "HomeworkManagement";
            this.HomeworkManagement.Size = new System.Drawing.Size(111, 51);
            this.HomeworkManagement.TabIndex = 19;
            this.HomeworkManagement.Text = "Manage Homework";
            this.HomeworkManagement.UseVisualStyleBackColor = false;
            this.HomeworkManagement.Click += new System.EventHandler(this.HomeworkManagement_Click);
            // 
            // LoggedFormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomeworkManagement);
            this.Controls.Add(this.StudentSelfChart);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.StudentPictureBox);
            this.Name = "LoggedFormStudent";
            this.Size = new System.Drawing.Size(1189, 560);
            this.Load += new System.EventHandler(this.LoggedFormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSelfChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentSelfChart;
        private System.Windows.Forms.Button HomeworkManagement;
    }
}
