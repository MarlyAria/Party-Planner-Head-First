using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecoractions { get; set; }
        public string CakeWriting { get; set; }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int MaxWritingLength()
        {
            // bepaald hoeveel letter er op een taart kunnen
            if (Cakesize() == 8)
                return 16;
            else
                return 40;
        }

        private int Cakesize()
        {
            // bepaald de groote van een taart
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }


        public BirthdayParty(int numberOfPeople,
            bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecoractions = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        private Decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecoractions)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;

        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (Cakesize() == 8)
                    cakeCost = 40m + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25m;
                return totalCost + cakeCost;
            }
        }
    }
}
