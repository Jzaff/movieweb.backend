using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.Concrete
{
    public class Tvshows : BaseEntity
    {
        public string TvshowName { get; set; }
        public TvshowType TvshowType { get; set; }
    }
}
