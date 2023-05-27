using Laboratorium3.Interfaces;
using ProjektFinalny.Interfaces;

namespace ProjektFinalny.Processors;

internal class GoldRateProcessor : IGoldRateProcessor
{
    private readonly IUserInputHandler _userInputHandler = default!;
    private readonly IGoldRateWebClient _goldRateWebClient = default!;

    public GoldRateProcessor(IUserInputHandler userInputHandler, IGoldRateWebClient goldRateWebClient)
    {
        _userInputHandler = userInputHandler;
        _goldRateWebClient = goldRateWebClient;
    }

    public void Process()
    {
        var input = _userInputHandler.GetUserInput(Messages.GoldOptions);
        switch (input)
        {
            case "1":
                _goldRateWebClient.GetLastGoldRate();
                break;
            default:
                break;
        }
    }
}
