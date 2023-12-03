namespace AdventOfCode2023.Solutions;

public sealed class Day2 : BaseSolution
{
    public Day2() : base(2)
    {
    }

    public override string Solve()
    {
        string[] input = GetInputTextLines();

        int gameIdx = 0;
        int sum = 0;
        foreach (string line in input)
        {
            string sets = line.Split(':').Last();

            gameIdx++;

            string[] subsets = sets.Split(';', StringSplitOptions.TrimEntries);

            bool invalid = false;

            foreach (string subset in subsets)
            {
                foreach ((int cubeCount, string cubeType) in Parse(subset))
                {
                    switch (cubeType)
                    {
                        case "red":
                            if (cubeCount > 12)
                            {
                                invalid = true;
                            }
                            break;
                        case "green":
                            if (cubeCount > 13)
                            {
                                invalid = true;
                            }
                            break;
                        case "blue":
                            if (cubeCount > 14)
                            {
                                invalid = true;
                            }
                            break;
                    }
                }
            }

            if (!invalid)
            {
                sum += gameIdx;
            }
        }

        return sum.ToString();
    }

    private static IEnumerable<(int, string)> Parse(string subset)
    {
        string[] split = subset.Split(
            ',',
            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string s in split)
        {
            yield return (GetNumber(s), GetText(s));
        }
    }

    private static int GetNumber(string str)
    {
        return Int32.Parse(String.Join("", str.Where(Char.IsDigit)));
    }

    private static string GetText(string str)
    {
        return String.Join("", str.Where(Char.IsLetter));
    }
}