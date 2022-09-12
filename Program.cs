//============================================================================
// Program to integrate differential equations.
//============================================================================
using System;

class Program
{
    static void Main()
    {
        // double t = 0.0;    // time
        // double tEnd = 3.0; // ending time
        // double dt = 0.02;  // time step

        // time loop
        // Console.WriteLine(t.ToString());
        // while(t < tEnd - dt*0.5)
        // {
        //     t = t + dt;
        //     Console.WriteLine(t.ToString());
        // }

        //double x = 7.1;
        double[] x = new double[2];
        x[0] = 7.1;   x[1] = 5.5;
        Console.WriteLine("Before Func, x[0] = " + x[0].ToString());
        Func(x);
        Console.WriteLine("After Func, x[0] = " + x[0].ToString());
    }

    static void Func(double[] xx)
    {
        Console.WriteLine("Beginning of Func, xx[0] = " + xx[0].ToString());
        xx[0] = xx[0] + 2.0;
        Console.WriteLine("End of Func, xx[0] = " + xx[0].ToString());
    }
}