using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows;
using The_Great_Hangman.Models;
using The_Great_Hangman.Views;

namespace The_Great_Hangman.ViewModels
{

    public class PlayerLoginViewModel : ObservableObject
    {
        public string Pseudo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Visibility CreateAccount { get; set; }
        public ICommand ValidCommand { get; set; }
        public ICommand CreateAccountCommand { get; set; }

        public PlayerLoginViewModel()
        {
            ValidCommand = new RelayCommand(ValidCommandAction);
            CreateAccount = Visibility.Hidden;
            CreateAccountCommand = new RelayCommand(CreateAccountCommandAction);
        }

        private void ValidCommandAction()
        {
            if (Pseudo == "player")
            {
                PlayerWindow hangman = new PlayerWindow();
                hangman.Show();
            }
            else
            {
                CreateAccount = Visibility.Visible;
                OnPropertyChanged("CreateAccount");
            }
        }

        private void CreateAccountCommandAction()
        {
            User user = new User(); // { Pseudo, LastName, FirstName, WordsList = new List() };
            PlayerWindow hangman = new PlayerWindow();
            hangman.Show();
        }

    }
}
