using Abraham.Domain.Business.DTOs;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;

namespace Abraham.Domain.Business.Services
{
    public class TimeBalanceService : ITimeBalanceService
    {
        private ITimeBalanceRepository _repository;
        public TimeBalanceService(ITimeBalanceRepository repository)
        {
            _repository = repository;
        }

        public TimeBalance Get(int id)
        {
            var tbRepo = _repository.Get(id);

            return new TimeBalance
            {
                Id = tbRepo.Id,
                Value = tbRepo.Value,
                Date = tbRepo.Date,
                UserId = tbRepo.UserId,
            };
        }
    }
}
