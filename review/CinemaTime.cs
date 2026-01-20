using System;

class Movie
{
    public string Title;
    public string Time;
}

class CinemaTime
{
    static Movie[] movies = new Movie[50];
    static int count = 0;

    static void AddMovie(string title, string time)
    {
        if (count >= movies.Length)
        {
            Console.WriteLine("Movie list full");
            return;
        }

        if (!IsValidTime(time))
        {
            Console.WriteLine("Invalid time (HH:MM)");
            return;
        }

        movies[count] = new Movie { Title = title, Time = time };
        count++;

        Console.WriteLine("Movie added");
    }

    static void ViewMovies()
    {
        if (count == 0)
        {
            Console.WriteLine("No movies available");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine((i + 1) + ". " +
                movies[i].Title + " @ " + movies[i].Time);
        }
    }

    static void SearchMovie(string key)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (movies[i].Title.ToLower().Contains(key.ToLower()))
            {
                Console.WriteLine(
                    movies[i].Title + " @ " + movies[i].Time);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("Movie not found");
    }

    static bool IsValidTime(string time)
    {
        if (time.Length != 5 || time[2] != ':')
            return false;

        int h = (time[0] - '0') * 10 + (time[1] - '0');
        int m = (time[3] - '0') * 10 + (time[4] - '0');

        return h >= 0 && h <= 23 && m >= 0 && m <= 59;
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1.Add  2.View  3.Search  0.Exit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Title: ");
                string t = Console.ReadLine();

                Console.Write("Time: ");
                string time = Console.ReadLine();

                AddMovie(t, time);
            }
            else if (choice == 2)
            {
                ViewMovies();
            }
            else if (choice == 3)
            {
                Console.Write("Keyword: ");
                SearchMovie(Console.ReadLine());
            }

        } while (choice != 0);

        Console.WriteLine("Program Ended");
    }
}
