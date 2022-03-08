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
        //private CaliperViewModel cali = new CaliperViewModel();

        Calculator calc = new Calculator();
        public void Co2Calc(CaliperViewModel cvm)
        {
            
            cvm.AmountCo2Saved = calc.CalcAdd(cvm.Amount, cvm.SavedCo2);
        }
    }
}
