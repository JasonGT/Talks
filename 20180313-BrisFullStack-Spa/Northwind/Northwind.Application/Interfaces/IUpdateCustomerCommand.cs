using System.Threading.Tasks;
using Northwind.Application.ViewModels;

namespace Northwind.Application.Interfaces
{
    public interface IUpdateCustomerCommand
    {
        Task Execute(UpdateCustomerModel model);
    }
}
