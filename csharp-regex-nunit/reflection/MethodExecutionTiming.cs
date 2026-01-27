using System;
using System.Diagnostics;
using System.Reflection;

class Worker
{
    public void DoWork()
    {
        System.Threading.Thread.Sleep(500);
    }
}

class MethodExecutionTiming
{
    static void Main()
    {
        Worker w = new Worker();
        MethodInfo method = typeof(Worker).GetMethod("DoWork");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(w, null);
        sw.Stop();

        Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}
