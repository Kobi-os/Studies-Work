namespace ConvertAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TO DO LIST");
            List<string> myTasks = new List<string>();
            string option = " ";

            while (option != "e")
            {
                Console.WriteLine("Pick your choice");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter 'e' to quit the app");

                option = Console.ReadLine();

                if (option == "1") {
                    Console.WriteLine("Enter a name of the Task"); 
                    string taskName = Console.ReadLine();
                    myTasks.Add(taskName);
                }
                else if (option == "2")
                {
                    for (int i = 0; i < myTasks.Count; i++)
                    {
                        Console.WriteLine(i + " : " + myTasks[i]) ;
                    }
                    Console.WriteLine("Enter a number of task you want to remove");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    myTasks.RemoveAt(taskNumber);
                }
                else if (option == "3") 
                {   
                    Console.WriteLine("Your Tasks");
                    for (int i = 0; i < myTasks.Count; i++)
                    {
                        Console.WriteLine(myTasks[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Exiting program");
                }
            }



        }
    }
} 