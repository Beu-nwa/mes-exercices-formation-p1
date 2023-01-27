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
using tp01_CaisseEnregistreuse.ViewModels;

namespace tp01_CaisseEnregistreuse.Views
{
    /// <summary>
    /// Logique d'interaction pour CashRegister.xaml
    /// </summary>
    public partial class CashRegister : Window
    {
        public CashRegister()
        {
            InitializeComponent();
            DataContext = new CashRegisterViewModel();
        }
    }
}
