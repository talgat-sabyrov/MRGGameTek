using MRGGameTek.Helpers;
using System.Collections.Generic;

namespace MRGGameTek.Abstract
{   
    public interface ICustomerService
    {
        public void AddCustomer(CustomerType customerType, Dictionary<string, string> customer);
    }
}
