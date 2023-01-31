using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using The_Great_Hangman.ViewModels;

namespace The_Great_Hangman.Views
{
    /// <summary>
    /// Logique d'interaction pour PlayerLoginWindow.xaml
    /// </summary>
    public partial class PlayerLoginWindow : Window
    {
        public PlayerLoginWindow()
        {
            InitializeComponent();
            DataContext = new PlayerLoginViewModel();
        }
    }
}
