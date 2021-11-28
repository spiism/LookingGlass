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
    public partial class EmployerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;




        public EmployerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddEmployer.Left = 220;
            pnlAddEmployer.Top = 40;
           
        }


        public void BindControls()
        {
            txtEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Street Address");
            txtSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Suburb");
            txtPhone.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.PhoneNumber");

            txtEmployerID.Enabled = false;
            txtEmployerName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhone.Enabled = false;
            lstEmployer.DataSource = DM.dsLookingGlass;
            lstEmployer.DisplayMember = "Employer.EmployerName";
            lstEmployer.ValueMember = "Employer.EmployerName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployerForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            DataRow deleteEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];

            if ((txtEmployerID.Text == "") || (txtEmployerName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtPhone.Text == ""))

           
           
            { 
                MessageBox.Show("You may only delete Employer exists", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEmployerRow.Delete();
                    DM.UpdateEmployer();
                }
            }
        }

        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            DataRow updateEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
            if ((txtEmployerID.Text == "") || (txtEmployerName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtPhone.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                //Add the text areas


                updateEmployerRow["EmployerID"] = txtEmployerID.Text;
                updateEmployerRow["EmployerName"] = txtEmployerName.Text;
                updateEmployerRow["Street Address"] = txtStreetAddress.Text;
                updateEmployerRow["Suburb"] = txtSuburb.Text;
                updateEmployerRow["PhoneNumber"] = txtPhone.Text;

                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateEmployer();
                //Give the user a success message
                MessageBox.Show("Employer updated successfully", "Success");
            }


        }


       


        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            lstEmployer.Visible = false; // Note that if you use this line of code
            lstEmployer.Enabled = false; // … you do not need this line
            lstEmployer.SelectedItem = null; // … or this line
            btnDeleteEmployer.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEmployer.Enabled = false;
            btnAddEmployer.Enabled = false;
            pnlAddEmployer.Show();


            lblEmployerID.Text = null;
            DataRow newEmployerRow = DM.dtEmployer.NewRow();
            if ((txtEmployerName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtPhone.Text == ""))
                {
                MessageBox.Show("You must type in box", "Error");
            }
            else
            {


    
                newEmployerRow["EmployerName"] = txtEmployerName.Text;
                newEmployerRow["Street Address"] = txtStreetAddress.Text;
                newEmployerRow["Suburb"] = txtSuburb.Text;
                newEmployerRow["PhoneNumber"] = txtPhone.Text;
                DM.dtEmployer.Rows.Add(newEmployerRow);
                

                DM.UpdateEmployer();


               
            }





        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEmployer.Hide();
            lstEmployer.Enabled = true;
            lstEmployer.Visible = true;
            btnDeleteEmployer.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnAddEmployer.Enabled = true;
        }

        private void btnSaveEmployer_Click(object sender, EventArgs e)
        {
            lblEmployerID.Text = null;
            DataRow newEmployerRow = DM.dtEmployer.NewRow();
            if ((txtAddEmployerName.Text == "") || (txtAddAddress.Text == "") || (txtAddSuburb.Text == "") || (txtAddPhone.Text == ""))
            {
                MessageBox.Show("You must type in box", "Error");
            }
            else
            {
                try
                {


                   
                    newEmployerRow["EmployerName"] = txtAddEmployerName.Text;
                    newEmployerRow["Street Address"] = txtAddAddress.Text;
                    newEmployerRow["Suburb"] = txtAddSuburb.Text;
                    newEmployerRow["PhoneNumber"] = txtAddPhone.Text;
                    DM.dtEmployer.Rows.Add(newEmployerRow);

                    MessageBox.Show("Employer added successfully", "Success");
                    DM.UpdateEmployer();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter number for Employer ID", "Error");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

    

        private void pnlUpdateEmployer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAddEmployer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUpdateEmployerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
