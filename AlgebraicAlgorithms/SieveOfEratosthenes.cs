namespace AlgebraicAlgorithms
{
    internal class SieveOfEratosthenes
    {
        public static List<int> FindPrimes(int n)
        {
            if (n < 2)
                throw new ArgumentException("Нужно n>=2, чтобы были простые числа.");

            //все числа считаем простыми
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                isPrime[i] = true;

            //просеивание
            for (int p =2; p*p <=n; p++)
            {
                if (isPrime[p])
                {
                    for (int j = p * p; j <= n; j += p)
                        isPrime[j] = false;
                }
            }

            //простые числа
            List<int> primes = new List<int>();
            for(int i=2; i<=n; i++)
            {
                if (isPrime[i])
                    primes.Add(i);
            }

            return primes;
        } 
    }
}
