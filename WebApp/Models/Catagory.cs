﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
       public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
