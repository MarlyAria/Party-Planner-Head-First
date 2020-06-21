using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberDinner.Value, healthyBox.Checked, fancyDinnerBox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value,
                            fancyBirthdayBox.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        #region DinnerParty
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            DisplayCostLabel.Text = Cost.ToString("c"); // the "c" will format the Cost into a currency
        }

        private void numberDinner_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberDinner.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyDinnerBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDinnerBox.Checked;
            DisplayDinnerPartyCost();
        }


        private void healtyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }


        #endregion

        #region BirthdayParty
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            DisplayBirthdayCostLabel.Text = cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthdayBox_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthdayBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
            #endregion

        }
    }
}
