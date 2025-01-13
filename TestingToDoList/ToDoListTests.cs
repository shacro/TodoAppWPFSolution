using TodoAppWPFApp;

namespace TestingToDoList
{
    public class ToDoListTests
    {
        private ToDoList _todoList;
        public ToDoListTests()
        {
            _todoList = new ToDoList();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddToList(task);
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);

        }

        [Fact]

        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            var task = "Task to remove";
            List<string> Test = new List<string>();
            Test.Add(task);

            _todoList.AddToList(task);
            _todoList.RemoveTasks(Test);

            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]

        public void RemoveTask_TaskThatDoesNotExist_ShouldNotThrowExeption()
        {
            var task = "Should not throw Exeption"; // Ska inte finnas i toDo instansens List<string> property
            List<string> Test = new List<string>();
            Test.Add(task);

            string taskInTodo = "Test Hello"; // Ska finnas kvar i Listan
            _todoList.AddToList(taskInTodo);
            _todoList.RemoveTasks(Test);

            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks);
        }
    }
}