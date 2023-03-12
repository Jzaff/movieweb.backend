using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.Concrete
{
    public class Movie : BaseEntity
    {
        public string MovieName { get; set; }
        public MovieType MovieType { get; set; }
    }
}
