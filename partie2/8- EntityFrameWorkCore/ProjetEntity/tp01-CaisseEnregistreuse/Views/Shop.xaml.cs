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
using tp01_CaisseEnregistreuse.Tools;
using tp01_CaisseEnregistreuse.ViewModels;

namespace tp01_CaisseEnregistreuse.Views
{
    /// <summary>
    /// Logique d'interaction pour Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        //public Shop(DataDbContext dbContext)
        public Shop()
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
        }

    }
}
