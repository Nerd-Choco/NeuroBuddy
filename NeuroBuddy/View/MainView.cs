using NeuroBuddy.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroBuddy
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        public void TaskManagerWindow()
        {
            TaskManagerView view = new TaskManagerView();
            view.Show();

        }
        private void createANewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManagerWindow();
        }
        private void createNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCategroyView view = new NewCategroyView();
            view.Show();
        }
    }
}
