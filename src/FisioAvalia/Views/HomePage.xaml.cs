using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

        }

        async void OnButtonOpenQuestionnairesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionnairePage());
        }

        async void OnButtonOpenScheduleClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SchedulePage());
        }

        async void OnButtonOpenEvaluetionsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EvaluetionsPage());
        }

        async void OnButtonOpenEvolutionsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EvolutionsPage());
        }

        async void OnButtonOpenFinancialClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FinancialPage());
        }

        async void OnButtonOpenRecordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecordPage());
        }

        async void OnButtonProfileClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePatientPage());
        }

    }

}