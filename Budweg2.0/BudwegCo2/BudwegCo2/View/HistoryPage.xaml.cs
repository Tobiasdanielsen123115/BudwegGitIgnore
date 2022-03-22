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
    /// Interaction logic for HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Window
    {
        WareViewModel wvm = new WareViewModel();
        
        public HistoryPage()
        {
            InitializeComponent();
            DataContext = wvm;
           
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //CaliperPage cp = new CaliperPage();
            //cp.Show();
           
        }
    }
}
