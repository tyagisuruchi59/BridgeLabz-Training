using System;

class OperatorsDemo
{
    static void Main()
    {
        int a = 10;
        int b = 3;

        // -----------------------------
        // 1️⃣ Arithmetic Operators
        // -----------------------------
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // -----------------------------
        // 2️⃣ Assignment Operators
        // -----------------------------
        Console.WriteLine("\nAssignment Operators:");
        int x = 5;
        x += 2;   // x = x + 2
        Console.WriteLine("x += 2 : " + x);

        x -= 1;   // x = x - 1
        Console.WriteLine("x -= 1 : " + x);

        x *= 3;   // x = x * 3
        Console.WriteLine("x *= 3 : " + x);

        x /= 2;   // x = x / 2
        Console.WriteLine("x /= 2 : " + x);

        // -----------------------------
        // 3️⃣ Relational Operators
        // -----------------------------
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
        Console.WriteLine("a > b  : " + (a > b));
        Console.WriteLine("a < b  : " + (a < b));
        Console.WriteLine("a >= b : " + (a >= b));
        Console.WriteLine("a <= b : " + (a <= b));

        // -----------------------------
        // 4️⃣ Logical Operators
        // -----------------------------
        Console.WriteLine("\nLogical Operators:");
        bool p = true;
        bool q = false;

        Console.WriteLine("p && q : " + (p && q));
        Console.WriteLine("p || q : " + (p || q));
        Console.WriteLine("!p     : " + (!p));

        // -----------------------------
        // 5️⃣ Unary Operators
        // -----------------------------
        Console.WriteLine("\nUnary Operators:");
        int num = 5;

        Console.WriteLine("++num : " + (++num)); // pre-increment
        Console.WriteLine("num++ : " + (num++)); // post-increment
        Console.WriteLine("--num : " + (--num)); // pre-decrement

        // -----------------------------
        // 6️⃣ Ternary Operator
        // -----------------------------
        Console.WriteLine("\nTernary Operator:");
        int max = (a > b) ? a : b;
        Console.WriteLine("Maximum value: " + max);

        // -----------------------------
        // 7️⃣ Type Casting Operators
        // -----------------------------
        Console.WriteLine("\nType Casting:");
        double d = 10.5;
        int i = (int)d;   // explicit casting
        Console.WriteLine("Double to Int: " + i);

        // -----------------------------
        // 8️⃣ typeof Operator
        // -----------------------------
        Console.WriteLine("\ntypeof Operator:");
        Console.WriteLine(typeof(int));

        // -----------------------------
        // 9️⃣ is Operator
        // -----------------------------
        Console.WriteLine("\nis Operator:");
        object obj = "Hello";
        Console.WriteLine(obj is string);
    }
}
