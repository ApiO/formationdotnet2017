using Abraham.Domain.Business.DTOs;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;

namespace Abraham.Domain.Business.Services
{
    public class SessionService : ISessionService
    {
        private ISessionRepository _repository;
        public SessionService(ISessionRepository repository)
        {
            _repository = repository;
        }

        public Session Get(int id)
        {
            var sessionRepo = _repository.Get(id);

            return new Session
            {
                Id = sessionRepo.Id,
                BeginDate = sessionRepo.BeginDate,
                EndDate = sessionRepo.EndDate,
                UserId = sessionRepo.UserId,
                CmpId = sessionRepo.CmpId,
            };
        }
    }
}
