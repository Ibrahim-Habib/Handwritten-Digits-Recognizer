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
        //public static double EculidianDistancewithMax(byte[] X, byte[] Y, int maxDistance)
        //{
        //    double res = 0;
        //    for (int i = 0; i < X.Count(); i++)
        //    {
        //        res += (X[i] - Y[i]) * (X[i] - Y[i]);
        //        if (maxDistance < Math.Sqrt(res))
        //            break;
        //    }

        //    res = Math.Sqrt(res);
        //    return res;
        //}

        public static double EculidianDistance(double[] X, byte[] Y)
        {
            //double[] temp = new double[Y.Length];
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    temp[i] = (double)Y[i];
            //}

            //MWNumericArray arr1 = X;
            //MWNumericArray arr2 = temp;
            //MWArray res = mat.eculidean_distance(arr1, arr2);
            //return double.Parse(res.ToString());
            double res = 0;
            for (int i = 0; i < X.Count(); i++)
            {
                res += (X[i] - Y[i]) * (X[i] - Y[i]);
            }

            res = Math.Sqrt(res);
            return res;
        }

        public static double calculateMean(byte[] population)
        {
            double ret = 0;
            for (int i = 0; i < population.Length; i++)
                ret += population[i];
            ret /= population.Length;

            return ret;
        }

        public static double calculateVariance(byte[] population, double Mu)
        {
            double ret = 0;
            for (int i = 0; i < population.Length; i++)
            {
                ret += (population[i] - Mu) * (population[i] - Mu);
            }

            ret /= population.Length;
            return ret;
        }

        public static double normalProbability(double x, double Mu, double Sigma)
        {
            double ret;
            if (Sigma == 0)
            {
                ret = 10;
            }
            else
            {
                ret = (1.0 / (Math.Sqrt(2 * Math.PI) * Sigma)) * Math.Exp(-((x - Mu) * (x - Mu)) / (2 * Sigma * Sigma));
            }
             return ret;
        }



    }
}
