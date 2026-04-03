using System;
using System.Collections.Generic;

// Custom Exception
class InvalidTimeFormatException : Exception
{
    public InvalidTimeFormatException(string message) : base(message)
    {
    }
}

class CinemaTime
{
    private List<string> movieTitles = new List<string>();
    private List<string> movieTimes = new List<string>();

    // Add movie
    public void AddMovie(string title, string time)
    {
        if (!IsValidTime(time))
        {
            throw new InvalidTimeFormatException("Invalid time format: " + time);
        }

        movieTitles.Add(title);
        movieTimes.Add(time);
        Console.WriteLine("Movie added successfully");
    }

    // Search movie using keyword
    public void SearchMovie(string keyword)
    {
        bool found = false;

        try
        {
            for (int i = 0; i < movieTitles.Count; i++)
            {
                if (movieTitles[i].Contains(keyword))
                {
                    Console.WriteLine(
                        string.Format("Found: {0} at {1}",
                        movieTitles[i], movieTimes[i])
                    );
                    found = true;
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid search index");
        }

        if (!found)
        {
            Console.WriteLine("No movie found with keyword: " + keyword);
        }
    }

    // Display all movies
    public void DisplayAllMovies()
    {
        if (movieTitles.Count == 0)
        {
            Console.WriteLine("No movies available");
            return;
        }

        for (int i = 0; i < movieTitles.Count; i++)
        {
            Console.WriteLine(
                string.Format("{0}. {1} - {2}",
                i + 1, movieTitles[i], movieTimes[i])
            );
        }
    }

    // Convert List to Array for report
    public void PrintMovieReport()
    {
        string[] titleArray = movieTitles.ToArray();
        string[] timeArray = movieTimes.ToArray();

        Console.WriteLine("\n--- Movie Report ---");
        for (int i = 0; i < titleArray.Length; i++)
        {
            Console.WriteLine(titleArray[i] + " @ " + timeArray[i]);
        }
    }

    // Time validation (HH:MM)
    private bool IsValidTime(string time)
    {
        if (!time.Contains(":"))
            return false;

        string[] parts = time.Split(':');
        if (parts.Length != 2)
            return false;

        int hour, minute;

        if (!int.TryParse(parts[0], out hour) ||
            !int.TryParse(parts[1], out minute))
            return false;

        if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
            return false;

        return true;
    }
}

class Program
{
    static void Main()
    {
        CinemaTime cinema = new CinemaTime();

        try
        {
            cinema.AddMovie("Inception", "18:30");
            cinema.AddMovie("Interstellar", "21:00");
            cinema.AddMovie("Avatar", "25:99"); // Invalid time
        }
        catch (InvalidTimeFormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nAll Movies:");
        cinema.DisplayAllMovies();

        Console.WriteLine("\nSearch Result:");
        cinema.SearchMovie("Inter");

        cinema.PrintMovieReport();
    }
}
