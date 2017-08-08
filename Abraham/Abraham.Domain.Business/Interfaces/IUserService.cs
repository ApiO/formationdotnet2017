using Abraham.Domain.Business.DTOs;

namespace Abraham.Domain.Business.Interfaces
{
    public interface IUserService
    {
        User Get(int id);
    }
}
