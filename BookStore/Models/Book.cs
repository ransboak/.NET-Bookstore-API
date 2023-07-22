using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }

        public int Category_id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        [Column (TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
    }
}
