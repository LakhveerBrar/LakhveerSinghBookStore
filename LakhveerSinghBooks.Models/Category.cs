using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LakhveerSinghBooks.Models
{
   public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Category Nmae")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
