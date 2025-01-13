using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoAppWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToDoList _todoList;
        public MainWindow()
        {
            InitializeComponent();

            _todoList = new ToDoList();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ShutDownButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tasksTextBox.Text) == false)
            {
                _todoList.AddToList(tasksTextBox.Text);
                tasksTextBox.Clear();
                UpdateTaskList();
            }
            
        }
        /// <summary>
        /// Uppdaterar listan med todo-items.
        /// </summary>
        private void UpdateTaskList()
        {
            tasksList.Items.Clear();

            foreach (string task in _todoList.GetAllTasks())
            {
                tasksList.Items.Add(task);
            }
        }
        private void removeTasksButton_Click(object sender, RoutedEventArgs e)
        {
            if (tasksList.SelectedItems != null)
            {
                _todoList.RemoveTasks(GetSelectedItems());
                UpdateTaskList();
            }
        }

        private List<string> GetSelectedItems()
        {
            List<string> selectedValues = new List<string>();

            var selectedItems = tasksList.SelectedItems;

            foreach (var selectedItem in selectedItems)
            {
                selectedValues.Add(selectedItem.ToString());
            }

            return selectedValues;
        }
    }
}