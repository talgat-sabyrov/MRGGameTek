using MRGGameTek.Abstract;
using MRGGameTek.Helpers;
using MRGGameTek.Storage;
using MRGGameTek.Storage.Entities;
using System.Collections.Generic;

namespace MRGGameTek.BusinessLogic
{
    public class RedbetCustomerFactory : ICustomerFactory
    {
        private readonly ApplicationDbContext _dbContext;

        public RedbetCustomerFactory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Dictionary<string, string> customerDict)
        {
            var mrGreen = CustomerTypeConverter.Convert<RedbetCustomer>(customerDict);
            _dbContext.RedbetCustomers.Add(mrGreen);
            _dbContext.SaveChanges();
        }
    }
}
