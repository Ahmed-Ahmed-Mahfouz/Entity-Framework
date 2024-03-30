using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramworkLab2.Models
{
    public class News
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Bref { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        [ForeignKey("Auth")]
        public int AuthorId { get; set; }
        [ForeignKey("Cat")]
        public int CatId { get; set; }

        public virtual Author Auth { get; set; }
        public virtual Catalog Cat { get; set; }
    }
}
