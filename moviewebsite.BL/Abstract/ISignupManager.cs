using moviewebsite.Entities.Concrete;

namespace moviewebsite.BL.Abstract
{
    public interface ISignupManager : IManagerBase<Signup>
    {
        Task<Signup> GetSignupAsync(string name, string surname, string username, string email, string password, string gsm);
    }
}
