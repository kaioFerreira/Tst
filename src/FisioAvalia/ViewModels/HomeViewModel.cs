using System.Windows.Input;
using Xamarin.Forms;

namespace FisioAvalia.ViewModels
{
    public class HomeViewModel
    {

        public string Email { get; set; }

        public ICommand OpenCommand = new Command(async () => await App.Current.MainPage.Navigation.PushAsync(new Views.QuestionnairePage()));

        public HomeViewModel()
        {
            Email = "venanciosb@hotmail.com";
        }

    }
}