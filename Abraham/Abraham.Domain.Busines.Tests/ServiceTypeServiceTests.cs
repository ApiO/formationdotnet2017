using System;
using Abraham.Domain.Business.Interfaces;
using Abraham.Domain.Business.Services;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            _repository = new ServiceTypeRepository("");
            _service = new ServiceTypeService(_repository);
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
        public void GetThrowInvalidOperationException()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                var serviceType = _service.Get(42);
            });
        }
    }
}