using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Product:BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SKU { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public byte StarCount { get; set; }
        [Required]
        public bool IsTopSelling { get; set; }
        [Required]
        public bool IsTopRated { get; set; }
        [Required]
        public bool IsFeatured { get; set; }


        public ICollection<ProductPhoto> ProductPhotos { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public ICollection<ProductOption> ProductOptions { get; set; }
        public ICollection<ProductDiscount> Discounts { get; set; }
        public ICollection<Favorite> Favorites { get; set; }

        public Category Category { get; set; }
    }
}
