﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage="Display Order must be between 1 and 100!")]
        public int DisplayOrder { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
