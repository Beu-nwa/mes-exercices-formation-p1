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
    public class AdminViewModel
    {
    public ICommand ToUserWindowCommand { get; set; }
    public ICommand ToWordWindowCommand { get; set; }

        public AdminViewModel()
        {
            ToUserWindowCommand = new RelayCommand(ToUserWindowCommandAction);
            ToWordWindowCommand = new RelayCommand(ToWordWindowCommandAction);
        }
        private void ToUserWindowCommandAction()
        {
            AdminUserWindow adminUserWindow = new AdminUserWindow();
            adminUserWindow.Show();
        }
        private void ToWordWindowCommandAction()
        {
            AdminWordWindow adminWordWindow = new AdminWordWindow();
            adminWordWindow.Show();
        }

    }
}
