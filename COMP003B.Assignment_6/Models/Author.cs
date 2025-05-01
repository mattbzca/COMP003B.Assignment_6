using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment_6.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Collection navigation property
        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }
    }
}
