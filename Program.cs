//============================================================================
// Program to integrate differential equations.
//============================================================================
using System;

class Program
{
    static void Main()
    {
        float t = 0.0f;    // time
        float tEnd = 3.0f; // ending time
        float dt = 0.02f;  // time step

        // time loop
        while(t < tEnd)
        {
            Console.WriteLine(t.ToString());
            t = t + dt;
        }
    }
}