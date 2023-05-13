using Laboratorium3.Interfaces;
using Laboratorium3.Models;
using Newtonsoft.Json;
using System.Net;

namespace Laboratorium3
{
    internal class NBPGoldRateWebClient : NBPBaseWebClient, IGoldRateWebClient
    {
        #region Constructors
        public GoldDTO GetLastGoldRate()
        {
            GoldDTO wynik = new GoldDTO();
            var response = _webClient.DownloadString("cenyzlota");

            wynik = JsonConvert.DeserializeObject<GoldDTO[]>(response)!.First();
            return wynik;
        }
        #endregion
        #region Public Methods
        public GoldDTO[] GetLastGoldRates(int count)
        {
            var wynik = new GoldDTO[count];
            
            var response = _webClient.DownloadString($"cenyzlota/last/{count}");

            wynik = JsonConvert.DeserializeObject<GoldDTO[]>(response);
            
            return wynik;
        }

        public GoldDTO GetGoldRateInSpecificDate(DateTime date)
        {
            var wynik = new GoldDTO();
            try
            {
                var response = _webClient.DownloadString($"cenyzlota/{date.ToString(_dateFormat)}");
                wynik = JsonConvert.DeserializeObject<GoldDTO[]>(response).First();
                Console.WriteLine($"Notowanie w dniu: {wynik.Date}: {wynik.Price}");
            }
            catch (WebException ex)
            {
                if(ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response =ex.Response as HttpWebResponse;
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Brak notowania w dniu: {date.ToString(_dateFormat)}");
                    }
                }
                else
                    Console.WriteLine($"Nieznany błąd :{ex.Message}");
            }

            return wynik;
        }

        public bool IsGoldRatePublishedToday()
        {
            var wynik = false;

            try
            {
                var response = _webClient.DownloadString($"cenyzlota/today");
                var dzisiejszeNotowanie = JsonConvert.DeserializeObject<GoldDTO[]>(response).First();
                wynik = dzisiejszeNotowanie != null;
                return wynik;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                       return false;
                    }
                }
                else
                    Console.WriteLine($"Nieznany błąd :{ex.Message}");
            }

            return wynik;
        }

        public IList<GoldDTO> GetGoldRatesInSpecificPeriod(DateTime startDate, DateTime endDate)
        {
            var wynik = new List<GoldDTO>();

            var response = _webClient.DownloadString($"cenyzlota/{startDate.ToString(_dateFormat)}" +
                $"/{endDate.ToString(_dateFormat)}");
            wynik = JsonConvert.DeserializeObject<List<GoldDTO>>(response); 

            return wynik!;
        }
        #endregion
        #region Private methods

        #endregion
    }
}
