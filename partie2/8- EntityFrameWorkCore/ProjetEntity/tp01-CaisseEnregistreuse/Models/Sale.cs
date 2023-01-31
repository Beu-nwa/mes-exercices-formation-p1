﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_CaisseEnregistreuse.Models
{
    public class Sale
    {
        private decimal total;
        public int Id { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total
        {
            get
            {
                total = 0;
                Products.ForEach(p =>
                {
                    total += p.Qty * p.Product.Price;
                });
                return total;
            }
            set
            {
                total = value;
            }
        }

        public List<SaleProduct> Products { get; set; }

        public Sale()
        {
            Products = new List<SaleProduct>();
        }
    }
}
