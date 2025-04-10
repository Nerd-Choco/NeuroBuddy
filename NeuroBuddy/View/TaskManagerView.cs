﻿using NeuroBuddy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroBuddy.View
{
    public partial class TaskManagerView : Form
    {
        // your naming of UI elements is soooo misleading
        // I should see: TaskNameTextBox, CategoryListComboBox, CategoryLabel, etc
        // it should be fairly easy to use these controls inside the code here
        // but now I have to go to the GUI window to actually see what is that thing called Category (which is probably CategoryLabel?)

        TaskManager taskManager;
        NeuroTask newTask;
        public TaskManagerView(IEnumerable<Category> CategoriesList)
        {
            InitializeComponent();

            taskManager = new TaskManager(); // what is this?!

            CategoryListComboBox.DataSource = CategoriesList.ToList(); // makes a local copy
        }

        // remove this event
        private void TaskMangerView_Load(object sender, EventArgs e)
        {

        }

        private void ScheduleTaskBtn_Click(object sender, EventArgs e)
        {
            scheduleForm view = new scheduleForm();
            view.Show();
        }

        // remove this event
        private void Task_Box_TextChanged(object sender, EventArgs e)
        {

        }

        // remove this event
        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // remove this event
        private void StateCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // remove this event
        private void SetReminder_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CategoryListComboBox.SelectedItem != null)
                newTask.Category = (Category)CategoryListComboBox.SelectedItem;

            newTask = new NeuroTask();

            newTask.Name = Task_Box.Text; // TaskNameTextBox !!!
            newTask.Note = textBox2.Text;

            // continue initializing the newTask

            // well, you just created the manager in the constructor, so why bother?
            // you probably wanted this form to receive the already existing main app's taskmanager
            // so that it can insert the task into it itself
            // but there is a better way
            // create a property called NewTask {get; set;}
            // init it in your constructor
            // add two buttons: Ok, Cancel
            // in their events type DialogResult = blablabla.OK or cancel whatever
            // this will close your dialog, so you should actually do the lines in this event right before dialogresult
            // when this dialog closes, the one who opened it shall read the NewTask property

            // so in summary, this form is a dialog, it just returns a NewTask, doesn't know how to add it, uses a public property NewTask and DialogResult to close itself
            // ofcourse the one opening this dialog should go like:
            // if (TaskManagerView.ShowDialog() == DialogResult.OK)
            //     taskManager.Add(TaskManagerView.NewTask);
            taskManager.AddTask(newTask);
        }
    }
}
