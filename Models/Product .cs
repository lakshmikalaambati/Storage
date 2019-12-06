using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Range(1, 10000,
            ErrorMessage = "Price must be between 1 and 10000")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required(ErrorMessage = "An Category Title is required")]
        public string Category { get; set; }

        public string Shelf { get; set; }

        [Range(0, 9999)]
        public int Count { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
