using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LookingGlass
{
    public partial class DataModule : Form
    {
        public DataTable dtApplication;
        public DataTable dtCandidate;
        public DataTable dtCandidateSkill;
        public DataTable dtEmployer;
        public DataTable dtSkill;
        public DataTable dtVacancy;
        public DataTable dtVacancySkill;
        public DataView applicationView;
        public DataView candidateView;
        public DataView candidateSkillView;
        public DataView employerView;
        public DataView skillView;
        public DataView vacancyView;
        public DataView vacancySkillView;




        public DataModule()
        {
            InitializeComponent();

            dsLookingGlass.EnforceConstraints = false;
            daApplication.Fill(dsLookingGlass);
            daCandidate.Fill(dsLookingGlass);
            daCandidateSkill.Fill(dsLookingGlass);
            daEmployer.Fill(dsLookingGlass);
            daSkill.Fill(dsLookingGlass);
            daVacancy.Fill(dsLookingGlass);
            daVacancySkill.Fill(dsLookingGlass);
            dtApplication = dsLookingGlass.Tables["Application"];
            dtCandidate = dsLookingGlass.Tables["Candidate"];
            dtCandidateSkill = dsLookingGlass.Tables["CandidateSkill"];
            dtEmployer = dsLookingGlass.Tables["Employer"];
            dtSkill = dsLookingGlass.Tables["Skill"];
            dtVacancy = dsLookingGlass.Tables["Vacancy"];
            dsLookingGlass.EnforceConstraints = true;
            applicationView = new DataView(dtApplication);
            applicationView.Sort = "VacancyID";
            candidateView = new DataView(dtCandidate);
            candidateView.Sort = "CandidateID";
            employerView = new DataView(dtEmployer);
            employerView.Sort = "EmployerID";
            skillView = new DataView(dtSkill);
            skillView.Sort = "SkillID";
        }

        public void UpdateEmployer()
        {
            daEmployer.Update(dtEmployer);
        }




        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void oleDbConnection2_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }

        private void oleDbDataAdapter1_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daSkill_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daEmployer_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.

        }
    }
}
