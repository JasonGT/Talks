using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Application.Interfaces;
using Northwind.Application.ViewModels;
using Northwind.Domain;
using Northwind.Data;
using Northwind.Presentation.Filters;
using System.Net;

namespace Northwind.Presentation.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerListModel>>> GetCustomers(
            [FromServices] IGetCustomerListQuery query)
        {
            return Ok(await query.Execute());
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        [ValidateCustomerExists]
        public async Task<ActionResult<CustomerDetailModel>> GetCustomer(
            [FromServices] IGetCustomerDetailQuery query,
            string id)
        {
            return Ok(await query.Execute(id));
        }

        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult<CreateCustomerModel>> PostCustomer(
            [FromServices] ICreateCustomerCommand command,
            CreateCustomerModel customer)
        {
            await command.Execute(customer);

            return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        [ValidateCustomerExists]
        public async Task<ActionResult> PutCustomer(
            [FromServices] IUpdateCustomerCommand command,
            string id, 
            UpdateCustomerModel customer)
        {
            await command.Execute(customer);

            return NoContent();
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        [ValidateCustomerExists]
        public async Task<ActionResult> DeleteCustomer(
            [FromServices] IDeleteCustomerCommand command,
            string id)
        {
            await command.Execute(id);

            return NoContent();
        }
    }
}