using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ProductDiscount:BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int DiscountId { get; set; }

        public Product Product { get; set; }

        public Discount Discount { get; set; }
    }
}
