using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vectors
{

    static int n = 3;
    public double vectorx, vectory;
    Vectors calc;

    public Vectors(double vectorx, double vectory)
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



    static double Magnitudey(double[] vectory, double[] vectorx)
    {
        double product = 0;

        for (int i = 0; i < n; i++)
            product = Math.Sqrt(Math.Pow((vectorx[i] * vectorx[i] + vectory[i] * vectory[i]), 2));
        return product;
    }

    static double GetAngle(double[] vectorx, double[] vectory)
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


    public static void Main()
    {

        double a, b, c, x, y, z;

        Console.WriteLine("Add 3 values of vector x:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        Console.WriteLine(" Add 3 values of vector y:");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        z = double.Parse(Console.ReadLine());

        double[] vectorx = { a, b, c };
        double[] vectory = { x, y, z };

        Console.Write("Dot product:");

        Console.WriteLine(
            DotProduct(vectorx, vectory));

        Console.Write("Magnitude:");

        Console.WriteLine(Magnitudey(vectorx, vectory));

        Console.Write("Angle:");

        Console.WriteLine(GetAngle(vectorx, vectory));



    }
}
}
