using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BudwegCo2.ViewModel;

namespace BudwegCo2.View
{
    /// <summary>
    /// Interaction logic for CaliberPage.xaml
    /// </summary>
    public partial class CaliperPage : Window
    {
        CaliperViewModel cvm = new CaliperViewModel();

        
        
        public CaliperPage()
        {
            InitializeComponent();
            DataContext = cvm;                            
        }

        private void btnCalc(object sender, RoutedEventArgs e)
        {
            CaliperController caliperController = new CaliperController();
            

            caliperController.Co2Calc(cvm);
            
            
        }

        private void txtSavedCo2Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            
        }
    }
}
