using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
        }
        private void Handle_HeaderTapped(object sender, HeaderTappedEventArgs e)
        {
            var dateTime = e.DateTime;
        }
    }
}