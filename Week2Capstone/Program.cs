using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Welcome to the Task Manager.");
            bool go = true;
            while (go)
            {
                Task.DisplayMenu();

                int menuChoice = int.Parse(Console.ReadLine());
                if (menuChoice == 1)
                {
                    int taskCount = 1;
                    foreach (Task taskInfo in Task.tasks)
                    {
                        taskInfo.PrintInfo(taskCount);
                        taskCount++;
                    }
                    Console.ReadLine();

                }
                else if (menuChoice == 2)
                {
                    Task.AddTask();

                }
                else if (menuChoice == 3)
                {
                    int taskCount2 = 1;
                    foreach (Task taskInfo in Task.tasks)
                    {
                        taskInfo.PrintInfo(taskCount2);
                        taskCount2++;
                    }
                    Console.WriteLine("Which task would you like to delete.");
                    int removeInput = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Are you sure you would like to delete? Y/N");
                    string yesNo = Console.ReadLine().ToLower();

                    if (yesNo == "y" || yesNo == "yes")
                    {
                        Task.tasks.RemoveAt(removeInput - 1);
                    }
                    else if (yesNo == "n" || yesNo == "no") { }
                    else
                    {
                        Console.WriteLine("Not a proper input.");
                    }
                }
                else if (menuChoice == 4)
                {
                    int taskCount3 = 1;
                    foreach (Task taskInfo in Task.tasks)
                    {
                        taskInfo.PrintInfo(taskCount3);
                        taskCount3++;
                    }
                    Console.WriteLine("Whose task would you like to mark completed? Enter number.");
                    int completeInput = int.Parse(Console.ReadLine());
                    completeInput--;
                    bool valid = true;
                        while (valid)
                    {
                        if(completeInput > 0 && completeInput <= Task.tasks.Count)
                        {
                            Task.tasks[completeInput].Completed = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number in range.");
                            valid = false;
                        }
                    
                    }
                   
                }
                else if (menuChoice == 5)
                {
                    Console.WriteLine("Have a great day!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid input, please enter 1-5");
                }
            }
           

        }
    }
}
