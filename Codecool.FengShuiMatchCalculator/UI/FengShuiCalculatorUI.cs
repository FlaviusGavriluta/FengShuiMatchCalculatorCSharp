using Codecool.FengShuiMatchCalculator.Model;
using Codecool.FengShuiMatchCalculator.Service;

namespace Codecool.FengShuiMatchCalculator.UI;

public class FengShuiCalculatorUi
{
    private readonly IMatchCalculator _matchCalculator;

    public FengShuiCalculatorUi(IMatchCalculator matchCalculator)
    {
        _matchCalculator = matchCalculator;
    }

    public void Run()
    {
        DisplayWelcomeMessage();
        var birthdate1 = GetBirthDate(1);
        var birthdate2 = GetBirthDate(2);

        Match match = _matchCalculator.Calculate(birthdate1, birthdate2);
        Console.WriteLine("Feng shui match result: " + match);
    }

    private void DisplayWelcomeMessage()
    {
        Console.WriteLine("*** FENG SHUI MATCH CALCULATOR ***");
    }

    private DateTime GetBirthDate(int person)
    {
    }
}
