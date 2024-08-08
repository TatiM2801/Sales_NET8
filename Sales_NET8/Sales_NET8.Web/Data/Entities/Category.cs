﻿using System.ComponentModel.DataAnnotations;

namespace Sales_NET8.Web.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        [Required(ErrorMessage = "O campo {0} é obrigaório")]
        public string? Name { get; set; }
    }
}

