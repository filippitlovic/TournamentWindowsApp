using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //Kreiranje modela 
                PrizeModel model = new PrizeModel(placeNameValue.Text,placeNumberValue.Text,prizeAmountValue.Text,prizePercentageValue.Text);
               
                //ovo mi nije jasno cemu to radi
                
                GlobalConfig.Connection.CreatePrize(model);

                //Nakon klika na button, da se forma očisti, da se sve vrati na početne vrijednosti
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        //validacije je li sve dobro unešeno
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            //pošto je textbox string vrijednost, ova funkcija uzima string i pokusava ga pretvorit u int i stavit u varijablu placeNumber
           // pošto mi u placeNumber ne dajemo parametar vec u njega tek stavljam vijednost, ide out
           //ide out jer dotad nema nikakvu vrijednost
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber); 


            if (placeNumberValidNumber == false ) 
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }


            if(placeNameValue.Text.Length == 0)
            {
                output = false;
            }


            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if (prizeAmount <=0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
