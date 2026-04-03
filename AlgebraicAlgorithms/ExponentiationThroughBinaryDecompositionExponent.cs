namespace AlgebraicAlgorithms
{
    internal class ExponentiationThroughBinaryDecompositionExponent 
    {
        public static double BinaryВecompositionExp(double val, uint exp)
        {
            double res = 1.0;
            if (val == 0.0)
                throw new ArgumentException("Значение не должно бфть равным нулю", nameof(val));
            double current = val;

            while (exp > 0)
            {
                if ((exp & 1) == 1)
                {
                    res *= current;
                }

                current *= current;
                if (double.IsInfinity(current) && exp > 1)
                    throw new OverflowException("Переполнение промежуточного результата");
                exp >>= 1;
            }

            return res;
        }
        
    }
}
