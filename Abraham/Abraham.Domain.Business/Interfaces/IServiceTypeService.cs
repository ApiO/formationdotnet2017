using Abraham.Domain.Business.DTOs;

namespace Abraham.Domain.Business.Interfaces
{
    public interface IServiceTypeService
    {
        ServiceType Get(int id);
        bool DescriptionExists(string description);
        int Add(ServiceType model);
    }
}
