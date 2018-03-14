using System.Threading.Tasks;
using Northwind.Application.ViewModels;

namespace Northwind.Application.Interfaces
{
    public interface ICreateCustomerCommand
    {
        Task Execute(CreateCustomerModel model);
    }
}
