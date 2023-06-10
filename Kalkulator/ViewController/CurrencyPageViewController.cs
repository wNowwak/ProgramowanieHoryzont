using Laboratorium3;
using Laboratorium3.Interfaces;
using Laboratorium3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Kalkulator.ViewController
{
    public class CurrencyPageViewController : INotifyPropertyChanged
    {
        private readonly ICurrencyWebClient _currencyWebClient = default!;

        public event PropertyChangedEventHandler? PropertyChanged;

        public List<string> CurrencyNames
        {
            get { return _currencyNames; }
            set { _currencyNames = value; OnPropertyChanged(nameof(CurrencyNames)); }
        }
        public CurrencyDTO Currency
        {
            get { return _currency; }
            set { _currency = value; OnPropertyChanged(nameof(Currency)); }
        }
        private List<string> _currencyNames { get; set; } = new List<string>();
        private CurrencyDTO _currency { get; set; } = new();
        public CurrencyPageViewController()
        {
            _currencyWebClient = new NBPCurrencyWebClient("http://api.nbp.pl/api/");
            CurrencyNames = _currencyWebClient.GetAllCurrencies().OrderBy(_ => _).ToList();
        }

        public void GetCurrencyByCode(string code, int count = 1)
        {
            if (string.IsNullOrEmpty(code)) return;
            var task = Task.Run(() =>
            {
                Currency = _currencyWebClient.GetLastCurrencyRates(code, count);
            });
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
