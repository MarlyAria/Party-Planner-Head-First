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
            dinnerParty = new DinnerParty((int)NumberOfPeopleNUD.Value);
            dinnerParty.SetHealthyOption(healtyBox.Checked);
            dinnerParty.CalculateCostOfDecoration(fancyBox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value,
                            fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healtyBox.Checked);
            DisplayCostLabel.Text = Cost.ToString("c"); // the "c" will formaat the Cost into a currency
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            DisplayBirthdayCostLabel.Text = cost.ToString("c");
        }
        private void NumberOfPeopleNUD_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)NumberOfPeopleNUD.Value, fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecoration(fancyBox.Checked);
            DisplayDinnerPartyCost();

        }

        private void HealtyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healtyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecoractions = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
