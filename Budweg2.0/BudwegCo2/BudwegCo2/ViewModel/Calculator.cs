using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudwegCo2.ViewModel
{
    public class Calculator
    {

        //private CaliperViewModel cali;
        private CaliperViewModel cali = new CaliperViewModel();
        public double CalcAdd(int x, double y)
        {
            
            return cali.AmountCo2Saved = x * y;         
            //caliper.AmountCo2Saved = caliper.Amount * caliper.SavedCo2;
            //return caliper.AmountCo2Saved;
        }


    }
}
