using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegCo2.Model;
using System.Collections.ObjectModel;


namespace BudwegCo2.ViewModel
{
    public class WareController
    {
        //private CaliperViewModel cali;
        //private CaliperViewModel cali = new CaliperViewModel();
        
        WareRepo warerepo = new WareRepo();

        Calculator calc = new Calculator();
        public void Co2Calc(WareViewModel wvm)
        {
            
            wvm.AmountCo2Saved = calc.CalcAdd(wvm.Amount, wvm.SavedCo2);

            warerepo.SaveCo2(wvm.Date, wvm.Amount, wvm.AmountCo2Saved, wvm.CompanyID);

        }

        public void GetAllWares()
        {
            WareViewModel wvm = new WareViewModel();
            warerepo.GetAll();
            wvm.GetWares = warerepo.Wares;
        }
    }
}
