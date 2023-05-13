using Laboratorium3.Models;

namespace Laboratorium3.Interfaces
{
    public interface ICurrencyWebClient
    {
        CurrencyDTO GetCurrencyByCode(string code);
    }
}
