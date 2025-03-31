namespace NeuroBuddy
{
    public partial class LoggingView : Form
    {
        public LoggingView()
        {
            InitializeComponent();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            MainView main = new MainView();
            main.Show();
        }

    }
}
