using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
// using tpContacts_list.Classes;


namespace tp_contacts_list
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // Bottom_btn
        private string groupbox_header;
        public string Groupbox_header
        {
            get { return groupbox_header; }
            set
            {
                groupbox_header = value;
                OnPropertyChanged("Groupbox_header");
            }
        }
        private string bottom_btn;
        public string Bottom_btn
        {
            get { return bottom_btn; }
            set
            {
                bottom_btn = value;
                OnPropertyChanged("Bottom_btn");
            }
        }
        // public List<Contact> Contacts { get; set; }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainWindow()
        {
            InitializeComponent();
            Change_form_view("add");
            this.DataContext = this;
        }
        private void Change_groupbox_header(string header)
        {
            Groupbox_header = header;
        }
        private void Change_bottom_btn_content(string header)
        {
            Bottom_btn = header;
        }
        private void On_update_click(object sender, RoutedEventArgs e)
        {
            Change_form_view("update");
        }
        private void On_details_click(object sender, RoutedEventArgs e)
        {
            Change_form_view("details");
        }
        private void On_delete_click(object sender, RoutedEventArgs e)
        {

        }
        private void Display_contacts()
        {

        }
        private void Change_form_view(string x)
        {
            switch (x)
            {
                case "add":
                    {
                        Change_groupbox_header("Add contact");
                        Change_bottom_btn_content("Ajouter");
                    }
                    break;
                case "update":
                    {
                        Change_groupbox_header("Update contact");
                        Change_bottom_btn_content("Modifier");
                    }
                    break;
                case "details":
                    {
                        Change_groupbox_header("Détails contact");
                        Change_bottom_btn_content("Fermer");
                    }
                    break;
            }
        }
    }
}
