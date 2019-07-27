using Xamarin.Forms;


namespace FisioAvalia
{
    public partial class App : Application
    {
        public static object NavigationPage { get; internal set; }
       

        public App()
        {
            InitializeComponent();

            HotReloader.Current.Run(this);

            MainPage = new AppShell();




        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
