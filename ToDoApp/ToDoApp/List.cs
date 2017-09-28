using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApp
{
    class List
    {        
        public static string path = "ListTasks.txt";
        public List<string> TaskList = new List<string>();

        public List<string> PrintTaskList()
        {
            try
            {
                // Reads the content from `ListTask.txt` in the `Debug` folder line by line to a string List
                List<string> TaskList = new List<string> (File.ReadAllLines(path));
                // Prints the first line of the file
                Console.WriteLine(TaskList);
            }
                catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }
            return TaskList;
        }
    }
}
