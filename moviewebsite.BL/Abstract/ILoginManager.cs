using moviewebsite.Entities.Concrete;

namespace moviewebsite.BL.Abstract
{
    public interface ILoginManager : IManagerBase<Login>
    {
        Task<Login> GetLoginAsync(string email, string password);
    }
}
