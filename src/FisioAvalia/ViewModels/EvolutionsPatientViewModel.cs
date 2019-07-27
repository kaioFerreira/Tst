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
    public class EvolutionsPatientViewModel : INotifyPropertyChanged
    {

        readonly IList<EvolutionPatientModel> source;
        EvolutionPatientModel selectedProfilePatient;
        int selectionCount = 1;

        public ObservableCollection<EvolutionPatientModel> Evolutions { get; private set; }

        public IList<EvaluationPatientModel> EmptyPatients { get; private set; }

        public EvolutionPatientModel SelectedProfilePatient
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

        public string SelectedEvaluationsMessage { get; private set; }

        public ICommand FilterCommand => new Command<string>(FilterItems);
        public ICommand PatientsSelectionChangedCommand => new Command(PatientsSelectionChanged);

        public EvolutionsPatientViewModel()
        {
            source = new List<EvolutionPatientModel>();
            CreatePatientsCollection();

            selectedProfilePatient = Evolutions.Skip(3).FirstOrDefault();
            PatientsSelectionChanged();

        }
        void CreatePatientsCollection()
        {
            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 01",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 02",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 03",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 04",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 05",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 06",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 07",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 08",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 09",
            });

            source.Add(new EvolutionPatientModel
            {
                Date = "05/07/2019",
                Evolution = "Evolução 10",
            });

            Evolutions = new ObservableCollection<EvolutionPatientModel>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(Patient => Patient.Evolution.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var Patient in source)
            {
                if (!filteredItems.Contains(Patient))
                {
                    Evolutions.Remove(Patient);
                }
                else
                {
                    if (!Evolutions.Contains(Patient))
                    {
                        Evolutions.Add(Patient);
                    }
                }
            }
        }

        void PatientsSelectionChanged()
        {
            SelectedEvaluationsMessage = $"Selection {selectionCount}: {SelectedProfilePatient.Evolution}";
            OnPropertyChanged("SelectedEvaluationsMessage");
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




