namespace AlgebraicAlgorithms
{
    internal class ExponentiationThroughBinaryDecompositionExponent 
    {
        public static double BinaryВecompositionExp(double val, uint exp)
        {
            double res = 1.0;
            double current = val;

            while (exp > 0)
            {
                if ((exp & 1) == 1)
                {
                    res *= current;
                }

                current *= current;
                exp >>= 1;
            }

            return res;
        }
        
    }
}
