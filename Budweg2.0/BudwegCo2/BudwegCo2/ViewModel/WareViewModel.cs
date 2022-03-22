using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegCo2.Model;
using System.Collections.ObjectModel;


namespace BudwegCo2.ViewModel
{

    public class WareViewModel : INotifyPropertyChanged
    {

        private List<Ware> getWares = new List<Ware>();

        public List<Ware> GetWares
        {
            get { return getWares; }
            set
            {
                if (getWares != value)
                {
                    getWares = value;
                    OnPropertyChanged("GetWares");
                }
            }
        }

        public int CompanyID = 1;

        public string Date { get; set; }

        public Ware ware;
        public int Amount { get; set; }

        public double SavedCo2 = 0.25;

        public event PropertyChangedEventHandler PropertyChanged;


        private double amountCo2Saved;
        public double AmountCo2Saved
        {
            get { return amountCo2Saved; }
            set
            {
                if (amountCo2Saved != value)
                {
                    amountCo2Saved = value;
                    OnPropertyChanged("AmountCo2Saved");
                }
            }
        }

        public WareViewModel(Ware ware)
        {
            Amount = ware.Amount;
            SavedCo2 = ware.SavedCo2;
            AmountCo2Saved = ware.AmountCo2Saved;
            Date = ware.Date;
            CompanyID = ware.CompanyID;
        }

        public WareViewModel() /*: base()*/
        {


        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}

