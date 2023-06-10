namespace Laboratorium7
{
    internal class Processor2
    {
        public record Czlowiek()
        {
            public string? Imie { get; init; }
            public string? Nazwisko { get; init; }
        };

        public Processor2()
        {
            var bogdan = new Czlowiek()
            {
                Imie = "Bogdan",
                Nazwisko = "Nowak"
            };
            var janek = new Czlowiek()
            {
                Imie = "Bogdan",
                Nazwisko = "Nowak"
            };

            var bolek = new Osoba("Bolesław", "Kiepura");
            var lolek = new Osoba("Bolesław", "Kiepura");

            var czySaTakieSame = bogdan == janek;
            czySaTakieSame = bolek == lolek;

        }
    }
}
