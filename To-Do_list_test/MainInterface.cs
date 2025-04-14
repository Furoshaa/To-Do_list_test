namespace To_Do_list_test
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNewTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string newTask = textBoxNewTask.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                listBox1.Items.Add(newTask);
                textBoxNewTask.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
