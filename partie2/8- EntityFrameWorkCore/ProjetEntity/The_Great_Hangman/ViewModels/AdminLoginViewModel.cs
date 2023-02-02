using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using The_Great_Hangman.Views;

namespace The_Great_Hangman.ViewModels
{
    public class AdminLoginViewModel
    {
        public string AdminPassword { get; set; }
        public ICommand AdminPasswordCommand { get; set; }
        public AdminLoginViewModel()
        {
            AdminPasswordCommand = new RelayCommand(AdminPasswordCommandAction);
        }
        private void AdminPasswordCommandAction()
        {
            if (AdminPassword == "admin")
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
            }
            else
            {
                MessageBox.Show("Mot de passe erroné");
            }
        }
    }
}
