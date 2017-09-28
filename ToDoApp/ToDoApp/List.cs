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
                TaskList = new List<string> (File.ReadAllLines(path));

                // Prints the lines of the file
                TaskList.ForEach(i => Console.WriteLine("{0}\t", i));
            }
                catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }            

            return TaskList;
        }

        public List<string> AddNumberToTaskList()
        {

            for (int i = 0; i < TaskList.Count; i++)
            {
                string SerialNumber = (i+1).ToString();
                TaskList[i]= SerialNumber + " - " + TaskList[i];
            }

            // Prints the lines of the file
            TaskList.ForEach(i => Console.WriteLine("{0}\t", i));

            return TaskList;
        }
    }
}
