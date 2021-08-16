using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ProjectDTO
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string ShortDescription { get; set; }
        [Required] public string Description { get; set; }
        public string GithubUrl { get; set; }
        public string ProjectUrl { get; set; }
        public bool Featured { get; set; }
        public string ProjectImagesUrl { get; set; }
        [Required]public string Type { get; set; }
    }
}