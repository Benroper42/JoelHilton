using System.ComponentModel.DataAnnotations;

namespace JoelHilton.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        [Display(Name = "Edited")]
        public bool? Edited { get; set; } // Note the use of nullable bool

        [Display(Name = "LentTo")]
        public string? LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes must be at most 25 characters.")]
        public string? Notes { get; set; }
    }
}
