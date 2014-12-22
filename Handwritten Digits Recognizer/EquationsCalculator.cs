using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handwritten_Digits_Recognizer
{
    static class EquationsCalculator
    {
        public static double EculidianDistance(byte[] X, byte[] Y)
        {
            double res = 0;
            for (int i = 0; i < X.Count(); i++)
            {
                res += (X[i] - Y[i]) * (X[i] - Y[i]);
            }

            res = Math.Sqrt(res);
            return res;
        }

    }
}
