namespace MathAndFun
{
    public class PrimeNumberGenerator
    {
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