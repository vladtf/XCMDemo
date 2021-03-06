﻿using Caliburn.Micro;
using System.Linq;
using XCMDEMO.Models;

namespace XCMDEMO.ViewModels
{
    internal class HomeViewModel : Screen, IChildViewModel
    {
        private readonly EventAggregator _eventAggregater;

        private BindableCollection<PersonModel> _people;
        private PersonModel _selectedPerson;
        public string Title { get; set; } = "Home";

        public HomeViewModel()
        {
            //var result = SQLDataAcces.GetPeople();
            _people = new BindableCollection<PersonModel>();

            People.Add(new PersonModel { FirstName = "John", LastName = "Smith" });
            People.Add(new PersonModel { FirstName = "Will", LastName = "Johnson" });
            People.Add(new PersonModel { FirstName = "Joseph", LastName = "Smith" });

            SelectedPerson = People.FirstOrDefault();

            _eventAggregater = IoC.Get<EventAggregator>();
        }

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { Set(ref _people, value); }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set { Set(ref _selectedPerson, value); }
        }

        public void ItemSelected(object parameter)
        {
            _eventAggregater.PublishOnBackgroundThreadAsync(SelectedPerson);
        }
    }
}