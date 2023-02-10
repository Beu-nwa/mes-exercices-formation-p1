﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using test.Models;

namespace test.ViewModels
{
    internal class PersonViewModel : INotifyPropertyChanged
    {
        #region Attributes
        // Déclaration d'une personne dont les props seront bindé à la vue
        Person person;
        #endregion


        #region Props
        // Implémentation de INotifyPropertyChanged => Impose d'avoir une props de type PropertyChangedEventHandler
        public event PropertyChangedEventHandler PropertyChanged;

        // Création d'une props de Type Icommand
        public ICommand ValidCommand { get; set; }

        public string Firstname
        {
            get => person.Firstname;
            set
            {
                person.Firstname = value;
                RaisePropertyChange("Firstname");
            }
        }
        public string Lastname
        {
            get => person.Lastname;
            set
            {
                person.Lastname = value;
                RaisePropertyChange("Lastname");
            }
        }
        public bool IsM
        {
            get => person.IsM;
            set
            {
                person.IsM = value;
                RaisePropertyChange("Gender");
            }
        }
        public bool IsF
        {
            get => person.IsF;
            set
            {
                person.IsF = value;
                RaisePropertyChange("Gender");
            }
        }
        public string Gender
        {
            get
            {
                if (IsM)
                    return "Mr";
                else if (IsF)
                    return "Mme";
                else
                    return null;
            }

        }
        #endregion


        #region Méthodes
        private void RaisePropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        #endregion

        #region Constructeur
        public PersonViewModel()
        {
            person = new();
            ValidCommand = new RelayCommand(ActionValidCommand);
        }
        #endregion

        #region Command
        private void ActionValidCommand()
        {
            MessageBox.Show(Gender + " " + Lastname + " " + Firstname);
        }

        #endregion
    }

}