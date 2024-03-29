﻿using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele categoriei este obligatoriu!")]
        public string CategoryName { get; set; }

        public virtual ICollection<Group>? Groups { get; set; }

    }
}
