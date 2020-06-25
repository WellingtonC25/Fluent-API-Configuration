using System.Collections.Generic;
using System.Threading.Tasks;
using Elit.Model;
namespace Elit.Services.Cliente
{
    public interface IClienteService
    {
        Task<IEnumerable<Elit.Model.Cliente>> GetAll();
        Task GetById( int? Id);
        Task UpdateCliente(Model.Cliente cliente);
        Task DeleteCliente(int? Id);
        Task CreateCliente(Model.Cliente cliente);
    }
}
