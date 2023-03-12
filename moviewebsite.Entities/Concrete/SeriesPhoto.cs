using moviewebsite.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviewebsite.Entities.Concrete
{
    public class SeriesPhoto : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? PhotoPath { get; set; }
        public string? Photourl { get; set; }

        [ForeignKey("SeriesId")]
        public int SeriesId { get; set; }
        public Series? Series { get; set; }
    }
}
