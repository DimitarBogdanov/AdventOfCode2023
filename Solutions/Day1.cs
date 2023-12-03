namespace AdventOfCode2023.Solutions;

public sealed class Day1 : BaseSolution
{
    public Day1() : base(1)
    {
    }

    public override string Solve()
    {
        string[] input = GetInputTextLines();

        return input
              .Select(x => x.Where(Char.IsDigit))
              .Select(x => x.Count() == 1 ? x.Concat(x) : x)
              .Select(x => $"{x.First()}{x.Last()}")
              .Select(Int32.Parse)
              .Sum()
              .ToString();
    }
}