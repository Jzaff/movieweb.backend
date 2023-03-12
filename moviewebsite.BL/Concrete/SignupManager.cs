using moviewebsite.BL.Abstract;
using moviewebsite.Entities.Concrete;

namespace moviewebsite.BL.Concrete
{
    public class SignupManager : ManagerBase<Signup>, ISignupManager
    {
        public Task<Signup> GetSignupAsync(string name, string surname, string username, string email, string password, string gsm)
        {
            return _repositoryBase.FindAsync(x => x.Name == name && x.Surname == surname && x.Username == username && x.Email == email && x.Password == password && x.Gsm == gsm);
        }
    }
}
