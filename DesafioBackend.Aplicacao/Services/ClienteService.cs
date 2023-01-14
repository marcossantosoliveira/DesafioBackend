using DesafioBackend.Domain.Entities;
using DesafioBackend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.application.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _ClienteRepository;
        public ClienteService(IClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }

        public Guid CriarCliente(ClienteServiceDto cliente)
        {
            var cli = new Clientes() 

            {
                Nome = cliente.Nome,
                Email = cliente.Email,             
                MultiplicadorBase = cliente.MultiplicadorBase              
            };

            var clienteExistente = _ClienteRepository.ObterClientePorEmail(cli.Email);

            if(clienteExistente != null)
            {
                return clienteExistente.Id;
            }

            var clienteId = _ClienteRepository.CriarCliente(cli);

            return clienteId;
        }

        public ClienteServiceDto ObterClientePorEmail(string email)
        {
            var cliente = _ClienteRepository.ObterClientePorEmail(email);

            var cli = new ClienteServiceDto()
            {
                Email = cliente.Email,
                Nome = cliente.Nome,
                Id = cliente.Id,
                MultiplicadorBase = cliente.MultiplicadorBase
            };

            return cli;
        }

        public ClienteServiceDto ObterClientePorId(Guid id)
        {
            var cliente = _ClienteRepository.ObterClientePorId(id);

            var cli = new ClienteServiceDto()
            {
                Email = cliente.Email,
                Nome = cliente.Nome,
                Id = cliente.Id,
                MultiplicadorBase = cliente.MultiplicadorBase
            };

            return cli;
        }
    }
}
