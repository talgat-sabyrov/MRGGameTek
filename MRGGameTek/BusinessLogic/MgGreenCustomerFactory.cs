using MRGGameTek.Abstract;
using MRGGameTek.Helpers;
using MRGGameTek.Storage;
using MRGGameTek.Storage.Entities;
using System.Collections.Generic;

namespace MRGGameTek.BusinessLogic
{
    public class MgGreenCustomerFactory : ICustomerFactory
    {
        private readonly ApplicationDbContext _dbContext;

        public MgGreenCustomerFactory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Dictionary<string, string> customerDict)
        {
            var mrGreen = CustomerTypeConverter.Convert<MrGreenCustomer>(customerDict);
            _dbContext.MrGreenCustomers.Add(mrGreen);
            _dbContext.SaveChanges();
        }
    }
}
