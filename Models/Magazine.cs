using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Models
{
    public class Magazine
    {
        [Required]
        public long MagazineId { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Enter price")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price
        {
            get; set;
        }
    }
}
