using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string? CategoryName { get; set; }
        public string? Explanation { get; set; }
        public string? CategoryId { get; set; }
    }
}