using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class InvokePrivateMethod
{
    static void Main()
    {
        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator)
            .GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(calc, new object[] { 4, 5 });
        Console.WriteLine("Result = " + result);
    }
}
