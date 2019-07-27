using FisioAvalia.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace FisioAvalia.ViewModels
{
    class ImagePatientViewModel
    {

        readonly IList<ImagePatientModel> source;
        ImagePatientModel selectedProfilePatient;
        int selectionCount = 1;

        public ObservableCollection<ImagePatientModel> Images { get; private set; }

        public IList<ProfilePatientModel> EmptyPatients { get; private set; }

        public ImagePatientModel SelectedProfilePatient
        {
            get
            {
                return selectedProfilePatient;
            }
            set
            {
                if (selectedProfilePatient != value)
                {
                    selectedProfilePatient = value;
                }
            }
        }

        public string SelectedPatientsMessage { get; private set; }

        public ICommand FilterCommand => new Command<string>(FilterItems);
        public ICommand PatientsSelectionChangedCommand => new Command(PatientsSelectionChanged);

        public ImagePatientViewModel()
        {
            source = new List<ImagePatientModel>();
            CreatePatientsCollection();

            selectedProfilePatient = Images.Skip(3).FirstOrDefault();
            PatientsSelectionChanged();
        }

        void CreatePatientsCollection()
        {
            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            source.Add(new ImagePatientModel
            { 
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            source.Add(new ImagePatientModel
            {
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Images = new ObservableCollection<ImagePatientModel>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(Patient => Patient.ImageUrl.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var Patient in source)
            {
                if (!filteredItems.Contains(Patient))
                {
                    Images.Remove(Patient);
                }
                else
                {
                    if (!Images.Contains(Patient))
                    {
                        Images.Add(Patient);
                    }
                }
            }
        }

        void PatientsSelectionChanged()
        {
            SelectedPatientsMessage = $"Selection {selectionCount}: {SelectedProfilePatient.ImageUrl}";
            OnPropertyChanged("SelectedPatientsMessage");
            selectionCount++;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}




