using System;
using System.Collections.Generic;

namespace Systems
{
    public class InsuranceSystem
    {
        public static void Run()
        {
            HashSet<string> policies = new() { "P101", "P102", "P103" };
            Console.WriteLine("Policies: " + string.Join(",", policies));
        }
    }
}
