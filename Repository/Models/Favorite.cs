using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Favorite:BaseEntity
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ProductId { get; set; }

        public User User { get; set; }

        public Product Product { get; set; }
    }
}
