using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkLab2.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Author
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        public int Age { get; set; }
    }
}
