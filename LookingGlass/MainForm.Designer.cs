namespace LookingGlass
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.bntApplicationMaintenance = new System.Windows.Forms.Button();
            this.bntAssignCandidate = new System.Windows.Forms.Button();
            this.bntAssignVacancy = new System.Windows.Forms.Button();
            this.bntVacancyMaintenance = new System.Windows.Forms.Button();
            this.bntCandidateMaintenance = new System.Windows.Forms.Button();
            this.bntEmployerMaintenance = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnVacancies = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.bntApplicationMaintenance);
            this.grpMaintenance.Controls.Add(this.bntAssignCandidate);
            this.grpMaintenance.Controls.Add(this.bntAssignVacancy);
            this.grpMaintenance.Controls.Add(this.bntVacancyMaintenance);
            this.grpMaintenance.Controls.Add(this.bntCandidateMaintenance);
            this.grpMaintenance.Controls.Add(this.bntEmployerMaintenance);
            this.grpMaintenance.Location = new System.Drawing.Point(39, 31);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(308, 383);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // bntApplicationMaintenance
            // 
            this.bntApplicationMaintenance.Location = new System.Drawing.Point(28, 317);
            this.bntApplicationMaintenance.Name = "bntApplicationMaintenance";
            this.bntApplicationMaintenance.Size = new System.Drawing.Size(250, 41);
            this.bntApplicationMaintenance.TabIndex = 0;
            this.bntApplicationMaintenance.Text = "Application Maintenance";
            this.bntApplicationMaintenance.UseVisualStyleBackColor = true;
            // 
            // bntAssignCandidate
            // 
            this.bntAssignCandidate.Location = new System.Drawing.Point(28, 260);
            this.bntAssignCandidate.Name = "bntAssignCandidate";
            this.bntAssignCandidate.Size = new System.Drawing.Size(250, 41);
            this.bntAssignCandidate.TabIndex = 0;
            this.bntAssignCandidate.Text = "Assign Skill to a Candidate";
            this.bntAssignCandidate.UseVisualStyleBackColor = true;
            this.bntAssignCandidate.Click += new System.EventHandler(this.button5_Click);
            // 
            // bntAssignVacancy
            // 
            this.bntAssignVacancy.Location = new System.Drawing.Point(28, 197);
            this.bntAssignVacancy.Name = "bntAssignVacancy";
            this.bntAssignVacancy.Size = new System.Drawing.Size(250, 41);
            this.bntAssignVacancy.TabIndex = 0;
            this.bntAssignVacancy.Text = "Assign Skill to a Vacancy";
            this.bntAssignVacancy.UseVisualStyleBackColor = true;
            // 
            // bntVacancyMaintenance
            // 
            this.bntVacancyMaintenance.Location = new System.Drawing.Point(28, 138);
            this.bntVacancyMaintenance.Name = "bntVacancyMaintenance";
            this.bntVacancyMaintenance.Size = new System.Drawing.Size(250, 41);
            this.bntVacancyMaintenance.TabIndex = 0;
            this.bntVacancyMaintenance.Text = "Vacancy Maintenance";
            this.bntVacancyMaintenance.UseVisualStyleBackColor = true;
            // 
            // bntCandidateMaintenance
            // 
            this.bntCandidateMaintenance.Location = new System.Drawing.Point(28, 80);
            this.bntCandidateMaintenance.Name = "bntCandidateMaintenance";
            this.bntCandidateMaintenance.Size = new System.Drawing.Size(250, 41);
            this.bntCandidateMaintenance.TabIndex = 0;
            this.bntCandidateMaintenance.Text = "Candidate Maintenance";
            this.bntCandidateMaintenance.UseVisualStyleBackColor = true;
            // 
            // bntEmployerMaintenance
            // 
            this.bntEmployerMaintenance.Location = new System.Drawing.Point(28, 21);
            this.bntEmployerMaintenance.Name = "bntEmployerMaintenance";
            this.bntEmployerMaintenance.Size = new System.Drawing.Size(250, 41);
            this.bntEmployerMaintenance.TabIndex = 0;
            this.bntEmployerMaintenance.Text = "Employer Maintenance";
            this.bntEmployerMaintenance.UseVisualStyleBackColor = true;
            this.bntEmployerMaintenance.Click += new System.EventHandler(this.btnEmployerMaintenance_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnCandidates);
            this.grpReport.Controls.Add(this.btnVacancies);
            this.grpReport.Location = new System.Drawing.Point(445, 31);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(269, 383);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(53, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.Location = new System.Drawing.Point(53, 80);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(181, 41);
            this.btnCandidates.TabIndex = 0;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            // 
            // btnVacancies
            // 
            this.btnVacancies.Location = new System.Drawing.Point(53, 21);
            this.btnVacancies.Name = "btnVacancies";
            this.btnVacancies.Size = new System.Drawing.Size(181, 41);
            this.btnVacancies.TabIndex = 0;
            this.btnVacancies.Text = "Vacancies";
            this.btnVacancies.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button bntApplicationMaintenance;
        private System.Windows.Forms.Button bntAssignCandidate;
        private System.Windows.Forms.Button bntAssignVacancy;
        private System.Windows.Forms.Button bntVacancyMaintenance;
        private System.Windows.Forms.Button bntCandidateMaintenance;
        private System.Windows.Forms.Button bntEmployerMaintenance;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnVacancies;
    }
}

