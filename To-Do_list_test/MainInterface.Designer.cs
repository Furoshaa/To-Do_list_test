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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new System.Windows.Forms.ListBox();
            textBoxNewTask = new System.Windows.Forms.TextBox();
            buttonAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(631, 289);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBoxNewTask
            // 
            textBoxNewTask.Location = new System.Drawing.Point(12, 336);
            textBoxNewTask.Name = "textBoxNewTask";
            textBoxNewTask.Size = new System.Drawing.Size(311, 23);
            textBoxNewTask.TabIndex = 1;
            textBoxNewTask.TextChanged += textBoxNewTask_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(329, 336);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(87, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add new task";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(655, 450);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxNewTask);
            Controls.Add(listBox1);
            Text = "To-do List";
            Load += MainInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private TextBox textBoxNewTask;
        private Button buttonAdd;
    }
}
