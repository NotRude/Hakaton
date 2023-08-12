using System.ComponentModel.DataAnnotations;

namespace Hakaton.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
