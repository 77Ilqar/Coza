using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ProductReview:BaseEntity
    {
        public int ProductId { get; set; }

        public int UserId { get; set; }

        public byte Star { get; set; }

        [Required]
        [MaxLength(500)]
        public string Review { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
