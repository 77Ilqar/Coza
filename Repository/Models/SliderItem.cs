using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Repository.Enums;

namespace Repository.Models
{
    public class SliderItem:BaseEntity
    {
        [Required]
        public SliderPosition Position { get; set; }
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(150)]
        public string Image { get; set; }
        [Required]
        [MaxLength(150)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(150)]
        public string EndPoint { get; set; }
    }
}
