using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class DinnerParty:Party
    {
        public decimal CostOfBeveragesPerPerson;
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
            
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