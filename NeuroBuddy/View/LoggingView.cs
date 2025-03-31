namespace NeuroBuddy
{
    public partial class LoggingView : Form
    {
        public LoggingView()
        {
            InitializeComponent();
        }
        public void LogIntoMainView()
        {
            MainView main = new MainView();
            main.Show();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            LogIntoMainView();
        }
        private void SignUpBtn_Click(object sender,EventArgs e)
        {
            LogIntoMainView();
        }

    }
}
