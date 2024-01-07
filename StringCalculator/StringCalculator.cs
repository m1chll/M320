using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator;

public class StringCalculator
{
    public int CalledCount { get; set; }

    private int Sum { get; set; } = 0;
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        int number1 = numbers[0] - 48;
        return number1;
    }

    public int AddTwo(string numbers)
    {
        int number1 = numbers[0] - 48;
        int number2 = numbers[numbers.Length - 1] - 48;
        return number1 + number2;
    }

    public int AddMany(string numbers)
    {
        CalledCount++;
        var tokens = numbers.Split(',', '\n', ';');

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int z))
            {
                if (z < 0)
                {
                    throw new InvalidOperationException($"Negatives not allowed: {z}");
                }
                else if (z < 1000)
                {
                    Sum += z;
                }
            }
        }
        return Sum;
    }
}
