namespace NeuroBuddy
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mainToolStripMenuItem = new ToolStripMenuItem();
            schudledToolStripMenuItem = new ToolStripMenuItem();
            createNewCategoryToolStripMenuItem = new ToolStripMenuItem();
            viewCategories4ToolStripMenuItem = new ToolStripMenuItem();
            scheduledActivitiesToolStripMenuItem = new ToolStripMenuItem();
            createANewActivityToolStripMenuItem = new ToolStripMenuItem();
            viewSheduledActivitiesToolStripMenuItem = new ToolStripMenuItem();
            loggedAToolStripMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            createANewTaskToolStripMenuItem = new ToolStripMenuItem();
            viewTasksToolStripMenuItem = new ToolStripMenuItem();
            calenderToolStripMenuItem = new ToolStripMenuItem();
            insightToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            editPToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            NewTask = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem, schudledToolStripMenuItem, scheduledActivitiesToolStripMenuItem, loggedAToolStripMenuItem, tasksToolStripMenuItem, calenderToolStripMenuItem, insightToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(671, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            mainToolStripMenuItem.ForeColor = Color.Chocolate;
            mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            mainToolStripMenuItem.Size = new Size(49, 20);
            mainToolStripMenuItem.Text = "Main ";
            // 
            // schudledToolStripMenuItem
            // 
            schudledToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewCategoryToolStripMenuItem, viewCategories4ToolStripMenuItem });
            schudledToolStripMenuItem.ForeColor = Color.Coral;
            schudledToolStripMenuItem.Name = "schudledToolStripMenuItem";
            schudledToolStripMenuItem.Size = new Size(74, 20);
            schudledToolStripMenuItem.Text = "Categories";
            // 
            // createNewCategoryToolStripMenuItem
            // 
            createNewCategoryToolStripMenuItem.ForeColor = Color.Coral;
            createNewCategoryToolStripMenuItem.Name = "createNewCategoryToolStripMenuItem";
            createNewCategoryToolStripMenuItem.Size = new Size(181, 22);
            createNewCategoryToolStripMenuItem.Text = "Create new category";
            // 
            // viewCategories4ToolStripMenuItem
            // 
            viewCategories4ToolStripMenuItem.ForeColor = Color.Coral;
            viewCategories4ToolStripMenuItem.Name = "viewCategories4ToolStripMenuItem";
            viewCategories4ToolStripMenuItem.Size = new Size(181, 22);
            viewCategories4ToolStripMenuItem.Text = "View Categories";
            // 
            // scheduledActivitiesToolStripMenuItem
            // 
            scheduledActivitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createANewActivityToolStripMenuItem, viewSheduledActivitiesToolStripMenuItem });
            scheduledActivitiesToolStripMenuItem.ForeColor = Color.Coral;
            scheduledActivitiesToolStripMenuItem.Name = "scheduledActivitiesToolStripMenuItem";
            scheduledActivitiesToolStripMenuItem.Size = new Size(125, 20);
            scheduledActivitiesToolStripMenuItem.Text = "Scheduled Activities";
            // 
            // createANewActivityToolStripMenuItem
            // 
            createANewActivityToolStripMenuItem.ForeColor = Color.Coral;
            createANewActivityToolStripMenuItem.Name = "createANewActivityToolStripMenuItem";
            createANewActivityToolStripMenuItem.Size = new Size(202, 22);
            createANewActivityToolStripMenuItem.Text = "Create a new activity";
            // 
            // viewSheduledActivitiesToolStripMenuItem
            // 
            viewSheduledActivitiesToolStripMenuItem.ForeColor = Color.Coral;
            viewSheduledActivitiesToolStripMenuItem.Name = "viewSheduledActivitiesToolStripMenuItem";
            viewSheduledActivitiesToolStripMenuItem.Size = new Size(202, 22);
            viewSheduledActivitiesToolStripMenuItem.Text = "View Sheduled Activities";
            // 
            // loggedAToolStripMenuItem
            // 
            loggedAToolStripMenuItem.ForeColor = Color.Coral;
            loggedAToolStripMenuItem.Name = "loggedAToolStripMenuItem";
            loggedAToolStripMenuItem.Size = new Size(103, 20);
            loggedAToolStripMenuItem.Text = "Logged Activies";
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createANewTaskToolStripMenuItem, viewTasksToolStripMenuItem });
            tasksToolStripMenuItem.ForeColor = Color.Coral;
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(46, 20);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // createANewTaskToolStripMenuItem
            // 
            createANewTaskToolStripMenuItem.ForeColor = Color.Coral;
            createANewTaskToolStripMenuItem.Name = "createANewTaskToolStripMenuItem";
            createANewTaskToolStripMenuItem.Size = new Size(180, 22);
            createANewTaskToolStripMenuItem.Text = "Create a new task ";
            createANewTaskToolStripMenuItem.Click += createANewTaskToolStripMenuItem_Click;
            // 
            // viewTasksToolStripMenuItem
            // 
            viewTasksToolStripMenuItem.ForeColor = Color.Coral;
            viewTasksToolStripMenuItem.Name = "viewTasksToolStripMenuItem";
            viewTasksToolStripMenuItem.Size = new Size(180, 22);
            viewTasksToolStripMenuItem.Text = "View tasks";
            // 
            // calenderToolStripMenuItem
            // 
            calenderToolStripMenuItem.BackColor = SystemColors.ControlDark;
            calenderToolStripMenuItem.ForeColor = Color.Coral;
            calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            calenderToolStripMenuItem.Size = new Size(65, 20);
            calenderToolStripMenuItem.Text = "Calender";
            // 
            // insightToolStripMenuItem
            // 
            insightToolStripMenuItem.ForeColor = Color.Coral;
            insightToolStripMenuItem.Name = "insightToolStripMenuItem";
            insightToolStripMenuItem.Size = new Size(55, 20);
            insightToolStripMenuItem.Text = "Insight";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.BackColor = SystemColors.ControlDark;
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editPToolStripMenuItem, logOutToolStripMenuItem });
            profileToolStripMenuItem.ForeColor = Color.Coral;
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 20);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // editPToolStripMenuItem
            // 
            editPToolStripMenuItem.ForeColor = Color.Coral;
            editPToolStripMenuItem.Name = "editPToolStripMenuItem";
            editPToolStripMenuItem.Size = new Size(131, 22);
            editPToolStripMenuItem.Text = "Edit Profile";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.ForeColor = Color.Coral;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(131, 22);
            logOutToolStripMenuItem.Text = "Log out";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(NewTask);
            panel1.Location = new Point(134, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 238);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(262, 3);
            button5.Name = "button5";
            button5.Size = new Size(148, 99);
            button5.TabIndex = 4;
            button5.Text = "New Category";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(259, 136);
            button4.Name = "button4";
            button4.Size = new Size(151, 99);
            button4.TabIndex = 3;
            button4.Text = "Schedule Activity";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 136);
            button2.Name = "button2";
            button2.Size = new Size(151, 99);
            button2.TabIndex = 1;
            button2.Text = "Log Activity";
            button2.UseVisualStyleBackColor = true;
            // 
            // NewTask
            // 
            NewTask.Location = new Point(3, 0);
            NewTask.Name = "NewTask";
            NewTask.Size = new Size(151, 99);
            NewTask.TabIndex = 0;
            NewTask.Text = "New Task";
            NewTask.UseVisualStyleBackColor = true;
            NewTask.Click += createANewTaskToolStripMenuItem_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(671, 391);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "MainView";
            Text = "Neuro Buddy";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem schudledToolStripMenuItem;
        private ToolStripMenuItem scheduledActivitiesToolStripMenuItem;
        private ToolStripMenuItem loggedAToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem calenderToolStripMenuItem;
        private ToolStripMenuItem insightToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem editPToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem createANewTaskToolStripMenuItem;
        private ToolStripMenuItem viewTasksToolStripMenuItem;
        private ToolStripMenuItem createNewCategoryToolStripMenuItem;
        private ToolStripMenuItem createANewActivityToolStripMenuItem;
        private ToolStripMenuItem viewSheduledActivitiesToolStripMenuItem;
        private ToolStripMenuItem viewCategories4ToolStripMenuItem;
        private Panel panel1;
        private Button button2;
        private Button NewTask;
        private Button button5;
        private Button button4;
    }
}