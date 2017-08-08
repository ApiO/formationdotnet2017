using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface IServiceTypeRepository
    {
        ServiceType Get(int id);
    }
}
