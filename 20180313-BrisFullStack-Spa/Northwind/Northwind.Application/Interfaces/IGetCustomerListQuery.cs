using System.Collections.Generic;
using System.Threading.Tasks;
using Northwind.Application.ViewModels;

namespace Northwind.Application.Interfaces
{
    public interface IGetCustomerListQuery
    {
        Task<IEnumerable<CustomerListModel>> Execute();
    }
}