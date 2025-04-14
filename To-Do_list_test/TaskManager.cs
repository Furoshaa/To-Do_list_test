namespace To_Do_list_test
{
    public class TaskManager
    {
        public static ListViewItem CreateTaskItem(string taskText)
        {
            string newTask = taskText.Trim();
            DateTime currentTime = DateTime.Now;
            
            ListViewItem newTaskFormatted = new ListViewItem(newTask);
            newTaskFormatted.SubItems.Add(currentTime.ToString("dd/MM/yyy HH:mm:ss"));
            
            return newTaskFormatted;
        }
        
        public static void AddTaskToList(ListView listView, string taskText)
        {
            if (!string.IsNullOrWhiteSpace(taskText))
            {
                ListViewItem item = CreateTaskItem(taskText);
                listView.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Please enter a task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}