using System;

class TypeCasting
{
    static void Main()
    {
        // -------------------------------
        // DATA TYPES
        // -------------------------------
        int i = 10;
        double d = 20.5;
        float f = 15.5f;
        long l = 100000;
        decimal dec = 50.75m;
        char ch = 'A';
        bool flag = true;
        string name = "Suru";

        Console.WriteLine("Original Values:");
        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(f);
        Console.WriteLine(l);
        Console.WriteLine(dec);
        Console.WriteLine(ch);
        Console.WriteLine(flag);
        Console.WriteLine(name);

        // -------------------------------
        // 1️⃣ IMPLICIT TYPE CASTING
        // (Small → Big, automatic)
        // -------------------------------
        int a = 100;
        double b = a;   // int → double

        Console.WriteLine("\nImplicit Casting:");
        Console.WriteLine(b);

        // -------------------------------
        // 2️⃣ EXPLICIT TYPE CASTING
        // (Big → Small, manual)
        // -------------------------------
        double x = 99.99;
        int y = (int)x;   // double → int

        Console.WriteLine("\nExplicit Casting:");
        Console.WriteLine(y);

        // -------------------------------
        // 3️⃣ TYPE CASTING USING CONVERT CLASS
        // -------------------------------
        string num = "50";

        int numInt = Convert.ToInt32(num);   // string → int
        double numDouble = Convert.ToDouble(num); // string → double

        Console.WriteLine("\nConvert Class Casting:");
        Console.WriteLine(numInt);
        Console.WriteLine(numDouble);

        // -------------------------------
        // 4️⃣ TYPE CASTING USING Parse
        // -------------------------------
        string value = "25";

        int parsedInt = int.Parse(value);

        Console.WriteLine("\nParse Casting:");
        Console.WriteLine(parsedInt);
    }
}
