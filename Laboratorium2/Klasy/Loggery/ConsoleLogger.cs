using Laboratorium2.Enums;
using Laboratorium2.Interfejsy;

namespace Laboratorium2.Klasy.Loggery
{
    internal class ConsoleLogger 
    {
        private readonly IFormaterLogow _formaterLogow;

        public ConsoleLogger(IFormaterLogow formaterLogow)
        {
            _formaterLogow = formaterLogow;
        }

        public void Log(string message, RodzajLoga typLogow)
        {
            message = _formaterLogow.FormatujLogi(message);
            Console.WriteLine(message);
        }
    }
}
