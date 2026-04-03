using System.Numerics;

namespace AlgebraicAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 50;

            double exponentiationOfNumber = IterativeAlgorithm.ExponentiationOfNumber(2, -3);
            Console.WriteLine($"Итеративный алгоритм возведения числа 2 в степень -3: {exponentiationOfNumber}");

            long fibRecursive = FibonacciNumberSearchAlgorithms.FibRecursive(N);
            Console.WriteLine($"Рекурсивный поиск {N}-го числа Фибоначчи: {fibRecursive}");

            BigInteger fibIterative = FibonacciNumberSearchAlgorithms.FibIterative(N);
            Console.WriteLine($"Итеративный поиск {N}-го числа Фибоначчи: {fibIterative}");

            int countPrimes = Primes.Count(N);
            Console.WriteLine($"Количество простых чисел через перебор делителей до {N}: {countPrimes}");

            double ExpMultiplyingNumber = ExponentiationByMultiplyingNumber.Recursia(2, 7);
            Console.WriteLine($"Результат алгоритма возведения в степень через домножение: {ExpMultiplyingNumber}");

            double ExpBinaryDecompositionExponent = ExponentiationThroughBinaryDecompositionExponent.BinaryВecompositionExp(2, 7);
            Console.WriteLine($"Результат алгоритма возведения в степень через бинарное разложение степени: {ExpBinaryDecompositionExponent}");

            ulong FibonacciGold = Fibonacci_gold.FibonacciGold(10);
            Console.WriteLine($"Результат алгоритма поиска чисел Фибоначчи по формуле золотого сечения: {FibonacciGold}");

            var N1 = 30;
            var primes = SieveOfEratosthenes.FindPrimes(N1);
            Console.WriteLine($"Простые числа <= {N1}:");
            Console.WriteLine(string.Join(",", primes));
        }
    }
}
