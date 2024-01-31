using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class Task
    {
        // Add properties
        public int TaskId { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [MinLength(2)]
        [MaxLength(100)]
        public string Description { get; set; }

        // Id, Name, Created By, Created On, Description
    }
}
