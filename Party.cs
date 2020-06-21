using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        internal int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
       
        private decimal CalculateCostOfDecoration()
        {
            decimal CostOfDecorations;
            if (FancyDecorations)
            {
                CostOfDecorations = 50M + (15.0M * NumberOfPeople);
            }
            else
            {
                CostOfDecorations = 30M + (7.50M * NumberOfPeople);
            }
        }

        virtual public Decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }

    }
}
