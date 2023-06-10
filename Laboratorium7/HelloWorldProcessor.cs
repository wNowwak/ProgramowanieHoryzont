namespace Laboratorium7
{
    internal class HelloWorldProcessor
    {
        public delegate void HelloWorld(string text);
        private HelloWorld _log;
        private Func<decimal> _parseToDecimal;
        private Action<string> _logInfo; 

        public HelloWorldProcessor(Func<decimal> parseToDecimal, Action<string> logInfo)
        {
            _log = Console.WriteLine;
            _log("Witaj świecie");
            _parseToDecimal = parseToDecimal;
            _logInfo = logInfo;
        }

        public decimal ParseStringToDecimal()
        {
            _logInfo($"Wywołano metodę {nameof(ParseStringToDecimal)}");
            return _parseToDecimal();
        }
    }
}
