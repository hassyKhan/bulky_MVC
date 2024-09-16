using System.ComponentModel.DataAnnotations;

namespace MVCmovies.Models
{
    public class Categery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public string DisplayOrder { get; set; } = "";
    }
}
