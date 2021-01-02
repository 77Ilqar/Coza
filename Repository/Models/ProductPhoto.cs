using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ProductPhoto:BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(150)]
        public string Image { get; set; }

        public Product Product { get; set; }
    }
}
