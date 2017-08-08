using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface ISessionRepository
    {
        Session Get(int id);
    }
}