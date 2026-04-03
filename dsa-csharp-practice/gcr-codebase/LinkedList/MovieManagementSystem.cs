using System;

namespace MovieManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDoublyLinkedList list = new MovieDoublyLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n===== Movie Management System =====");
                Console.WriteLine("1. Add Movie at Beginning");
                Console.WriteLine("2. Add Movie at End");
                Console.WriteLine("3. Add Movie at Specific Position");
                Console.WriteLine("4. Remove Movie by Title");
                Console.WriteLine("5. Search Movie by Director");
                Console.WriteLine("6. Search Movie by Rating");
                Console.WriteLine("7. Update Movie Rating");
                Console.WriteLine("8. Display Movies (Forward)");
                Console.WriteLine("9. Display Movies (Reverse)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(CreateMovie());
                        break;

                    case 2:
                        list.AddAtEnd(CreateMovie());
                        break;

                    case 3:
                        Console.Write("Enter position: ");
                        int pos = int.Parse(Console.ReadLine());
                        list.AddAtPosition(CreateMovie(), pos);
                        break;

                    case 4:
                        Console.Write("Enter Movie Title to Remove: ");
                        list.RemoveByTitle(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Enter Director Name: ");
                        list.SearchByDirector(Console.ReadLine());
                        break;

                    case 6:
                        Console.Write("Enter Rating: ");
                        list.SearchByRating(double.Parse(Console.ReadLine()));
                        break;

                    case 7:
                        Console.Write("Enter Movie Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter New Rating: ");
                        double rating = double.Parse(Console.ReadLine());
                        list.UpdateRating(title, rating);
                        break;

                    case 8:
                        list.DisplayForward();
                        break;

                    case 9:
                        list.DisplayReverse();
                        break;
                }

            } while (choice != 0);
        }

        static MovieNode CreateMovie()
        {
            Console.Write("Movie Title: ");
            string title = Console.ReadLine();
            Console.Write("Director: ");
            string director = Console.ReadLine();
            Console.Write("Year of Release: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Rating: ");
            double rating = double.Parse(Console.ReadLine());

            return new MovieNode(title, director, year, rating);
        }
    }

    // ===================== NODE =====================
    class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public MovieNode Prev;
        public MovieNode Next;

        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Prev = null;
            Next = null;
        }
    }

    // ===================== DOUBLY LINKED LIST =====================
    class MovieDoublyLinkedList
    {
        private MovieNode head;
        private MovieNode tail;

        // Add at beginning
        public void AddAtBeginning(MovieNode node)
        {
            if (head == null)
            {
                head = tail = node;
                return;
            }

            node.Next = head;
            head.Prev = node;
            head = node;
        }

        // Add at end
        public void AddAtEnd(MovieNode node)
        {
            if (tail == null)
            {
                head = tail = node;
                return;
            }

            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }

        // Add at specific position
        public void AddAtPosition(MovieNode node, int position)
        {
            if (position <= 1 || head == null)
            {
                AddAtBeginning(node);
                return;
            }

            MovieNode temp = head;
            for (int i = 1; i < position - 1 && temp.Next != null; i++)
                temp = temp.Next;

            node.Next = temp.Next;
            node.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = node;
            else
                tail = node;

            temp.Next = node;
        }

        // Remove by title
        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            MovieNode temp = head;
            while (temp != null && temp.Title != title)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            if (temp == head)
                head = temp.Next;

            if (temp == tail)
                tail = temp.Prev;

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            temp.Next = temp.Prev = null;
            Console.WriteLine("Movie removed successfully");
        }

        // Search by Director
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    PrintMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director");
        }

        // Search by Rating
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    PrintMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating");
        }

        // Update rating
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Movie not found");
        }

        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movie records");
                return;
            }

            MovieNode temp = head;
            while (temp != null)
            {
                PrintMovie(temp);
                temp = temp.Next;
            }
        }

        // Display reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movie records");
                return;
            }

            MovieNode temp = tail;
            while (temp != null)
            {
                PrintMovie(temp);
                temp = temp.Prev;
            }
        }

        private void PrintMovie(MovieNode m)
        {
            Console.WriteLine($"{m.Title} | {m.Director} | {m.Year} | Rating: {m.Rating}");
        }
    }
}
