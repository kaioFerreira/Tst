using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvolutionsPage : ContentPage
    {
        DateTime _triggerTime;

        public EvolutionsPage()
        {
            InitializeComponent();
        }

    }
}