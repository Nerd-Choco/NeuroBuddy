using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;
using NeuroBuddy.Mocks;

namespace NeuroBuddy.Views
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

            var form1 = new Form1(new CategoryManagerMock(database.Categories));
            form1.Show();

            Hide();
        }
    }
}
