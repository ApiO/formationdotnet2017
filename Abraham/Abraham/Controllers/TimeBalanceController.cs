using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Repositories;
using System.Web.Mvc;

namespace Abraham.Controllers
{
    public class TimeBalanceController : Controller
    {
        private ITimeBalanceRepository _repository;
        private ITimeBalanceService _service;

        public TimeBalanceController()
        {
            const string connectionString = @"server=192.168.11.70\SQLEXPRESS,1433;database=abraham;uid=sa;password=toto;Application Name=Homer";

            _repository = new TimeBalanceRepository(connectionString);
            _service = new TimeBalanceService(_repository);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id)
        {
            var tb = _service.Get(id);


            return View(tb);
        }
    }
}