using System.ComponentModel.DataAnnotations;

namespace ComplexTypeIssue.Models
{
    public class TestModel
    {
        [Key]
        public int Id { get; set; }

        public LocalizedString Description { get; set; }
    }
}