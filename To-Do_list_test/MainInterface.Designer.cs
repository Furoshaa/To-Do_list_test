namespace To_Do_list_test
{
    partial class MainInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            textBoxNewTask = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 304);
            listBox1.TabIndex = 0;
            // 
            // textBoxNewTask
            // 
            textBoxNewTask.Location = new Point(12, 336);
            textBoxNewTask.Name = "textBoxNewTask";
            textBoxNewTask.Size = new Size(311, 23);
            textBoxNewTask.TabIndex = 1;
            textBoxNewTask.TextChanged += textBoxNewTask_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(329, 336);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "Add new task";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxNewTask);
            Controls.Add(listBox1);
            Name = "MainInterface";
            Text = "To-do List";
            Load += MainInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBoxNewTask;
        private Button button1;
    }
}
