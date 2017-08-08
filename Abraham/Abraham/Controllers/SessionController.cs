using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Repositories;
using System.Web.Mvc;

namespace Abraham.Controllers
{
    public class SessionController : Controller
    {
        private ISessionRepository _repository;
        private ISessionService _service;

        public SessionController()
        {
            const string connectionString = @"server=192.168.11.70\SQLEXPRESS,1433;database=abraham;uid=sa;password=toto;Application Name=Homer";

            _repository = new SessionRepository(connectionString);
            _service = new SessionService(_repository);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id)
        {
            var session = _service.Get(id);


            return View(session);
        }
    }
}