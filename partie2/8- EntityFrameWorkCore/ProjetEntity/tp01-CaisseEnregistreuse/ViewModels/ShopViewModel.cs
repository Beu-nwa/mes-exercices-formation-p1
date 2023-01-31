using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using tp01_CaisseEnregistreuse.Models;
using tp01_CaisseEnregistreuse.Tools;

namespace tp01_CaisseEnregistreuse.ViewModels
{
    public class ShopViewModel : ObservableObject
    {
        private DataDbContext dataDbContext;
        public int? Search { get; set; }
        public decimal Total { get => Sale.Total; }
        public Sale Sale { get; set; }
        public SaleProduct SaleProduct { get; set; }
        public ObservableCollection<SaleProduct> SaleProducts { get; set; }
        public ICommand SearchCommand { get; set; }

        public ICommand ConfirmCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        public ICommand DeleteFromSaleCommand { get; set; }
        public ShopViewModel()
        {
            dataDbContext = new DataDbContext();

            Sale = new Sale();
            SaleProducts = new ObservableCollection<SaleProduct>();

            SearchCommand = new RelayCommand(SearchCommandAction);
            ConfirmCommand = new RelayCommand(ConfirmCommandAction);
            DeleteFromSaleCommand = new RelayCommand(DeleteFromSaleCommandAction);
            ResetCommand = new RelayCommand(ResetCommandAction);
        }

        private void SearchCommandAction()
        {
            Product? product = dataDbContext.Products.FirstOrDefault(p => p.Id == Search);
            if (product != null && product.Stock > 0)
            {
                bool exist = false;
                foreach (SaleProduct saleProduct in SaleProducts)
                {
                    if (saleProduct.Product.Id == product.Id)
                    {
                        saleProduct.Qty++;
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    SaleProducts.Add(new SaleProduct() { Product = product, Qty = 1, Sale = Sale });
                }
                OnPropertyChanged(nameof(Total));
            }
            else
            {
                MessageBox.Show("Aucun produit avec cet id");
            }

        }

        private void ConfirmCommandAction()
        {
            Sale.Products.AddRange(SaleProducts.ToList());
            Sale.Products.ForEach(p =>
            {
                p.Product.Stock = p.Product.Stock - p.Qty;
            });
            dataDbContext.Sales.Add(Sale);

            if (dataDbContext.SaveChanges() > 0)
            {
                MessageBox.Show("Vente ajoutée");
                ResetCommandAction();
            }
            else
            {
                MessageBox.Show("Erreur ajout vente");
            }
        }
        private void ResetCommandAction()
        {
            Search = null;
            SaleProducts.Clear();
            Sale = new Sale();
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Search));
        }
        private void DeleteFromSaleCommandAction()
        {
            if (SaleProduct != null)
            {
                SaleProducts.Remove(SaleProduct);
                OnPropertyChanged(nameof(Total));
            }
        }
    }
}
