using Xamarin.Forms;

namespace CustomActivityIndicator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Handle_Clicked(object sender, System.EventArgs e)
        {
                Indicator.IsRunning = !Indicator.IsRunning;
                RunButton.Text = Indicator.IsRunning ? "Stop" : "Run";    
        }
    }
}
