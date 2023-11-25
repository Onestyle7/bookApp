using System.ComponentModel.DataAnnotations;

namespace bookApp.Models
{
    public class Book
    {
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public Genre genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime Release { get; set; }
        public byte NumberInStock { get; set; }

    }
}
