using Codecool.FengShuiMatchCalculator.Model;

namespace Codecool.FengShuiMatchCalculator.Service;

public class PersonaProvider : IPersonaProvider
{
    private readonly Persona[] _personas =
    {
        new Persona(Sign.Rat, new[] { Sign.Dragon, Sign.Monkey, Sign.Rat }, new[] { Sign.Horse, Sign.Goat }),
        new Persona(Sign.Ox, new[] { Sign.Snake, Sign.Rooster, Sign.Ox }, new[] { Sign.Goat, Sign.Horse }),
        new Persona(Sign.Tiger, new[] { Sign.Horse, Sign.Dog, Sign.Tiger }, new[] { Sign.Monkey, Sign.Snake }),
        new Persona(Sign.Rabbit, new[] { Sign.Pig, Sign.Goat, Sign.Rabbit }, new[] { Sign.Rooster, Sign.Dragon }),
        new Persona(Sign.Dragon, new[] { Sign.Rat, Sign.Monkey, Sign.Dragon }, new[] { Sign.Dog, Sign.Rabbit }),
        new Persona(Sign.Snake, new[] { Sign.Ox, Sign.Rooster, Sign.Snake }, new[] { Sign.Pig, Sign.Tiger }),
        new Persona(Sign.Horse, new[] { Sign.Dog, Sign.Tiger, Sign.Horse }, new[] { Sign.Rat, Sign.Ox }),
        new Persona(Sign.Goat, new[] { Sign.Rabbit, Sign.Pig, Sign.Goat }, new[] { Sign.Ox, Sign.Rat }),
        new Persona(Sign.Monkey, new[] { Sign.Dragon, Sign.Rat, Sign.Monkey }, new[] { Sign.Tiger, Sign.Pig }),
        new Persona(Sign.Rooster, new[] { Sign.Ox, Sign.Snake, Sign.Rooster }, new[] { Sign.Rabbit, Sign.Dog }),
        new Persona(Sign.Dog, new[] { Sign.Tiger, Sign.Horse, Sign.Dog }, new[] { Sign.Dragon, Sign.Rooster }),
        new Persona(Sign.Pig, new[] { Sign.Rabbit, Sign.Goat, Sign.Pig }, new[] { Sign.Snake, Sign.Monkey })
    };


    public Persona FindPersona(Sign sign)
    {
        foreach (var zodiacPersona in _personas)
        {
            if (zodiacPersona.Sign == sign)
            {
                return zodiacPersona;
            }
        }

        throw new Exception($"Sign: {sign} not found");
    }
}
