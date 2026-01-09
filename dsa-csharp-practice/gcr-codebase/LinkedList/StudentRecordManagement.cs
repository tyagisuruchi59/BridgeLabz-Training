using System;

namespace StudentRecordManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLinkedList list = new StudentLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n===== Student Record Management =====");
                Console.WriteLine("1. Add Student at Beginning");
                Console.WriteLine("2. Add Student at End");
                Console.WriteLine("3. Add Student at Specific Position");
                Console.WriteLine("4. Delete Student by Roll Number");
                Console.WriteLine("5. Search Student by Roll Number");
                Console.WriteLine("6. Update Student Grade");
                Console.WriteLine("7. Display All Students");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(CreateStudent());
                        break;

                    case 2:
                        list.AddAtEnd(CreateStudent());
                        break;

                    case 3:
                        Console.Write("Enter position: ");
                        int pos = int.Parse(Console.ReadLine());
                        list.AddAtPosition(CreateStudent(), pos);
                        break;

                    case 4:
                        Console.Write("Enter Roll Number to delete: ");
                        list.DeleteByRollNo(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Enter Roll Number to search: ");
                        StudentNode s = list.Search(int.Parse(Console.ReadLine()));
                        if (s != null)
                            Console.WriteLine($"{s.RollNo} {s.Name} {s.Age} {s.Grade}");
                        else
                            Console.WriteLine("Student not found");
                        break;

                    case 6:
                        Console.Write("Enter Roll Number: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Grade: ");
                        char g = char.Parse(Console.ReadLine());
                        list.UpdateGrade(r, g);
                        break;

                    case 7:
                        list.Display();
                        break;
                }

            } while (choice != 0);
        }

        static StudentNode CreateStudent()
        {
            Console.Write("Roll Number: ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            char grade = char.Parse(Console.ReadLine());

            return new StudentNode(roll, name, age, grade);
        }
    }

    // ===================== NODE =====================
    class StudentNode
    {
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;
        public StudentNode Next;

        public StudentNode(int rollNo, string name, int age, char grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }

    // ===================== LINKED LIST =====================
    class StudentLinkedList
    {
        private StudentNode head;

        // Add at beginning (O(1))
        public void AddAtBeginning(StudentNode node)
        {
            node.Next = head;
            head = node;
        }

        // Add at end (O(n))
        public void AddAtEnd(StudentNode node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = node;
        }

        // Add at specific position
        public void AddAtPosition(StudentNode node, int position)
        {
            if (position <= 1 || head == null)
            {
                AddAtBeginning(node);
                return;
            }

            StudentNode temp = head;
            for (int i = 1; i < position - 1 && temp.Next != null; i++)
                temp = temp.Next;

            node.Next = temp.Next;
            temp.Next = node;
        }

        // Delete by Roll Number
        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.RollNo == rollNo)
            {
                head = head.Next;
                return;
            }

            StudentNode curr = head;
            while (curr.Next != null && curr.Next.RollNo != rollNo)
                curr = curr.Next;

            if (curr.Next != null)
                curr.Next = curr.Next.Next;
            else
                Console.WriteLine("Student not found");
        }

        // Search by Roll Number
        public StudentNode Search(int rollNo)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Update Grade
        public void UpdateGrade(int rollNo, char newGrade)
        {
            StudentNode student = Search(rollNo);
            if (student != null)
                student.Grade = newGrade;
            else
                Console.WriteLine("Student not found");
        }

        // Display all students
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.RollNo} {temp.Name} {temp.Age} {temp.Grade}");
                temp = temp.Next;
            }
        }
    }
}
