using moviewebsite.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviewebsite.Entities.Concrete
{
    public class TvshowPhoto : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? PhotoPath { get; set; }
        public string? Photourl { get; set; }

        [ForeignKey("TvshowId")]
        public int TvshowId { get; set; }
        public Tvshows? Tvshows { get; set; }
    }
}
