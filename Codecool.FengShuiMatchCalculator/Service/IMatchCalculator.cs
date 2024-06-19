using Codecool.FengShuiMatchCalculator.Model;

namespace Codecool.FengShuiMatchCalculator.Service;

public interface IMatchCalculator
{
    Match Calculate(DateTime birthdate1, DateTime birthdate2);
}