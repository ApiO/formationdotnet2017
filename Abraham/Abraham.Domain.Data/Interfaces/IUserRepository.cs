using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface IUserRepository
    {
        User Get(int id);
    }
}