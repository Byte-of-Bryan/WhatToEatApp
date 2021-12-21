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
        [Required]
        public string Url { get; set; }
        public string Cuisine { get; set; } = "Not Assigned";
        public string Image { get; set; } = "https://media.istockphoto.com/photos/white-plate-wooden-table-tablecloth-rustic-wooden-clean-copy-freepik-picture-id1170315961?b=1&k=20&m=1170315961&s=170667a&w=0&h=KeUniBGtsXgjBNJCWFvMVifYQ8_h_6tQ_lalFvDPfZA=";
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
