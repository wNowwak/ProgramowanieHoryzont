namespace Laboratorium2.TypyGeneryczne
{
    internal class Kalkulator
    {
        public T Dodaj<T>(T x, T y) where T : struct
        {
            return x + y;
        }

        public T Odejmij<T>(int x, int y)
        {
            return x - y;
        }
    }
}
