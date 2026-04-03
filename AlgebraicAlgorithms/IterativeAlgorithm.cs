namespace AlgebraicAlgorithms
{
    internal class IterativeAlgorithm
    {
        public static double ExponentiationOfNumber(double value, int exponent)
        {
            if (exponent == 0)
                return 1.0;
            bool isNegative = exponent < 0;
            int absExp = Math.Abs(exponent);

            double res = 1.0;
            for(int i = 0; i < absExp; i++)
            {
                res *= value;
            }

            return isNegative ? 1.0 / res : res;
        }
    }
}
