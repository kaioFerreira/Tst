using FisioAvalia.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePatientPage : ContentPage
    {
        public ProfilePatientPage()
        {
            InitializeComponent();
            OnButtonImages(new object(), new EventArgs());
        }

        private void OnButtonImages(object sender, EventArgs e)
        {
            LineEvaluation.IsVisible = false;
            LineEvolution.IsVisible = false;
            LineImage.IsVisible = true;

            CollectionEvolution.IsVisible = false;
            CollectionEvaluations.IsVisible = false;
            CollectionImagens.IsVisible = true;
            BindingContext = new ImagePatientViewModel();
        }

        private void OnButtonEvaluation(object sender, EventArgs e)
        {
            LineEvolution.IsVisible = false;
            LineImage.IsVisible = false;
            LineEvaluation.IsVisible = true;

            CollectionEvolution.IsVisible = false;
            CollectionImagens.IsVisible = false;
            CollectionEvaluations.IsVisible = true;
            BindingContext = new EvaluationsPatientViewModel();
        }

        private void OnButtonEvolution(object sender, EventArgs e)
        {
            LineEvaluation.IsVisible = false;
            LineImage.IsVisible = false;
            LineEvolution.IsVisible = true;

            CollectionImagens.IsVisible = false;
            CollectionEvaluations.IsVisible = false;
            CollectionEvolution.IsVisible = true;
            BindingContext = new EvolutionsPatientViewModel();
        }

        void OnSwipedEvaluation(object sender, SwipedEventArgs e)
        {
            if (e.Direction.ToString() == "Left")
            {
                LineEvaluation.IsVisible = false;
                LineImage.IsVisible = false;
                LineEvolution.IsVisible = true;

                CollectionEvolution.IsVisible = true;
                CollectionImagens.IsVisible = false;
                CollectionEvaluations.IsVisible = false;
                BindingContext = new EvolutionsPatientViewModel();
            }
            else if (e.Direction.ToString() == "Right")
            {
                LineEvaluation.IsVisible = false;
                LineEvolution.IsVisible = false;
                LineImage.IsVisible = true;

                CollectionEvolution.IsVisible = false;
                CollectionEvaluations.IsVisible = false;
                CollectionImagens.IsVisible = true;
                BindingContext = new ImagePatientViewModel();
            }
        }

        void OnSwipedEvolution(object sender, SwipedEventArgs e)
        {
            if (e.Direction.ToString() == "Right")
            {
                LineEvolution.IsVisible = false;
                LineImage.IsVisible = false;
                LineEvaluation.IsVisible = true;

                CollectionEvolution.IsVisible = false;
                CollectionImagens.IsVisible = false;
                CollectionEvaluations.IsVisible = true;
                BindingContext = new EvaluationsPatientViewModel();
            }
        }

        void OnSwipedImage(object sender, SwipedEventArgs e)
        {
            if (e.Direction.ToString() == "Left")
            {
                LineEvolution.IsVisible = false;
                LineImage.IsVisible = false;
                LineEvaluation.IsVisible = true;

                CollectionEvolution.IsVisible = false;
                CollectionImagens.IsVisible = false;
                CollectionEvaluations.IsVisible = true;
                BindingContext = new EvaluationsPatientViewModel();
            }
        }

         

        async void TopOptionMenu(object sender, EventArgs e)
        {
            popupMenuView.IsVisible = true;
        }
    
        async void OnCollectionViewSelectionChangedEvaluation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecordPage());
        }

        async void OnCollectionViewSelectionChangedEvolution(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterEvolutionPage());
        }
        async void OnCollectionViewSelectionChangedImage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PatientImage());
        }

        private void Frame_sair(object sender, EventArgs e)
        {
            BindingContext = new ProfilePatientPage();
            popupMenuView.IsVisible = false;
        }

        private void OnButtonCloseMenu(object sender, EventArgs e)
        {
            popupMenuView.IsVisible = false;
        }

        private void OnButtonAddPhotograph(object sender, EventArgs e)
        {
            
        }

        private void OnButtonAddEvaluation(object sender, EventArgs e)
        {

        }

        private async void OnButtonAddEvolution(object sender, EventArgs e)
        {
            popupMenuView.IsVisible = false;
            await Navigation.PushAsync(new NewEvolutionPage());   
        }

        private  async void OnButtonEditProfile(object sender, EventArgs e)
        {
            popupMenuView.IsVisible = false;
            await Navigation.PushAsync(new RegisterPatientPage());
        }
    }
}