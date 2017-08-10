using System;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;

namespace Abraham.Domain.Busines.Tests
{
    [TestClass]
    public class ServiceTypeServiceTests
    {
        private static IServiceTypeRepository _repository;
        private static IServiceTypeService _service;

        [TestInitialize]
        public void TestInit()
        {
            //_repository = new ServiceTypeRepository("");
            _repository = A.Fake<IServiceTypeRepository>();
            
        }

        [TestMethod]
        public void ConstructorIsValid()
        {
            try
            {
                var service = new ServiceTypeService(_repository);
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        
        [TestMethod]
        public void ServiceTypeServiceGetAreEqual()
        {
            Data.Models.ServiceType retourRepositiry = new Data.Models.ServiceType() { Id = 42, Description = "toto" };
            Business.DTOs.ServiceType retourService = new Business.DTOs.ServiceType() { Id = 42, Description = "toto" };

            A.CallTo(() => _repository.Get(0)).WithAnyArguments().Returns(retourRepositiry);
            _service = new ServiceTypeService(_repository);

            var serviceType = _service.Get(42);

            Assert.AreEqual(retourService.Id, serviceType.Id);
            Assert.AreEqual(retourService.Description, serviceType.Description);
        }

        [TestMethod]
        public void ServiceTypeServiceAddAreEqual()
        {
            A.CallTo(() => _repository.Add(null)).WithAnyArguments().Returns(42);
            _service = new ServiceTypeService(_repository);

            var newId = _service.Add(new Business.DTOs.ServiceType());

            Assert.AreEqual(42, newId);
        }

        [TestMethod]
        public void ServiceTypeServiceDescriptionExistsIsTrue()
        {
            A.CallTo(() => _repository.DescriptionExists(string.Empty)).WithAnyArguments().Returns(true);
            _service = new ServiceTypeService(_repository);

            var retour = _service.DescriptionExists("toto");

            Assert.AreEqual(true, retour);
        }
    }
}