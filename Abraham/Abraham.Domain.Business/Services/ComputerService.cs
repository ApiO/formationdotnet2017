using Abraham.Domain.Business.DTOs;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;

namespace Abraham.Domain.Business.Services
{
    public class ComputerService : IComputerService
    {
        private IComputerRepository _repository;
        public ComputerService(IComputerRepository repository)
        {
            _repository = repository;
        }

        public Computer Get(int id)
        {
           var computerRepo = _repository.Get(id);

            return new Computer
            {
                Id = computerRepo.Id,
                Description = computerRepo.Description,
                Date = computerRepo.Date,
                MaintenanceDate = computerRepo.MaintenanceDate
            };
        }
    }
}
