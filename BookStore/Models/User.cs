using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        public int IsActive { get; set; }
    }
}
