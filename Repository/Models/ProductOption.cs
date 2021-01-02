using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Repository.Enums;

namespace Repository.Models
{
    public class ProductOption:BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public OptionsType Type { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public Product Product { get; set; }

        public ICollection<ProductOptionItem> OptionItems { get; set; }
    }
}
