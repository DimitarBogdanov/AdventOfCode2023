using AdventOfCode2023.Solutions;

namespace AdventOfCode2023;

public static class SolutionFactory
{
    public static BaseSolution? GetSolution(int dayNumber)
    {
        Type? solutionType = Type.GetType($"AdventOfCode2023.Solutions.Day{dayNumber}");
        
        if (solutionType == null)
        {
            return null;
        }
        
        BaseSolution solution = (BaseSolution) Activator.CreateInstance(solutionType)!;
        return solution;
    }
}