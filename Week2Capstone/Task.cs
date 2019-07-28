using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Capstone
{
    class Task
    {
        #region Fields
        private string teamMemberName;
        private string taskDescription;
        private string dueDate;
        private bool completed;
        #endregion
        public static List<Task> tasks = new List<Task>
            {
                new Task("Joe Leeper","Wash Dishes", "August 9, 2019", false),
                new Task("Bob Hope","Sweep floors","Sep 5, 2019", false),
                new Task("Marie Williams","Feed dog","July 27,2019", false)

            };

     


        #region Properties
        public string TeamMemberName
        {
            get
            {
                return teamMemberName;
            }
            set
            {
                teamMemberName = value;
            }
        }
        public string TaskDescription
        {
            get
            {
                return taskDescription;
            }
            set
            {
                taskDescription = value;
            }
        }

        public string DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        #endregion

        #region Constructors
        public Task()
        {
            teamMemberName = "";
            taskDescription = "";
            dueDate = "";
            completed = false;
        }
        public Task(string _teamMemberName, string _taskDescription, string _dueDate, bool _completed)
        {

            teamMemberName = _teamMemberName;
            taskDescription = _taskDescription;
            dueDate = _dueDate;
            completed = _completed;
        }
        #endregion
        #region Methods
        public static void DisplayMenu()
        {
            Console.WriteLine("\t1. List Tasks");
            Console.WriteLine("\t2. Add Tasks");
            Console.WriteLine("\t3. Delete Task");
            Console.WriteLine("\t4. Mark Task Complete");
            Console.WriteLine("\t5. Quit");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
        }

        public void PrintInfo(int count)
        {
                           
            Console.WriteLine($"\t{count}.Team Member Name: {TeamMemberName}");
            Console.WriteLine($"\tTask Description: {TaskDescription}");
            Console.WriteLine($"\tDue Date: {DueDate}");
            Console.WriteLine($"\tCompleted: {Completed}");
            Console.WriteLine();
        }

        #endregion

        public static void AddTask()
        {
            Task task = new Task();


            Console.WriteLine("Please add name");
            task.TeamMemberName = Console.ReadLine();

            Console.WriteLine("Enter task description");
            task.TaskDescription = Console.ReadLine();

            Console.WriteLine("Enter due date.");
            task.DueDate = Console.ReadLine();

            Console.WriteLine("Has this been completed?");
            string yesNo = Console.ReadLine().ToLower();
            
            
            
                if (yesNo == "y" || yesNo == "yes")
                {
                    task.Completed = true;
                }
                else if (yesNo == "n" || yesNo == "no")

                {
                    task.Completed = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid input, enter yes or no please.");
                    
                }
            
            tasks.Add(task);

        }
       
    }
}
    

