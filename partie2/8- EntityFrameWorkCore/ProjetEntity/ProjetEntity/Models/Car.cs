﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntity.Models
{
    [Table("car")]
    public class Car
    {
        private int id;
        private string name;
        private string description;
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("name")]
        [Required]
        [MaxLength(255)]
        public string Name { get => name; set => name = value; }
        [Column("description")]
        public string Description { get => description; set => description = value; }
    }
}