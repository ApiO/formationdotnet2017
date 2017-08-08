using System;
using Abraham.Domain.Business.DTOs;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;

namespace Abraham.Domain.Business.Services
{
    public class ServiceTypeService : IServiceTypeService
    {
        private IServiceTypeRepository _repository;
        public ServiceTypeService(IServiceTypeRepository repository)
        {
            _repository = repository;
        }

        public TypeService Get(int id)
        {
            var typeServiceRepo = _repository.Get(id);

            return new TypeService
            {
                Id = typeServiceRepo.Id,
                Description = typeServiceRepo.Description
            };
        }
    }
}
