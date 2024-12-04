using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> teachers = new Dictionary<string, string>();
            bool running = true;


            while (running)
            {
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Show all");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option between 1 and 4: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the new subject: ");
                        string newSubject = Console.ReadLine();

                        Console.Write("Enter the teachers name: ");
                        string newTeacher = Console.ReadLine();

                        if (!teachers.ContainsKey(newSubject))
                        {

                            teachers[newSubject] = newTeacher;
                            Console.WriteLine("Subject and teacher added successfully!");

                        }
                        else
                        {
                            Console.WriteLine("Subject already exists!");
                        }
                        break;

                    case "2":

                        Console.Write("Enter the name of the subject to be removed: ");
                        string removeSubject = Console.ReadLine();

                        if (teachers.ContainsKey(removeSubject))
                        {
                            teachers.Remove(removeSubject);
                            Console.WriteLine("The subject is removed");
                        }
                        else
                        {
                            Console.WriteLine("Subject not found");
                        }
                        break;

                    case "3":

                        if (teachers.Count > 0)
                        {
                            Console.WriteLine("Subject and teachers: ");
                            foreach (var item in teachers)
                            {
                                Console.WriteLine($"Subject: {item.Key}, teacher {item.Value}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exit");
                        break;


                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }

            }

                Console.ReadLine();

        }
    }
}
