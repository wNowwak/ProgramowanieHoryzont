using Kalkulator.ViewController;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulator.View
{
    /// <summary>
    /// Interaction logic for CurrencyPage.xaml
    /// </summary>
    public partial class CurrencyPage : Page
    {
        private CurrencyPageViewController _currencyPageViewController;
        public CurrencyPage()
        {
            _currencyPageViewController = new CurrencyPageViewController();
            InitializeComponent();
            FirstGrid.DataContext = _currencyPageViewController;
            CurrencyDetails.DataContext = _currencyPageViewController;
            LastGrid.DataContext = _currencyPageViewController;
        }

        private void Currencies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = sender as ComboBox;
            var code = combobox!.SelectedItem.ToString();
            
            _currencyPageViewController.GetCurrencyByCode(code!, GetCount());
        }
        
        private int GetCount()
        {
            int result = 0;
            result = int.TryParse(currencyCount.Text, out int x) ? x : 1;
            return result;
        }
    }
}
