using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter task description: ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.WriteLine("Task added successfully!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Tasks:");
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks found.");
                }
                else
                {
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                }
            }
            else if (choice == "3")
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks found.");
                }
                else
                {
                    Console.Write("Enter the task number to delete: ");
                    int taskNumber;
                    if (int.TryParse(Console.ReadLine(), out taskNumber))
                    {
                        if (taskNumber >= 1 && taskNumber <= tasks.Count)
                        {
                            tasks.RemoveAt(taskNumber - 1);
                            Console.WriteLine("Task deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }

            Console.WriteLine();
        }
    }
}
