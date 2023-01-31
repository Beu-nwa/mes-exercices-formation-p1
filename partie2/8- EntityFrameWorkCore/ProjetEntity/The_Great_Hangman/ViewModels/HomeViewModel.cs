using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using The_Great_Hangman.Views;

namespace The_Great_Hangman.ViewModels
{
    public class HomeViewModel
    {
        public ICommand PlayerLoginCommand { get; set; }
        public ICommand AdminLoginCommand { get; }

        public HomeViewModel()
        {
            PlayerLoginCommand = new RelayCommand(PlayerLoginCommandAction);
            AdminLoginCommand = new RelayCommand(AdminLoginCommandAction);
        }

        private void PlayerLoginCommandAction()
        {
            PlayerLoginWindow p = new PlayerLoginWindow();
            p.Show();
        }

        private void AdminLoginCommandAction()
        {
            AdminLoginWindow a = new AdminLoginWindow();
            a.Show();
        }
    }
}
