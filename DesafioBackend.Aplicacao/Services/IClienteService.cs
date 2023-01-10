using DesafioBackend.Domain.Entities;
using DesafioBackend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.application.Services
{
    public interface IClienteService
    {

        public Guid CriarCliente(ClienteServiceDto cliente);

        public ClienteServiceDto ObterClientePorEmail(string email);


        public ClienteServiceDto ObterClientePorId(Guid id);
       

    }
}
