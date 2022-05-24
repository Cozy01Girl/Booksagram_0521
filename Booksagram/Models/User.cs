using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksagram.Models
{
    public class User
    {
        public User()
        {
            this.CreatedAt = DateTime.UtcNow;
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string PasswordHash { get; set; }
        [Required]
        public string Salt { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
