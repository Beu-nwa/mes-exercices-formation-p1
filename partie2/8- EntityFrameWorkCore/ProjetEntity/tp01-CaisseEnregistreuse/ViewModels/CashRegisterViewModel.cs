using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using tp01_CaisseEnregistreuse.Models;
using tp01_CaisseEnregistreuse.Tools;
using tp01_CaisseEnregistreuse.Views;

namespace tp01_CaisseEnregistreuse.ViewModels
{
    public class CashRegisterViewModel : ObservableObject
    {
        private Product product;
        // private Categorie categorie;
        public Product SelectedProduct { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Categorie> Categories { get; set; }
        public Categorie categorie { get; set; }
        public Categorie SelectedCategorie { get => product.Categorie; set => product.Categorie = value; }

        private DataDbContext dbContext;
        public string Name { get => product.Name; set => product.Name = value; }
        public string CategoryName { get => categorie.Title; set => categorie.Title = value; }
        public string Description { get => product.Description; set => product.Description = value; }
        public int Stock { get => product.Stock; set => product.Stock = value; }
        public string Message { get; set; }
        public string Comment { get; set; }
        public string SearchText { get; set; }
        public ICommand ValidCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand AddCommentCommand { get; set; }
        public ICommand DisplayCommentCommand { get; set; }
        public ICommand AddCategorieCommand { get; set; }
        public ICommand ReturnCommand { get; set; }
        public ICommand ToShopViewCommand { get; set; }
        public CashRegisterViewModel()
        {
            dbContext= new DataDbContext();
            Products = new ObservableCollection<Product>(dbContext.Products);
            Categories = new ObservableCollection<Categorie>(dbContext.Categories);
            product = new Product();
            categorie = new Categorie();

            ValidCommand = new RelayCommand(ValidCommandAction);
            UpdateCommand = new RelayCommand(UpdateCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);
            SearchCommand = new RelayCommand(SearchCommandAction);
            AddCommentCommand = new RelayCommand(AddCommentCommandAction);
            DisplayCommentCommand = new RelayCommand(DisplayCommentCommandAction);
            AddCategorieCommand = new RelayCommand(AddCategorieCommandAction);
            ReturnCommand = new RelayCommand(ReturnCommandAction);
            ToShopViewCommand = new RelayCommand(ToShopViewCommandAction);
        }
        private void ValidCommandAction()
        {
            if (SelectedProduct == null)
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
                    //OnPropertyChanged(nameof(CategoryName));
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
                    SelectedProduct = null;
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
            product = SelectedProduct;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Description));
            OnPropertyChanged(nameof(Stock));
        }
        private void DeleteCommandAction()
        {
            dbContext.Products.Remove(SelectedProduct);
            if (dbContext.SaveChanges() > 0)
            {
                Message = "Produit supprimé";
                OnPropertyChanged(nameof(Message));
                Products.Remove(SelectedProduct);
                SelectedProduct = null;
            }
        }
        private void SearchCommandAction()
        {
            if (SearchText != null)
            {
                List<Product> searchProducts = dbContext.Products.Where(p => p.Name.Contains(SearchText)).ToList();
                Products = new ObservableCollection<Product>(searchProducts);
            }
            else
            {
                Products = new ObservableCollection<Product>(dbContext.Products);
            }
            OnPropertyChanged(nameof(Products));
        }

        private void AddCommentCommandAction()
        {
            if (SelectedProduct != null)
            {
                Comment comment = new Comment() { Content = Comment };
                SelectedProduct.Comments.Add(comment);
                if (dbContext.SaveChanges() > 0)
                {
                    Message = "Commentaire ajouté";
                    OnPropertyChanged(nameof(Message));
                }
            }
        }
        private void DisplayCommentCommandAction()
        {
            SelectedProduct = dbContext.Products.Include(c => c.Comments).First(c => c.Id == SelectedProduct.Id);
            Message = SelectedProduct.Comments.Count > 1 ? "Commentaires affichés" : SelectedProduct.Comments.Count == 1 ? "Commentaire affiché" : "Aucun commentaire disponible pour ce produit";
            OnPropertyChanged(nameof(SelectedProduct));
            OnPropertyChanged(nameof(Message));
        }

        private void AddCategorieCommandAction()
        {
            dbContext.Categories.Add(categorie);
            if (dbContext.SaveChanges() > 0)
            {
                Categories.Add(categorie);
                MessageBox.Show("catégorie ajoutée");
            }
        }

        private void ReturnCommandAction()
        {
            Name = "";
            Description = "";
            Stock = 0;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Description));
            OnPropertyChanged(nameof(Stock));
            //Categories.FirstOrDefault(x => x.Title == "Default");
        }
        //private void ChangeDefaultValue()
        //{
        //    Categorie defaultCategorie = Categories.FirstOrDefault(x => x.Title == "Default");
        //    combobox.SelectedItem = defaultCategorie;
            
        //}
        private void ToShopViewCommandAction()
        {
            Shop ShopView = new Shop();
            ShopView.Show();
        }
    }
}
