
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BirthdayParty : Party
    {
       
        public BirthdayParty
            (int numberOfPeople, bool fancydecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancydecorations;
            CakeWriting = cakeWriting;
        }
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
        private int Cakesize()
        {
            // bepaald de groote van een taart
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }
            private int MaxWritingLength()
        {
            // bepaald hoeveel letter er op een taart kunnen
            if (Cakesize() == 8)
                return 16;
            else
                return 40;
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

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
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
