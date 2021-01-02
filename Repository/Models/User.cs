using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class User:BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Password { get; set; }
        [Required]
        [MaxLength(150)]
        public string Token { get; set; }

        public ICollection<ProductReview> ProductReviews { get; set; }

        public ICollection<Favorite> Favorites { get; set; }
    }
}
