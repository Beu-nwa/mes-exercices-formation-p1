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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tp_nb_mystere
{
    public partial class MainWindow : Window
    {
        private static int counter = 1;
        private static int mistery_number;
        public MainWindow()
        {
            InitializeComponent();
            Generate_random();
        }
        private void Update_chaine_ligne_3(string chaine)
        {
            TextBlock Chaine_ligne_3 = (TextBlock)this.FindName("Chaine_ligne_3");
            if (Chaine_ligne_3 != null)
            {
                Chaine_ligne_3.Text = chaine;
            }
        }
        private void Update_attempt_counter(int x)
        {
            counter = ++x;
            counter_text = (TextBlock)this.FindName("counter_text");
            counter_text.Text = $"tentative {counter} :";
        }
        private void Generate_random()
        {
            mistery_number = new Random().Next(1,51);
        }
        private void Confirm_attempt_Click(object sender, RoutedEventArgs e)
        {
            input_attempt = (TextBox)this.FindName("input_attempt");
            int attempt;
            if (!int.TryParse(input_attempt.Text, out attempt))Update_chaine_ligne_3("Veuillez saisir un nombre entier valide entre 1 et 50 inclus");
            else Attempt(attempt);
        }
        private void New_Game_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Etes-vous sûr de vouloir commencer une nouvelle partie?", "Nouvelle partie", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Generate_random();
                Update_attempt_counter(0);
                Update_chaine_ligne_3($"Partie relancée, compteur réinitialisé à {counter}");
                Enable_Button();
            }
        }
        private void Attempt(int x)
        {

            if(x < 0 || x > 50 )
            {
                Update_chaine_ligne_3($"Erreur, veuillez saisir un nombre entier entre 1 et 50 inclus");
            }
            else if (x > mistery_number)
            {
                Update_chaine_ligne_3($"Le nombre mystère est plus petit que {x}");
                Update_attempt_counter(counter);
            }
            else if (x < mistery_number)
            {
                Update_chaine_ligne_3($"Le nombre mystère est plus grand que {x}");
                Update_attempt_counter(counter);
            }
            else // =
            {
                Update_chaine_ligne_3($"Gagné en {--counter} coups ! Le nombre mystère était : {x}");
                Disable_Button();
            }
        }
        private void Enable_Button()
        {
            Button valider_btn = (Button)this.FindName("valider_btn");
            valider_btn.IsEnabled = true;
        }
        private void Disable_Button()
        {
            Button valider_btn = (Button)this.FindName("valider_btn");
            valider_btn.IsEnabled = false;
        }
    }
}
