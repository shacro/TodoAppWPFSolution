using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppWPFApp
{
    /// <summary>
    /// Hanterar logiken för att lägga till, ta bort och visa todo-items.
    /// </summary>
    public class ToDoList
    {
        private List<string> tasks = new List<string>();
        public void AddToList(string task)
        {
            tasks.Add(task);
        }
        public void RemoveTasks(int[] indexes)
        {
            foreach (int index in indexes)
            {
                if (index >= 0 && index < tasks.Count)
                {
                    tasks.RemoveAt(index);
                }
            }
        }
        public List<string> GetAllTasks()
        {
            return tasks;
        }

    }
}
