using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MRGGameTek.Abstract;
using MRGGameTek.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MRGGameTek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("{customerType}")]
        public void Post(CustomerType customerType, [FromBody] Dictionary<string, string> customerDict)
        {
            _customerService.AddCustomer(customerType, customerDict);
        }
    }
}


