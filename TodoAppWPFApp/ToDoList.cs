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
        private List<string> _tasks = new List<string>();
        public void AddToList(string task)
        {
            _tasks.Add(task);
        }
        public void RemoveTasks(List<string> tasks)
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                for (int j = 0; j < tasks.Count; j++)
                {
                    if (_tasks[i] == tasks[j])
                    {
                        _tasks.RemoveAt(i);
                        tasks.RemoveAt(j);
                        i--;
                        break;
                    }
                }
            }
        }
        public List<string> GetAllTasks()
        {
            return _tasks;
        }

    }
}
