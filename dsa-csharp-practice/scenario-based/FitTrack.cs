using System;

namespace FitTrack
{
    // Interface
    interface ITrackable
    {
        void StartWorkout();
        void EndWorkout();
    }

    // Base Class
    abstract class Workout : ITrackable
    {
        public string WorkoutName { get; set; }
        public int DurationMinutes { get; set; }

        public Workout(string workoutName, int duration)
        {
            WorkoutName = workoutName;
            DurationMinutes = duration;
        }

        public abstract void StartWorkout();
        public abstract void EndWorkout();
    }

    // Cardio Workout
    class CardioWorkout : Workout
    {
        public int DistanceKm { get; set; }

        public CardioWorkout(string name, int duration, int distance)
            : base(name, duration)
        {
            DistanceKm = distance;
        }

        public override void StartWorkout()
        {
            Console.WriteLine($"Started Cardio: {WorkoutName} for {DurationMinutes} mins, Distance: {DistanceKm} km.");
        }

        public override void EndWorkout()
        {
            Console.WriteLine($"Ended Cardio Workout: Burned calories and improved stamina.");
        }
    }

    // Strength Workout
    class StrengthWorkout : Workout
    {
        public int Sets { get; set; }

        public StrengthWorkout(string name, int duration, int sets)
            : base(name, duration)
        {
            Sets = sets;
        }

        public override void StartWorkout()
        {
            Console.WriteLine($"Started Strength Training: {WorkoutName} for {DurationMinutes} mins, Sets: {Sets}.");
        }

        public override void EndWorkout()
        {
            Console.WriteLine($"Ended Strength Workout: Muscles strengthened.");
        }
    }

    // User Profile Class
    class UserProfile
    {
        public string UserName { get; set; }
        public int Age { get; set; }

        public UserProfile(string name, int age)
        {
            UserName = name;
            Age = age;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"User: {UserName}, Age: {Age}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            UserProfile user = new UserProfile("Suru", 22);
            user.ShowProfile();

            Workout[] workouts =
            {
                new CardioWorkout("Morning Run", 30, 5),
                new StrengthWorkout("Gym Session", 45, 4)
            };

            Console.WriteLine("\n---- Workout Tracking ----");
            foreach (Workout workout in workouts)
            {
                workout.StartWorkout();
                workout.EndWorkout();
                Console.WriteLine();
            }
        }
    }
}
