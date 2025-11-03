using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }

        [Required(ErrorMessage = "Author name is required")]
        [StringLength(50, ErrorMessage = "Author name cannot exceed 50 characters")]
        [Display(Name = "Author Name")]
        public string Author { get; set; }
    }
}
