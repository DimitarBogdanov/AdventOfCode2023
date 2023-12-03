namespace AdventOfCode2023.Solutions;

public abstract class BaseSolution
{
    public int DayNumber { get; }

    /// <summary>
    /// Solves the problem.
    /// </summary>
    /// <returns>The expected solution.</returns>
    public abstract string Solve();
    
    /// <summary>
    /// Retrieves the entire input text.
    /// </summary>
    protected string GetInputText()
    {
        return File.ReadAllText(GetPath());
    }

    /// <summary>
    /// Retrieves the lines of the input text.
    /// </summary>
    protected string[] GetInputTextLines()
    {
        return File.ReadAllLines(GetPath());
    }

    /// <summary>
    /// Retrieves the path to the input text.
    /// </summary>
    private string GetPath()
    {
        return $"./Input/{DayNumber}.txt";
    }
}