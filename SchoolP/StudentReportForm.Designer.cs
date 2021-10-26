
namespace SchoolP
{
    partial class StudentReportForm
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
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeworkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.homeworkNameBox = new System.Windows.Forms.TextBox();
            this.ReportViewer = new System.Windows.Forms.Button();
            this.ReportCreator = new System.Windows.Forms.Button();
            this.ReportSender = new System.Windows.Forms.Button();
            this.SureMakingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkList)).BeginInit();
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
            this.ReturnToMonke.TabIndex = 2;
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
            this.HomeworkViewer.TabIndex = 3;
            this.HomeworkViewer.Text = "View homeworks";
            this.HomeworkViewer.UseVisualStyleBackColor = false;
            this.HomeworkViewer.Click += new System.EventHandler(this.HomeworkViewer_Click_1);
            // 
            // homeworkList
            // 
            this.homeworkList.AllowUserToAddRows = false;
            this.homeworkList.AllowUserToDeleteRows = false;
            this.homeworkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeworkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomeworkId,
            this.TeacherId,
            this.HomeworkDate,
            this.HomeworkName,
            this.Status});
            this.homeworkList.Location = new System.Drawing.Point(17, 67);
            this.homeworkList.MultiSelect = false;
            this.homeworkList.Name = "homeworkList";
            this.homeworkList.ReadOnly = true;
            this.homeworkList.RowTemplate.Height = 25;
            this.homeworkList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.homeworkList.Size = new System.Drawing.Size(354, 414);
            this.homeworkList.TabIndex = 6;
            this.homeworkList.Visible = false;
            this.homeworkList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.homeworkList_CellContentClick);
            // 
            // HomeworkId
            // 
            this.HomeworkId.HeaderText = "Id";
            this.HomeworkId.Name = "HomeworkId";
            this.HomeworkId.ReadOnly = true;
            this.HomeworkId.Width = 35;
            // 
            // TeacherId
            // 
            this.TeacherId.HeaderText = "TeacherId";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Width = 65;
            // 
            // HomeworkDate
            // 
            this.HomeworkDate.HeaderText = "Date";
            this.HomeworkDate.Name = "HomeworkDate";
            this.HomeworkDate.ReadOnly = true;
            this.HomeworkDate.Width = 75;
            // 
            // HomeworkName
            // 
            this.HomeworkName.HeaderText = "Name";
            this.HomeworkName.Name = "HomeworkName";
            this.HomeworkName.ReadOnly = true;
            this.HomeworkName.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(377, 67);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.Size = new System.Drawing.Size(608, 414);
            this.ContentBox.TabIndex = 8;
            this.ContentBox.Visible = false;
            // 
            // homeworkNameBox
            // 
            this.homeworkNameBox.Location = new System.Drawing.Point(377, 41);
            this.homeworkNameBox.Name = "homeworkNameBox";
            this.homeworkNameBox.ReadOnly = true;
            this.homeworkNameBox.Size = new System.Drawing.Size(187, 20);
            this.homeworkNameBox.TabIndex = 13;
            this.homeworkNameBox.Visible = false;
            // 
            // ReportViewer
            // 
            this.ReportViewer.BackColor = System.Drawing.SystemColors.Highlight;
            this.ReportViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReportViewer.ForeColor = System.Drawing.Color.Black;
            this.ReportViewer.Location = new System.Drawing.Point(991, 422);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(104, 59);
            this.ReportViewer.TabIndex = 14;
            this.ReportViewer.Text = "View report";
            this.ReportViewer.UseVisualStyleBackColor = false;
            this.ReportViewer.Visible = false;
            this.ReportViewer.Click += new System.EventHandler(this.ReportViewer_Click);
            // 
            // ReportCreator
            // 
            this.ReportCreator.BackColor = System.Drawing.SystemColors.Highlight;
            this.ReportCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReportCreator.ForeColor = System.Drawing.Color.Black;
            this.ReportCreator.Location = new System.Drawing.Point(991, 67);
            this.ReportCreator.Name = "ReportCreator";
            this.ReportCreator.Size = new System.Drawing.Size(104, 59);
            this.ReportCreator.TabIndex = 15;
            this.ReportCreator.Text = "Create report";
            this.ReportCreator.UseVisualStyleBackColor = false;
            this.ReportCreator.Visible = false;
            this.ReportCreator.Click += new System.EventHandler(this.ReportCreator_Click);
            // 
            // ReportSender
            // 
            this.ReportSender.BackColor = System.Drawing.SystemColors.Highlight;
            this.ReportSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReportSender.ForeColor = System.Drawing.Color.Black;
            this.ReportSender.Location = new System.Drawing.Point(991, 237);
            this.ReportSender.Name = "ReportSender";
            this.ReportSender.Size = new System.Drawing.Size(104, 59);
            this.ReportSender.TabIndex = 16;
            this.ReportSender.Text = "Send report";
            this.ReportSender.UseVisualStyleBackColor = false;
            this.ReportSender.Visible = false;
            this.ReportSender.Click += new System.EventHandler(this.ReportSender_Click);
            // 
            // SureMakingLabel
            // 
            this.SureMakingLabel.AutoSize = true;
            this.SureMakingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SureMakingLabel.ForeColor = System.Drawing.Color.Black;
            this.SureMakingLabel.Location = new System.Drawing.Point(991, 299);
            this.SureMakingLabel.Name = "SureMakingLabel";
            this.SureMakingLabel.Size = new System.Drawing.Size(73, 17);
            this.SureMakingLabel.TabIndex = 17;
            this.SureMakingLabel.Text = "You sure?";
            this.SureMakingLabel.Visible = false;
            // 
            // StudentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SureMakingLabel);
            this.Controls.Add(this.ReportSender);
            this.Controls.Add(this.ReportCreator);
            this.Controls.Add(this.ReportViewer);
            this.Controls.Add(this.homeworkNameBox);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.homeworkList);
            this.Controls.Add(this.HomeworkViewer);
            this.Controls.Add(this.ReturnToMonke);
            this.Name = "StudentReportForm";
            this.Size = new System.Drawing.Size(1173, 521);
            ((System.ComponentModel.ISupportInitialize)(this.homeworkList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMonke;
        private System.Windows.Forms.Button HomeworkViewer;
        private System.Windows.Forms.DataGridView homeworkList;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.TextBox homeworkNameBox;
        private System.Windows.Forms.Button ReportViewer;
        private System.Windows.Forms.Button ReportCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeworkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeworkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button ReportSender;
        private System.Windows.Forms.Label SureMakingLabel;
    }
}
