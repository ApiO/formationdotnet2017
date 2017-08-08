using Abraham.Domain.Business.DTOs;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;

namespace Abraham.Domain.Business.Services
{
    public class ServiceService : IServiceService
    {
        private IServiceRepository _serviceRepository;
        private IServiceTypeRepository _serviceTypeRepository;

        public ServiceService(IServiceRepository serviceRepository,
            IServiceTypeRepository serviceTypeRepository)
        {
            _serviceRepository = serviceRepository;
            _serviceTypeRepository = serviceTypeRepository;
        }

        public Service Get(int id)
        {
            var serviceRepo = _serviceRepository.Get(id);
            var serviceTypeRepo = _serviceTypeRepository.Get(serviceRepo.TypeId);

            return new Service
            {
                Id = serviceRepo.Id,
                Description = serviceRepo.Description,
                Price = serviceRepo.Price,
                Type = new ServiceType
                {
                    Id = serviceTypeRepo.Id,
                    Description = serviceTypeRepo.Description
                }
            };
        }
    }
}
