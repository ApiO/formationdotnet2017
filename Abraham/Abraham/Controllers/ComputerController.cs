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
    public class ComputerController : Controller
    {
        private IComputerRepository _repository;
        private IComputerService _service;

        public ComputerController()
        {
            const string connectionString = @"server=192.168.11.70\SQLEXPRESS,1433;database=abraham;uid=sa;password=toto;Application Name=Homer";

            _repository = new ComputerRepository(connectionString);
            _service = new ComputerService(_repository);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id)
        {
            var computer = _service.Get(id);
            return View(computer);
        }
    }
}