using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace tp_pendu
{
    public partial class MainWindow : Window
    {
        private static int attempts_counter = 0;
        private string[] mots = { "amour", "bonjour", "chat", "chien", "maison", "ordinateur"};
        private string mot_mystere;
        private List<String> attempts;
        private List<String> attempts2;
        public MainWindow()
        {
            InitializeComponent();
            Jouer();
        }
        private void Generer_image(int x)
        {
            if(x > 0 && x < 12)
            {
            var imagePath = $"pack://application:,,,/img_pendu/pendu-{x}.jpg";
            emplacement_image.Source = new BitmapImage(new Uri(imagePath));
            } else if(x == 0) emplacement_image.Source = null;
        }
        private void Generer_mot()
        {
            Random r = new Random();
            mot_mystere = mots[r.Next(0,mots.Length)];
            string chaine = "";
            mot_a_trouver = (TextBlock)this.FindName("mot_a_trouver");
            for (int i = 0; i < mot_mystere.Length; i++)
            {
                chaine += "*";
            }
            mot_a_trouver.Text = chaine;
        }
        private void Confirm_attempt_click(object sender, RoutedEventArgs e)
        {
            input_attempt = (TextBox)this.FindName("input_attempt");

            if (input_attempt.Text.Length == 1)
            {
                if (!Update_mask(Convert.ToChar(input_attempt.Text)))
                {
                    ++attempts_counter;
                    Generer_image(attempts_counter);
                    if (attempts_counter == 11) Disable_Button(); // perdu
                    Update_attemps_history(Convert.ToString(input_attempt.Text));
                } else
                {
                    if (!attempts2.Contains(Convert.ToString(input_attempt.Text)))
                    {
                        attempts2.Add(Convert.ToString(input_attempt.Text));
                    }
                    if (attempts2.Count == mot_mystere.Length) Disable_Button(); // gagné
                }
            }
        }
        private void Jouer()
        {
            attempts = new List<string>();
            attempts2 = new List<string>();
            Enable_Button();
            attempts_counter = 0;
            lettres_proposées = (TextBlock)this.FindName("lettres_proposées");
            lettres_proposées.Text = "";
            Generer_image(0);
            Generer_mot();
        }
        private void Rejouer_Click(object sender, RoutedEventArgs e)
        {
            Jouer();
        }
        private bool Update_mask(char lettre)
        {
            mot_a_trouver = (TextBlock)this.FindName("mot_a_trouver");
            string mask = "";
            bool found = false;
            for (int i = 0; i < mot_a_trouver.Text.Length; i++)
            {
                if (mot_mystere[i] == lettre)
                {
                    mask += lettre;
                    found = true;
                    //if (!attempts.Contains(lettre))
                }
                else if (mot_a_trouver.Text[i] != '*') mask += mot_a_trouver.Text[i];
                else mask += "*";
            }
            mot_a_trouver.Text = mask;
            return found;
        }
        private void Update_attemps_history(string lettre)
        {
            string chaine = "";
            if(!attempts.Contains(lettre))
            {
                attempts.Add(lettre);
            }
            foreach (string x in attempts)
            {
                chaine += x == attempts[0] ? $"{x}" : $" - {x}";
            }
            lettres_proposées = (TextBlock)this.FindName("lettres_proposées");
            lettres_proposées.Text = chaine;
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
