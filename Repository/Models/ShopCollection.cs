using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ShopCollection:BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Image { get; set; }
        [Required]
        [MaxLength(150)]
        public string EndPoint { get; set; }
    }
}
