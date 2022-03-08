using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegCo2.Model;


namespace BudwegCo2.ViewModel
{
    public class CaliperViewModel : INotifyPropertyChanged
    {

        public Caliper caliper;
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

        public CaliperViewModel(Caliper caliper)
        {
            Amount = caliper.Amount;
            SavedCo2 = caliper.SavedCo2;
            AmountCo2Saved = caliper.AmountCo2Saved;
        }

        public CaliperViewModel() /*: base()*/
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

