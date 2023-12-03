using AdventOfCode2023.Solutions;

namespace AdventOfCode2023;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter day number: ");
        
        int dayNumber = Int32.Parse(Console.ReadLine()!);
        
        BaseSolution? solution = SolutionFactory.GetSolution(dayNumber);
        if (solution == null)
        {
            Console.WriteLine("Solution not found.");
            return;
        }
        
        string output = solution.Solve();
        Console.WriteLine($"Solution: {output}");
    }
}