using System.ComponentModel.DataAnnotations;

namespace Hakaton.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
