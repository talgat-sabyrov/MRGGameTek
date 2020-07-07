using MRGGameTek.Abstract;
using MRGGameTek.Helpers;
using MRGGameTek.Storage;
using System;
using System.Collections.Generic;

namespace MRGGameTek.BusinessLogic
{
    public class CustomerService: ICustomerService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        private ICustomerFactory _customerFactory;
        public void AddCustomer(CustomerType customerType, Dictionary<string,string> customer)
        {
            SetCustomerFactory(customerType);
            if (_customerFactory == null) throw new Exception("Customer factory is not set");
            _customerFactory.Create(customer);
        }

        private void SetCustomerFactory(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.mrgreen:
                    _customerFactory = new MgGreenCustomerFactory(_applicationDbContext);
                    break;
                case CustomerType.redbet:
                    _customerFactory = new RedbetCustomerFactory(_applicationDbContext);
                    break;
                default:
                    break;
            }
        }
    }
}
