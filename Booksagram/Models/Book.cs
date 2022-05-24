using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksagram.Models
{
    public class Book
    {
        public Book()
        {
            this.CreatedAt = DateTime.UtcNow;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
