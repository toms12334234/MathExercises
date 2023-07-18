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
        if (until <= 1)
        {
            return new();
        }
        
        int start = 2;
        List<int> result = Enumerable.Range(start, until - start).Where(x => x %2 == 0).ToList();
        return result;
    }

    /// <summary>
    /// Calculates all prime numbers (low to high) until the collection has reached the given amount.
    /// </summary>
    /// <param name="amount">The amount of prime numbers that should be calculated</param>
    /// <returns>The amount of prime numbers that are asked.</returns>
    public static IEnumerable<int> GetPrimeNumbers(int amount)
    {
        return PrimeNumberGeneratorWithChatGpt.GetPrimeNumbersWithSieveOfEratosthenes(amount);
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

internal class PrimeNumberGeneratorWithChatGpt
{
    internal static IEnumerable<int> GetPrimeNumbersWithSieveOfEratosthenes(int amount)
    {
        List<int> primes = new();
        int n = 2;
        while (primes.Count < amount)
        {
            bool isPrime = true;
            foreach (int prime in primes)
            {
                if (n % prime == 0)
                {
                    isPrime = false;
                    break;
                }
                if (prime * prime > n)
                {
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(n);
            }
            n++;
        }
        return primes;
    }
}