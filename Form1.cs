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
            dinnerParty = new DinnerParty((int)NumberOfPeopleNUD.Value,
                        fancyBox.Checked, healtyBox.Checked);
            DisplayDinnerPartyCost();
         
            birthdayParty = new BirthdayParty((int)numberBirthday.Value,
                            fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayCost();
        }

        private void DisplayBirthdayCost()
        {
            //throw new NotImplementedException();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healtyBox.Checked);
            DisplayCostLabel.Text = Cost.ToString("c"); // the "c" will formaat the Cost into a currency
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
      
    }
}
