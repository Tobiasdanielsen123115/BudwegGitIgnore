using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BudwegCo2.ViewModel
{
    public class CaliperController
    {
        //private CaliperViewModel cali;
        private CaliperViewModel cali = new CaliperViewModel();

        Calculator calc = new Calculator();
        public void Co2Calc()
        {
            
            calc.CalcAdd(cali.Amount, cali.SavedCo2);
        }
    }
}
