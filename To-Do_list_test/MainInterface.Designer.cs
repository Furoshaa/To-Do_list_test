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
            textBoxNewTask = new System.Windows.Forms.TextBox();
            buttonAdd = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            taskName = new System.Windows.Forms.ColumnHeader();
            taskTimeAdded = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // textBoxNewTask
            // 
            textBoxNewTask.Location = new System.Drawing.Point(12, 336);
            textBoxNewTask.Name = "textBoxNewTask";
            textBoxNewTask.Size = new System.Drawing.Size(311, 23);
            textBoxNewTask.TabIndex = 4;
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
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { taskName, taskTimeAdded });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(631, 318);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // taskName
            // 
            taskName.Name = "taskName";
            taskName.Text = "Nom de la tache";
            taskName.Width = 315;
            // 
            // taskTimeAdded
            // 
            taskTimeAdded.Name = "taskTimeAdded";
            taskTimeAdded.Text = "Date d\'ajout";
            taskTimeAdded.Width = 310;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(655, 450);
            Controls.Add(listView1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxNewTask);
            Text = "To-do List";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ColumnHeader taskTimeAdded;

        private System.Windows.Forms.ColumnHeader taskName;

        #endregion

        private System.Windows.Forms.TextBox textBoxNewTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listView1;
    }
}