namespace AlgebraicAlgorithms
{
    internal class Fibonacci_gold
    {
        public static ulong FibonacciGold(int n)
        {
            double fi = (1.0 + Math.Sqrt(5)) / 2.0;
            return (ulong)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 1.0 / 2.0);
        }
    }
}
