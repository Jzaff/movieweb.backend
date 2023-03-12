using moviewebsite.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviewebsite.Entities.Concrete
{
    public class MoviePhoto : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? PhotoPath { get; set; }
        public string? Photourl { get; set; }

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
