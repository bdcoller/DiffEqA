//============================================================================
// Program to integrate differential equations.
//============================================================================
using System;

class Program
{
    static void Main()
    {
        double t = 0.0;    // time
        double tEnd = 5.0; // ending time
        double dt = 0.005;  // time step

        int n = 1;   // number of ODEs to be integrated
        double[] x = new double[n];
        double[] f = new double[n];

        int i;
        string s = t.ToString();
        for(i=0;i<n;++i)
        {
            x[i] = 0.0;    // set initial condition to zero
            s += "," + x[i].ToString();
        }
        s+= "," + x[0].ToString();

        //time loop
        Console.WriteLine(s);
        while(t < tEnd - dt*0.5)
        {
            s = (t+dt).ToString();
            RhsFunc(x,t,f);
            for(i=0;i<n;++i)
            {
                x[i] += f[i] * dt;
                s+= "," + x[i].ToString();
            }
            t = t + dt;
            double sol = 20.0*(1.0-Math.Exp(-0.9*t));
            s+= "," + sol.ToString();
            Console.WriteLine(s);
        }
    }

    //------------------------------------------------------------------------
    // RhsFunc: Calculates the right side of the differential equation
    //------------------------------------------------------------------------
    static void RhsFunc(double[] st,double t,double[] f)
    {
        double k = 0.9;
        double Teq = 20.0;

        f[0] = k*(Teq - st[0]);
    }
}