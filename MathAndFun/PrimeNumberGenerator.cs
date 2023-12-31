namespace MathAndFun
{
    public class PrimeNumberGenerator
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

        public IEnumerable<int> GetPrimeNumbers(int amount)
        {
            for (int integerUnderTest = 3; PrimeNumbersFoundSoFar.Count < amount; integerUnderTest += 2)
            {
                if (ADenominatorExists(integerUnderTest))
                {
                    continue;
                }
                PrimeNumbersFoundSoFar.Add(integerUnderTest);
            }

            return PrimeNumbersFoundSoFar;
        }

        private SortedSet<int> PrimeNumbersFoundSoFar { get; set; } = new SortedSet<int>
        {
            2
        };

        private bool ADenominatorExists(int integerUnderTest)
        {
            foreach (int aPreviousPrimeNumber in PrimeNumbersFoundSoFar)
            {
                double division = (double)integerUnderTest / aPreviousPrimeNumber;
                double modulo = division % 1;
                if (modulo == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}