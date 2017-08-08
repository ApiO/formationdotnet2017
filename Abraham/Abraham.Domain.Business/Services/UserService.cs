using Abraham.Domain.Business.DTOs;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;

namespace Abraham.Domain.Business.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Get(int id)
        {
            var userRepo = _repository.Get(id);

            return new User
            {
                Id = userRepo.Id,
                FirstName = userRepo.FirstName,
                LastName = userRepo.LastName,
                Email = userRepo.Email,
                Balance = userRepo.Balance
            };
        }
    }
}
