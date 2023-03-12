using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.Concrete
{
    public class Signup : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
    }
}