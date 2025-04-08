using NeuroBuddy.Model;
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
        TaskManager taskManager;
        NeuroTask newTask;
        public TaskManagerView()
        {
            InitializeComponent();
           
        }

        private void TaskMangerView_Load(object sender, EventArgs e)
        {
            newTask = new NeuroTask();
            taskManager = new TaskManager();
        }



        private void ScheduleTaskBtn_Click(object sender, EventArgs e)
        {
            scheduleForm view = new scheduleForm();
            view.Show();
        }

        private void Task_Box_TextChanged(object sender, EventArgs e)
        {
            newTask.Name = Task_Box.Text;
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            newTask.Category = CategoryList.SelectedIndex.ToString();
        }

        private void StateCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StateCheckBox.SelectedIndex)
            {
                case 0:
                    newTask.States = States.NotStarted;
                    break;
                case 1:
                    newTask.States = States.InProgress;
                    break;
                case 2:
                    newTask.States = States.Incomplete;
                    break;
                case 3:
                    newTask.States = States.Complete;
                    break;
            }
        }

        private void SetReminder_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            taskManager.AddTask(newTask);
        }
    }
}
