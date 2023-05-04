using Laboratorium2.Interfejsy;

namespace Laboratorium2.Klasy.Formatery
{
    internal abstract class BazowyFormaterLogow 
    {
        public string Formatuj(string logi)
        {
            return $"{DateTime.Now.ToString("HH-mm.ss")} {logi}";
        }
    }
}
