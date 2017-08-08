using DOMAIN_NAME.Business.Interfaces;
using DOMAIN_NAME.Business.Models;

namespace DOMAIN_NAME.Business.Services
{
    public class UserService
    {
        readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
		
        public User Get(int id)
        {
            return _repository.Get(id);
        }
	}
}