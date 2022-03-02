using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudwegCo2.Model
{
    public class Caliper
    {
        
        public int Amount { get; set; }

        public double SavedCo2 = 0.25;

        public double AmountCo2Saved { get; set; }

        public Caliper(int amount, double savedCo2, double amountCo2Saved)
        {
            Amount = amount;
            SavedCo2 = savedCo2;
            AmountCo2Saved = amountCo2Saved;
        }

       

    }
}
