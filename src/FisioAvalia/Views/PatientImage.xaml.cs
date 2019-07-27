using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioAvalia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientImage : ContentPage
    {
        public PatientImage()
        {
            InitializeComponent();
        }

        private void OnButtonSave(object sender, EventArgs e)
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            lblDescricao.Text += txtDescricao.Text.ToString() + '\n';
            lblDate.Text += dia + '\\' + mes + '\\' + ano + '\n';
        }
    }
}