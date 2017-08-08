using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Repositories;

namespace Abraham.Controllers
{
    public class ServiceController : Controller
    {
        private IServiceRepository _serviceRepository;
        private IServiceTypeRepository _serviceTypeRepository;
        private IServiceService _service;

        public ServiceController()
        {
            const string connectionString = @"server=192.168.11.70\SQLEXPRESS,1433;database=abraham;uid=sa;password=toto;Application Name=Homer";
            _serviceRepository = new ServiceRepository(connectionString);
            _serviceTypeRepository= new ServiceTypeRepository(connectionString);
            _service = new ServiceService(_serviceRepository, _serviceTypeRepository);
        }

        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id)
        {
            var service = _service.Get(id);
            return View(service);
        }
    }
}