using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectorAnglesCalculator
{
    public class Vectors
    {
        static int n = 3;
        Vectors calc;
        public double[] vectorx, vectory;

        public Vectors (double[] vectorx, double[] vectory)
        {
            this.vectorx = vectorx;
            this.vectory = vectory;
        }
      
        double DotProduct(double[] vectorx, double[] vectory)
        {

            double product = 0;

            for (int i = 0; i < n; i++)
                product = product + vectorx[i] * vectory[i];
            return product;
        }

        double Magnitude(double[] vectorx, double[] vectory)
        {
            double product = 0;

            for (int i = 0; i < n; i++)
                product = Math.Sqrt(Math.Pow((vectorx[i] * vectorx[i] + vectory[i] * vectory[i]), 2));
            return product;
        }

        double GetAngle(double[] vectorx, double[] vectory)
        {
        
            double t = 0;
           

            for (int i = 0; i < 3; i++) t += vectorx[i] * vectory[i];

            double x2 = 0;
            double y2 = 0;

            for (int i = 0; i < 3; i++)
            {
                x2 += vectorx[i] * vectory[i];
                y2 += vectorx[i] * vectory[i];
            }

            double bot = 0;
            bot = Math.Sqrt(x2 * y2);

            double rtnval = Math.Acos(t / bot);
            double re = rtnval *= 360.0 / (2 * Math.PI);
            return re;

        }





    }
}
