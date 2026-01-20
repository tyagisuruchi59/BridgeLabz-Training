using System;
using System.Collections.Generic;

namespace Sets
{
    public class SetProblems
    {
        public static void Run()
        {
            CheckEquality();
            UnionIntersection();
            SymmetricDifference();
            SortedSetConversion();
            SubsetCheck();
        }

        static void CheckEquality()
        {
            HashSet<int> a = new() { 1, 2, 3 };
            HashSet<int> b = new() { 3, 2, 1 };
            Console.WriteLine("Sets Equal: " + a.SetEquals(b));
        }

        static void UnionIntersection()
        {
            HashSet<int> a = new() { 1, 2, 3 };
            HashSet<int> b = new() { 3, 4, 5 };

            HashSet<int> union = new(a);
            union.UnionWith(b);

            HashSet<int> intersect = new(a);
            intersect.IntersectWith(b);

            Console.WriteLine("Union: " + string.Join(",", union));
            Console.WriteLine("Intersection: " + string.Join(",", intersect));
        }

        static void SymmetricDifference()
        {
            HashSet<int> a = new() { 1, 2, 3 };
            HashSet<int> b = new() { 3, 4, 5 };
            a.SymmetricExceptWith(b);

            Console.WriteLine("Symmetric Difference: " + string.Join(",", a));
        }

        static void SortedSetConversion()
        {
            HashSet<int> set = new() { 5, 3, 9, 1 };
            List<int> list = new(set);
            list.Sort();

            Console.WriteLine("Sorted List: " + string.Join(",", list));
        }

        static void SubsetCheck()
        {
            HashSet<int> a = new() { 2, 3 };
            HashSet<int> b = new() { 1, 2, 3, 4 };

            Console.WriteLine("Is Subset: " + a.IsSubsetOf(b));
        }
    }
}
