using Laboratorium3.Interfaces;
using Laboratorium3.Models;
using Newtonsoft.Json;
using System.Net;

namespace Laboratorium3
{
    internal class NBPCurrencyWebClient : NBPBaseWebClient ,ICurrencyWebClient
    {
        public NBPCurrencyWebClient(string address) : base(address)
        {
        }

        public CurrencyDTO GetCurrencyByCode(string code)
        {
            var wynik = new CurrencyDTO();

            var response = _webClient.DownloadString($"exchangerates/rates/a/{code}");
            wynik = JsonConvert.DeserializeObject<CurrencyDTO>(response);
            return wynik;
        }
    }
}
