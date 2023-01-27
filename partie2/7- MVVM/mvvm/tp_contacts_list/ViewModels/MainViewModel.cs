using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using tp_contacts_list.ViewModels;
using tp_contacts_list.Models;
using CommunityToolkit.Mvvm.Input;
using tp_contacts_list.DAO;

namespace tp_contacts_list.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        PersonDAO person_dao;
        ContactDAO contact_dao;
        AddressDAO address_dao;
        Contact_Address_DAO contact_address_dao;
        Contact contact;
        public ICommand BottomBtnCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DetailsCommand { get; set; }

        private string bottomBtn = "default";
        public string BottomBtn
        {
            get { return bottomBtn; }
            set
            {
                bottomBtn = value;
                RaisePropertyChange("Bottom_btn");
            }
        }
        public string Firstname
        {
            get => contact.Firstname;
            set
            {
                contact.Firstname = value;
                RaisePropertyChange("Firstname");
            }
        }
        public string Lastname
        {
            get => contact.Lastname;
            set
            {
                contact.Lastname = value;
                RaisePropertyChange("Lastname");
            }
        }
        public DateTime Dateofbirth
        {
            get => contact.Dateofbirth;
            set
            {
                contact.Dateofbirth = value;
                RaisePropertyChange("BirthDate");
            }
        }
        public string Phone_number
        {
            get => contact.Phone_number;
            set
            {
                contact.Phone_number = value;
                RaisePropertyChange("Phone");
            }
        }
        public string Email
        {
            get => contact.Email;
            set
            {
                contact.Email = value;
                RaisePropertyChange("Email");
            }
        }
        public string Number
        {
            get => contact.Contact_address.Number;
            set
            {
                contact.Contact_address.Number = value;
                RaisePropertyChange("AdNumber");
            }
        }
        public string Road
        {
            get => contact.Contact_address.Road;
            set
            {
                contact.Contact_address.Road = value;
                RaisePropertyChange("AdRoad");
            }
        }
        public string Post_code
        {
            get => contact.Contact_address.Post_code;
            set
            {
                contact.Contact_address.Post_code = value;
                RaisePropertyChange("AdPostalCode");
            }
        }
        public string Town
        {
            get => contact.Contact_address.Town;
            set
            {
                contact.Contact_address.Town = value;
                RaisePropertyChange("AdCity");
            }
        }
        public string Country
        {
            get => contact.Contact_address.Country;
            set
            {
                contact.Contact_address.Country = value;
                RaisePropertyChange("AdCountry");
            }
        }


        private void RaisePropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        #region Constructeur
        public MainViewModel()
        {
            contact= new Contact();
            BottomBtnCommand = new RelayCommand(ActionBottomBtnCommand);
            UpdateCommand = new RelayCommand(ActionUpdateCommand);
            DeleteCommand = new RelayCommand(ActionDeleteCommand);
            DetailsCommand = new RelayCommand(ActionDetailsCommand);
        }
        #endregion
        private void ActionBottomBtnCommand()
        {
            // MessageBox.Show(Gender + " " + Lastname + " " + Firstname);
        }
        private void ActionUpdateCommand()
        {
            BottomBtn = "updated";
        }
        private void ActionDeleteCommand()
        {
            // MessageBox.Show(Gender + " " + Lastname + " " + Firstname);
        }
        private void ActionDetailsCommand()
        {
            // MessageBox.Show(Gender + " " + Lastname + " " + Firstname);
        }
    }
}
