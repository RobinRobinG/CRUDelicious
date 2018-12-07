using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious_Entity.Models
{

    public class Dish
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int DishId { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Chef")]
        public string Chef { get; set; }

        [Required]
        [DisplayName("Tastiness")]
        public int Tastiness { get; set; }

        [Required]
        [DisplayName("Calories")]
        public int Calories { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;

        public Dish(){}
    }
}
