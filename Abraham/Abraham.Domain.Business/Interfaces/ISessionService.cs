using Abraham.Domain.Business.DTOs;

namespace Abraham.Domain.Business.Interfaces
{
    public interface ISessionService
    {
        Session Get(int id);
    }
}
