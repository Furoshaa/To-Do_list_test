namespace To_Do_list_test
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            TaskManager.AddTaskToList(listView1, textBoxNewTask.Text);
            textBoxNewTask.Clear();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
