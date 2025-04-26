using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroBuddyWinForms
{
    public partial class MainWindow : Form
    {
        IDatabaseManager manager;

        public MainWindow(IDatabaseManager manager)
        {
            InitializeComponent();

            this.manager = manager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var database = manager.GetUserdatabase(textBox1.Text);

            var form1 = new Form1(database.CategoryManager);
            form1.Show();

            Hide();
        }
    }
}
