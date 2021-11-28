using System;
using System.Collections.Generic;
using System.Text;
using Aliens.Core;

namespace Aliens.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand AliensViewCommand { get; set; }

        public RelayCommand SpaseshipsViewCommand { get; set; }

        public RelayCommand PeopleViewCommand { get; set; }
        public AliensViewModel AliensVM { get; set; }

        public SpaceshipsViewModel SpaseshipsVM { get; set; }

        public PeopleViewModel PeopleVM { get; set; }


        private object _CurrentView;

        public object CurrentView
        {
            get { return _CurrentView; }
            set
            {
                _CurrentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            AliensVM = new AliensViewModel();
            SpaseshipsVM = new SpaceshipsViewModel();
            PeopleVM = new PeopleViewModel();

            CurrentView = AliensVM;

            AliensViewCommand = new RelayCommand(o =>
            {
                CurrentView = AliensVM;
            });

            SpaseshipsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SpaseshipsVM;
            });

            PeopleViewCommand = new RelayCommand(o =>
            {
                CurrentView = PeopleVM;
            });
        }




    }
}
