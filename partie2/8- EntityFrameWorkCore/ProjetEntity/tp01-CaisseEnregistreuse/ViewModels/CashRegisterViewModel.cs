using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tp01_CaisseEnregistreuse.Models;
using tp01_CaisseEnregistreuse.Tools;

namespace tp01_CaisseEnregistreuse.ViewModels
{
    internal class CashRegisterViewModel : ObservableObject
    {
        private Product product;
        private Product selectedProduct;
        private DataDbContext dbContext;
        public ObservableCollection<Product> Products { get; set; }

        public string Name { get => product.Name; set => product.Name = value; }
        public string Description { get => product.Description; set => product.Description = value; }
        public int Stock { get => product.Stock; set => product.Stock = value; }
        public string Message { get; set; }
        public ICommand ValidCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public CashRegisterViewModel()
        {
            dbContext= new DataDbContext();
            Products = new ObservableCollection<Product>();
            product= new Product();
            ValidCommand = new RelayCommand(ValidCommandAction);
            UpdateCommand = new RelayCommand(UpdateCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);
        }
        private void ValidCommandAction()
        {
            if (selectedProduct == null)
            {

                dbContext.Products.Add(product);
                if (dbContext.SaveChanges() > 0)
                {
                    Message = "Produit ajouté à l'id : " + product.Id;
                    Products.Add(product);
                    product = new Product();
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(Stock));
                }
                else
                {
                    Message = "Erreur d'ajout dans la base de donnée";
                }
            }
            else
            {
                if (dbContext.SaveChanges() > 0)
                {
                    Message = "Produit modifiée";
                    selectedProduct = null;
                    product = new Product();
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(Stock));
                }
            }
            OnPropertyChanged(nameof(Message));
        }

        private void UpdateCommandAction()
        {
            product = selectedProduct;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Description));
            OnPropertyChanged(nameof(Stock));
        }
        private void DeleteCommandAction()
        {
            dbContext.Products.Remove(selectedProduct);
            if (dbContext.SaveChanges() > 0)
            {
                Message = "Voiture supprimée";
                OnPropertyChanged(nameof(Message));
                Products.Remove(selectedProduct);
                selectedProduct = null;
            }
            
        }
    }
}
