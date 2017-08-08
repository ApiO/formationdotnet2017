using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface IServiceRepository
    {
        Service Get(int id);
    }
}
