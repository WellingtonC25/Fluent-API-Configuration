using Elite.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elit.Services.Cliente
{
    public class ClienteService : IClienteService
    {
        private static ApplicationDbContext context;

        public ClienteService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task CreateCliente(Model.Cliente cliente)
        {
            await context.Clientes.AddAsync(cliente);
             await context.SaveChangesAsync();
        }

        public async Task DeleteCliente(int? Id)
        {
            var cliente = await context.Clientes.FindAsync(Id);
            context.Clientes.Remove(cliente);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Model.Cliente>> GetAll()
        {
            return await  context.Clientes.ToListAsync();
        }

        public async Task GetById(int? Id)
        {
            await context.Clientes.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task  UpdateCliente(Model.Cliente cliente)
        {
            context.Update(cliente);
           await context.SaveChangesAsync();
        }
    }
}
