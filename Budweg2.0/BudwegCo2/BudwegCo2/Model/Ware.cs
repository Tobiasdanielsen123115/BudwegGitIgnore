using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudwegCo2.Model
{
    public class Ware
    {
        public int Amount { get; set; }

        public int CompanyID = 1;

        public string Date { get; set; }

        public double SavedCo2 = 0.25;

        public double AmountCo2Saved { get; set; }

        public Ware(int amount, double savedCo2, double amountCo2Saved, string date, int companyID)
        {
            Amount = amount;
            SavedCo2 = savedCo2;
            AmountCo2Saved = amountCo2Saved;
            Date = date;
            CompanyID = companyID;
        }

        public Ware()
        {

        }

       

    }
}
