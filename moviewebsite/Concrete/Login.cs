using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.Concrete
{
    public class Login : BaseEntity
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Signup Signup { get; set; }
    }
}
