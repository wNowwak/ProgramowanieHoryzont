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

namespace Kalkulator.View
{
    /// <summary>
    /// Interaction logic for Currencies.xaml
    /// </summary>
    public partial class Currencies : Window
    {
        public Currencies()
        {
            InitializeComponent();
            var page = new CurrencyPage();
            MainFrame.Navigate(page);
        }
    }
}
