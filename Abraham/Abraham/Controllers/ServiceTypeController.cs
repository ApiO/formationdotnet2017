using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Data.Interfaces;
using System.Web.Mvc;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Repositories;
using Abraham.Domain.Business.DTOs;

namespace Abraham.Controllers
{
    public class ServiceTypeController : Controller
    {
        private IServiceTypeRepository _repository;
        private IServiceTypeService _service;

        public ServiceTypeController()
        {
            const string connectionString = @"server=192.168.11.70\SQLEXPRESS,1433;database=abraham;uid=sa;password=toto;Application Name=Homer";

            _repository = new ServiceTypeRepository(connectionString);
            _service = new ServiceTypeService(_repository);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id)
        {
            var serviceType = _service.Get(id);
            return View(serviceType);
        }

        public ActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServiceType(ServiceType model)
        {
            if(ModelState.IsValid)
                model.Id = 42;

            return Content("{id:42}","application/json");
        }
    }
}