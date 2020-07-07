using System.Collections.Generic;

namespace MRGGameTek.Abstract
{
    public interface ICustomerFactory
    {
        void Create(Dictionary<string,string> customerDict);
    }
}
