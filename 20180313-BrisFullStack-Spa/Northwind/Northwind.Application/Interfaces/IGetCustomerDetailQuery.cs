using System.Threading.Tasks;
using Northwind.Application.ViewModels;

namespace Northwind.Application.Interfaces
{
    public interface IGetCustomerDetailQuery
    {
        Task<CustomerDetailModel> Execute(string id);     
    }
}