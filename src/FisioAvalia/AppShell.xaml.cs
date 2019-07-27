namespace FisioAvalia
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            bottomNavigation.CurrentItem = bottomNavigation.Items[1];
        }
    }
}
