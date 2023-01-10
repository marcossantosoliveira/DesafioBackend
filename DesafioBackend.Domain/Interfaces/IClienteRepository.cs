using DesafioBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.Domain.Interfaces
{
    public interface IClienteRepository
    {

        public Guid CriarCliente(Clientes cliente);

        public Clientes ObterClientePorId(Guid id);

        public Clientes ObterClientePorEmail(string email);
    }
}
