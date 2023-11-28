using System;
using WpfApp1.Core;
using WpfApp1.MVVM.View;

namespace WpfApp1.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand Why_ViewCommand { get; set; }
        public RelayCommand BasicViewCommand { get; set; }
        public RelayCommand WhatViewCommand { get; set; }
        public RelayCommand SourcesViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public WhyC_ViewModel WhyVM { get; set; }
        public BasicViewModel BasicVM { get; set; }
        public WhatViewModel WhatVM { get; set; }
        public SourcesViewModel SourcesVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
                }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            WhyVM = new WhyC_ViewModel();
            BasicVM = new BasicViewModel();
            WhatVM = new WhatViewModel();
            SourcesVM = new SourcesViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });






            WhyVM = new WhyC_ViewModel();

            Why_ViewCommand = new RelayCommand(o =>
            {
                CurrentView = WhyVM;
            });



            BasicVM = new BasicViewModel();

            BasicViewCommand = new RelayCommand(o =>
            {
                CurrentView = BasicVM;
            });



            WhatVM = new WhatViewModel();

            WhatViewCommand = new RelayCommand(o =>
            {
                CurrentView = WhatVM;
            });



            SourcesVM = new SourcesViewModel();

            SourcesViewCommand = new RelayCommand(o =>
            {
                CurrentView = SourcesVM;
            });
        }
    }
}
