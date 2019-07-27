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
    public class EvaluationsPatientViewModel : INotifyPropertyChanged
    {

        readonly IList<EvaluationPatientModel> source;
        EvaluationPatientModel selectedProfilePatient;
        int selectionCount = 1;

        public ObservableCollection<EvaluationPatientModel> Evaluations { get; private set; }

        public IList<EvaluationPatientModel> EmptyPatients { get; private set; }

        public EvaluationPatientModel SelectedProfilePatient
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

        public EvaluationsPatientViewModel()
        {
            source = new List<EvaluationPatientModel>();
            CreatePatientsCollection();

            selectedProfilePatient = Evaluations.Skip(3).FirstOrDefault();
            PatientsSelectionChanged();

        }
        void CreatePatientsCollection()
        {
            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 01",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 02",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 03",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 04",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 05",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 06",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 07",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 08",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 09",
            });

            source.Add(new EvaluationPatientModel
            {
                Date = "05/07/2019",
                Evaluation = "Avaliação 10",
            });

            Evaluations = new ObservableCollection<EvaluationPatientModel>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(Patient => Patient.Evaluation.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var Patient in source)
            {
                if (!filteredItems.Contains(Patient))
                {
                    Evaluations.Remove(Patient);
                }
                else
                {
                    if (!Evaluations.Contains(Patient))
                    {
                        Evaluations.Add(Patient);
                    }
                }
            }
        }

        void PatientsSelectionChanged()
        {
            SelectedEvaluationsMessage = $"Selection {selectionCount}: {SelectedProfilePatient.Evaluation}";
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




