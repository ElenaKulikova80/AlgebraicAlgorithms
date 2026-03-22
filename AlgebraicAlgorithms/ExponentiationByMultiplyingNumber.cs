namespace AlgebraicAlgorithms
{
    internal class ExponentiationByMultiplyingNumber
    {
        public static double Recursia(double x, uint n)
        {
            if (n == 0) return 1.0;

            if ((n % 2) > 0)
            {
                double y = Recursia(x, n / 2);
                return x * y * y;
            }
            else
            {
                double y = Recursia(x, n / 2);
                return y * y;
            }
        }
    }
}
