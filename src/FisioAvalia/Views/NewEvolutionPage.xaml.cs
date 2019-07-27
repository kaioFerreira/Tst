using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEvolutionPage : ContentPage
    {
        public NewEvolutionPage()
        {
            InitializeComponent();

            lbl_time.Text = DateTime.Now.ToShortTimeString() + ":00";
            lbl_date.Text = DateTime.Now.ToShortDateString();
        }

        private async void lbl_concluir(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        private void close_tap(object sender, EventArgs e)
        {
            string date = date_picker.Date.ToString();
            lbl_date.Text = "";

            for(int i = 0; i < date.Length; i++)
            {
                if (date[i] != ' ')
                {
                    lbl_date.Text += date[i];
                }
                else break;
            }

            lbl_time.Text = time_picker.Time.ToString();
            frm_date_time.IsVisible = false;
        }

        private void tap(object sender, EventArgs e)
        {
            frm_date_time.IsVisible = true;
        }
    }
}