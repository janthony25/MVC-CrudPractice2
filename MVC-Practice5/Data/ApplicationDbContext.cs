using System.ComponentModel.DataAnnotations;

namespace MVC_Practice5.Data
{
    public class ApplicationDbContext
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
