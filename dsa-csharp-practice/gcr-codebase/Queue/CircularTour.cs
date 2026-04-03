using System;

namespace DSA_CircularTour
{
    class PetrolPump
    {
        public int Petrol;
        public int Distance;

        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
    }

    class CircularTour
    {
        public static int FindStartingPoint(PetrolPump[] pumps)
        {
            int balance = 0;
            int deficit = 0;
            int start = 0;

            for (int i = 0; i < pumps.Length; i++)
            {
                balance += pumps[i].Petrol - pumps[i].Distance;

                if (balance < 0)
                {
                    deficit += balance;
                    start = i + 1;
                    balance = 0;
                }
            }

            return (balance + deficit >= 0) ? start : -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PetrolPump[] pumps = new PetrolPump[]
            {
                new PetrolPump(6, 4),
                new PetrolPump(3, 6),
                new PetrolPump(7, 3)
            };

            int startIndex = CircularTour.FindStartingPoint(pumps);

            if (startIndex != -1)
                Console.WriteLine("Start at petrol pump index: " + startIndex);
            else
                Console.WriteLine("No possible circular tour.");

            Console.ReadLine();
        }
    }
}
