using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoelHilton.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        

        [Required(ErrorMessage = "Year cannot be older than 1888.")]
        public int Year { get; set; }

        [Display(Name = "Director.")]
        public string? Director { get; set; }

        [Display(Name = "Rating.")]
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edit is required")]
        public int Edited { get; set; } 

        [Display(Name = "LentTo")]
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "CopiedToPlex is required")]
        public int CopiedToPlex { get; set; }

        [Display, StringLength(25, ErrorMessage = "Notes must be at most 25 characters.")]
        public string? Notes { get; set; }
    }
}
