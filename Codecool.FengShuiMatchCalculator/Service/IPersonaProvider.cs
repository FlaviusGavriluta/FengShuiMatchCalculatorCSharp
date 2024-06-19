using Codecool.FengShuiMatchCalculator.Model;

namespace Codecool.FengShuiMatchCalculator.Service;

public interface IPersonaProvider
{
    Persona FindPersona(Sign sign);
}