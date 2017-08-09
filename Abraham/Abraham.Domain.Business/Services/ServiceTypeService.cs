
using Abraham.Domain.Business.DTOs;
using Model = Abraham.Domain.Data.Models.ServiceType;

using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;
using System;

namespace Abraham.Domain.Business.Services
{
    public class ServiceTypeService : IServiceTypeService
    {
        private IServiceTypeRepository _repository;
        public ServiceTypeService(IServiceTypeRepository repository)
        {
            _repository = repository;
        }

        public ServiceType Get(int id)
        {
            var typeServiceRepo = _repository.Get(id);

            return new ServiceType
            {
                Id = typeServiceRepo.Id,
                Description = typeServiceRepo.Description
            };
        }

        public int Add(ServiceType dto)
        {
            Model model = new Model()
            {
                Description = dto.Description
            };

            return _repository.Add(model);
        }

        public bool DescriptionExists(string description)
        {
            return _repository.DescriptionExists(description);
        }
    }
}
