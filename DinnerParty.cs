using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int NumberOfPeople { get; set; }
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople,
            bool fancyDecorations, bool healtyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healtyOption;
        }
        public void SetPartyOptions(int People, bool fancy)
        {
            NumberOfPeople = People;
            CalculateCostOfDecoration(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
        public void SetHealthyOption(bool HealthyOption)
        {
            if (HealthyOption)

            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecoration(bool Fancy)

        {
            if (Fancy)
            {
                CostOfDecorations = 50M + (15.0M * NumberOfPeople);
            }
            else
            {
                CostOfDecorations = 30M + (7.50M * NumberOfPeople);
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
                * NumberOfPeople);

            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }

        }
    }
}