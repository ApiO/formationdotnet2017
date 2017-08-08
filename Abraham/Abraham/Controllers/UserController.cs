using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Repositories;
using System.Web.Mvc;

namespace Abraham.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _repository;
        private IUserService _service;

        public UserController()
        {
            const string connectionString = @"server=192.168.11.70\SQLEXPRESS,1433;database=abraham;uid=sa;password=toto;Application Name=Homer";

            _repository = new UserRepository(connectionString);
            _service = new UserService(_repository);
        }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Form(int id)
        {
            var user = _service.Get(id);


            return View(user);
        }
    }
}