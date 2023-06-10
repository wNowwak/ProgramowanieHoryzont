using Laboratorium7;
using System.Net.Http.Headers;

internal class Program
{
    static void Main(string[] args)
    {
        //Func<decimal> parseToDecimal = () =>
        //{
        //    Console.WriteLine("Podaj dowolną liczbę");
        //    var liczba = Console.ReadLine();
        //    return decimal.Parse(liczba!);
        //};
        //Action<string> logging = Console.WriteLine;
        //var processor = new HelloWorldProcessor(parseToDecimal, logging);
        //var liczba = processor.ParseStringToDecimal();

        var processor = new Processor2();


        Console.ReadLine();

    }
}
