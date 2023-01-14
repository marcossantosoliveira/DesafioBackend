using DesafioBackend.Domain.Entities;
using DesafioBackend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioBackend.Infra.Data
{
    public class ClienteRepository: IClienteRepository
    {

        private ApplicationDbContext _contexto;

        public ClienteRepository(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public Guid CriarCliente(Clientes cliente)
        {
           var clienteId = _contexto.Clientes.Add(cliente).Entity.Id;

            _contexto.SaveChanges();

            return clienteId;
        }

        public Clientes ObterClientePorEmail(string email)
        {
            var cliente = _contexto.Clientes.FirstOrDefault(f => f.Email == email);

            return cliente;
        }

        public Clientes ObterClientePorId(Guid id)
        {
            var cliente = _contexto.Clientes.Find(id);

            return cliente;
        }
    }
}
