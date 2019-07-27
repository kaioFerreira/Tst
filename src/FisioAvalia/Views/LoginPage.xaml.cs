using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FisioAvalia.Common;
using FisioAvalia.Models.Users;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            ActivitySpinner.IsVisible = false;

            BackgroundColor = Constants.BackgroundColor;
            buttonLogin.BackgroundColor = Constants.PrimaryColor;
            buttonLogin.TextColor = Constants.TextColor;
            labelEmail.TextColor = Constants.AccentColor;
            labelPassword.TextColor = Constants.AccentColor;

            entryEmail.Text = "";
            entryPassword.Text = "";

            entryEmail.Completed += (s, e) => entryPassword.Focus();
            entryPassword.Completed += (s, e) => OnLoginClicked(s, e);
        }

        async void OnLoginClicked(object sender, EventArgs e)
        { 
            User user = new User(entryEmail.Text, entryPassword.Text);

            if (!user.CheckUserInformation())
                await DisplayAlert("Login", "Email/Password must not be empty", "Okay");
            else {
                if (Device.RuntimePlatform == Device.Android)
                    Application.Current.MainPage = new FisioAvalia.AppShell();
                else if (Device.RuntimePlatform == Device.iOS)
                    await Navigation.PushModalAsync(new FisioAvalia.AppShell());
            }
        }
    }
}