using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
namespace COMP003B.Assignment_6.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }

        public DateTime Date { get; set; } 
    }
}
