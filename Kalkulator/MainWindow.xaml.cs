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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NuberButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(resultText.Text))
            {
                firstNumber.Text = string.Empty;
                lastNumber.Text = string.Empty;
                operation.Text = string.Empty;
                resultText.Text = string.Empty;
            }
            var button = sender as Button;
            if(string.IsNullOrEmpty(operation.Text))
                firstNumber.Text += button!.Content;
            else
                lastNumber.Text += button!.Content;
        }

        private void OperationButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            operation.Text = button!.Content.ToString();
        }

        private void CountResult(object sender, RoutedEventArgs e)
        {
            var first = int.Parse(firstNumber.Text);
            var last = int.Parse(lastNumber.Text);

            var result = operation.Text switch
            {
                "*" => first * last,
                "/" => first / last,
                "+" => first + last,
                "-" => first - last,
                _ => 0
            };

            resultText.Text = result.ToString();
        }
    }
}
