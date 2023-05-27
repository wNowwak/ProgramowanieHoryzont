using ProjektFinalny.Interfaces;

namespace ProjektFinalny.Processors;

public class MainAppProcessor
{
    private readonly IUserInputHandler _userInputHandler = default!;
    private readonly IGoldRateProcessor _goldRateProcessor = default!;

    public MainAppProcessor(IUserInputHandler userInputHandler, IGoldRateProcessor goldRateProcessor)
    {
        _userInputHandler = userInputHandler;
        _goldRateProcessor = goldRateProcessor;
    }

    public void Process()
    {
        var userInput = _userInputHandler.GetUserInput(Messages.WhatToDo);
        switch (userInput)
        {
            case "1":
                break;
            case "2":
                _goldRateProcessor.Process();
                break;
            default:
                break;
        }
    }

}
