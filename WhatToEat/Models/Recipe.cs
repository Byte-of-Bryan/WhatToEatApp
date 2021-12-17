using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WhatToEat.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Url { get; set; }
        [AllowHtml]
        public string contents { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
