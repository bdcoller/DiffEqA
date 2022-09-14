//============================================================================
// Program to integrate differential equations.
//============================================================================
using System;

class Program
{
    static void Main()
    {
        double t = 0.0;    // time
        double tEnd = 3.0; // ending time
        double dt = 0.02;  // time step

        //time loop
        Console.WriteLine(t.ToString());
        while(t < tEnd - dt*0.5)
        {
            t = t + dt;
            Console.WriteLine(t.ToString());
        }

        
    }

    
}