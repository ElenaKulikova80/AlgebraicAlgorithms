using System.Numerics;

namespace AlgebraicAlgorithms
{
    internal class FibonacciNumberSearchAlgorithms
    {
        public static long FibRecursive(int n)
        {
            if (n < 0)
                throw new ArgumentException("n должно быть >= 0", nameof(n));

            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibRecursive(n - 1) + FibRecursive(n - 2);
        }

        public static BigInteger FibIterative(int n)
        {
            if (n < 0)
                throw new ArgumentException("n должно быть >= 0");

            if (n == 0) return 0;
            if (n == 1) return 1;

            BigInteger a = 0, b = 1;

            for (int i = 2; i <= n; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
