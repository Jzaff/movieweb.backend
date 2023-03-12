using moviewebsite.BL.Abstract;
using moviewebsite.Entities.Concrete;

namespace moviewebsite.BL.Concrete
{
    public class LoginManager : ManagerBase<Login>, ILoginManager
    {
        public Task<Login> GetLoginAsync(string email, string password)
        {
            return _repositoryBase.FindAsync(x => x.Email == email && x.Password == password);
        }
    }
}
