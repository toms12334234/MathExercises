

namespace MathAndFun;

public static class MathFunctions
{
    /// <summary>
    /// Calculates all even numbers, 0 not included, until the given number.
    /// </summary>
    /// <param name="until">this number will NOT be included in the even numbers</param>
    /// <returns>Even numbers until given number excluding 0.</returns>
    public static List<int> GetEvenNumbers(int until)
    {
        return new();
    }

    /// <summary>
    /// Calculates all prime numbers (low to high) until the collection has reached the given amount.
    /// </summary>
    /// <param name="amount">The amount of prime numbers that should be calculated</param>
    /// <returns>The amount of prime numbers that are asked.</returns>
    public static IEnumerable<int> GetPrimeNumbers(int amount)
    {
        var result = new List<int>();

        for (int integerUnderTest = 2; result.Count < amount; integerUnderTest++)
        {
            if (ADenominatorExists(integerUnderTest))
            {
                continue;
            }
            result.Add(integerUnderTest);
        }

        return result;
    }

    private static bool ADenominatorExists(int integerUnderTest)
    {
        for (int i = 2; i < integerUnderTest; i++)
        {
            double division = (double)integerUnderTest/i;
            double modulo = division % 1;
            if (modulo == 0)
            {
                return true;
            }
        }
        return false;
    }


    /// <summary>
    /// Calculates if the given sudoku result is correct.
    /// </summary>
    /// <param name="lines">The 9 rows with 9 numbers separated by space.</param>
    /// <returns>true if valid</returns>
    public static bool ValidateSudoku(string[] lines)
    {
        return true;
    }

}