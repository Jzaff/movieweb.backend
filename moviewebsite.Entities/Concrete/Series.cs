using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.Concrete
{
    public class Series : BaseEntity
    {
        public string SeriesName { get; set; }
        public SeriesType SeriesType { get; set; }
    }
}
