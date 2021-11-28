using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class MainForm : Form
    {
        private DataModule DM; // the reference to the form that holds the data components
        private EmployerForm frmEmployer; 
        private CandidateForm frmCandidate; 
        private VacancyForm frmVacancy; 
        private VacancySkillForm frmVacancySkill;
        private CandidateSkillForm frmCandidateSkill; 
        private ApplicationForm frmApplication; 
        private Vacancies frmVacancies;
        private Candidates frmCandidates;







        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


   
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        private void btnEmployerMaintenance_Click(object sender, EventArgs e)
        {
            if (frmEmployer == null)
            {
                frmEmployer = new EmployerForm(DM, this);
            }
            frmEmployer.ShowDialog();
        }
    }
}
