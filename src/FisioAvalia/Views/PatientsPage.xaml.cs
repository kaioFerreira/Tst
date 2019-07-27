using FisioAvalia.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientsPage : ContentPage
    {

        public PatientsPage()
        {
            InitializeComponent();
            BindingContext = new PatientsViewModel("Ativos"); // Para iniciar com os ativos
        }

        private async void OnButtonAddPatientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPatientPage());
        }

        private void OnButtonTodos(object sender, EventArgs e)
        {

            lblAll.FontAttributes = FontAttributes.Bold;
            lblActive.FontAttributes = FontAttributes.None;
            lblFiled.FontAttributes = FontAttributes.None;

            LineActive.IsVisible = false;
            LineFiled.IsVisible = false;
            LineAll.IsVisible = true;

            BindingContext = new PatientsViewModel("Todos");
        }

        private void OnButtonAtivos(object sender, EventArgs e)
        {
            lblActive.FontAttributes = FontAttributes.Bold;
            lblAll.FontAttributes = FontAttributes.None;
            lblFiled.FontAttributes = FontAttributes.None;

            LineAll.IsVisible = false;
            LineFiled.IsVisible = false;
            LineActive.IsVisible = true;

            BindingContext = new PatientsViewModel("Ativos");
        }

        private void OnButtonArchived(object sender, EventArgs e)
        {
            lblFiled.FontAttributes = FontAttributes.Bold;
            lblAll.FontAttributes = FontAttributes.None;
            lblActive.FontAttributes = FontAttributes.None;

            LineAll.IsVisible = false;
            LineActive.IsVisible = false;
            LineFiled.IsVisible = true;

            BindingContext = new PatientsViewModel("Arquivados");
        }

        async void OnButtonOpenProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePatientPage());
        }

    }
}

