using System.Net;

namespace Laboratorium3
{
    public abstract class NBPBaseWebClient
    {
        protected WebClient _webClient;
        protected const string _dateFormat = "yyyy-MM-dd";

        public NBPBaseWebClient()
        {
            _webClient = new WebClient();
            _webClient.BaseAddress = "http://api.nbp.pl/api/";
        }
    }
}
