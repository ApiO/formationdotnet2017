using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface IServiceTypeRepository
    {
        ServiceType Get(int id);
        bool DescriptionExists(string description);
        int Add(ServiceType serviceType);
    }
}
