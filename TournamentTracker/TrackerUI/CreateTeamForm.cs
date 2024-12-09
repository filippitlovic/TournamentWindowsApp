using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void selectTeamMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            //1) validate entered form
            if (ValidateForm())
            {

                //kreiraj osobu
                PersonModel person = new PersonModel();
                person.FirstName = firstNameValue.Text;
                person.LastName = lastNameValue.Text;
                person.EmailAddress = emailValue.Text; 
                person.CellphoneNumber = cellphoneValue.Text;

                //upisi u bazu
                GlobalConfig.Connection.CreatePerson(person);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text="";

            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private bool ValidateForm()
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);


            if (firstNameValue.Text.Length == 0) { 
                return false;
            }
            if(lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (!regex.IsMatch(emailValue.Text)){
                return false;
            }
            if(cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
