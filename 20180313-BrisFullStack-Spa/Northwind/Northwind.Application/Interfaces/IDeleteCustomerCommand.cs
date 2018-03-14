using System.Threading.Tasks;

namespace Northwind.Application.Interfaces
{
    public interface IDeleteCustomerCommand
    {
        Task Execute(string id);
    }
}
