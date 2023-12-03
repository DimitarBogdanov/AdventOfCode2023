using System.Text;

namespace AdventOfCode2023.Solutions;

public sealed class Day1 : BaseSolution
{
    public Day1() : base(1)
    {
    }

    public override string Solve()
    {
        string[] input = GetInputTextLines();
        char[][] newInput = new char[input.Length][];
        for (int i = 0; i < input.Length; i++)
        {
            newInput[i] = new char[2];
        }

        string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        
        for (int i = 0; i < input.Length; i++)
        {
            string inputStr = input[i];

            for (int j = 0; j < inputStr.Length; j++)
            {
                if (Char.IsDigit(inputStr[j]))
                {
                    newInput[i][0] = inputStr[j];
                    break;
                }

                bool found = false;
                for (int k = 0; k < numbers.Length; k++)
                {
                    string num = numbers[k];
                    if (inputStr.Substring(j).StartsWith(num))
                    {
                        newInput[i][0] = (k + 1).ToString()[0];

                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
        }
        
        for (int i = 0; i < input.Length; i++)
        {
            string inputStr = input[i];

            for (int j = inputStr.Length - 1; j >= 0; j--)
            {
                if (Char.IsDigit(inputStr[j]))
                {
                    newInput[i][1] = inputStr[j];
                    break;
                }

                bool found = false;
                for (int k = 0; k < numbers.Length; k++)
                {
                    string num = numbers[k];
                    if (inputStr.Substring(j).StartsWith(num))
                    {
                        newInput[i][1] = (k + 1).ToString()[0];

                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
        }

        return newInput
              .Select(x => Int32.Parse($"{x[0]}{x[1]}"))
              .Sum()
              .ToString();
    }
}