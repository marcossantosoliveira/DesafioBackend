using DesafioBackend.application;
using DesafioBackend.application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackend.Apis.Web.Cliente
{
    [Route("v1/desafio/backend")]
    [ApiController]
    public class ObterCotacaoMoedaController : ControllerBase
    {

        private readonly IClienteService _clienteService;

        public ObterCotacaoMoedaController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost("cliente")]
        public async Task<ActionResult<Guid>> CriarClienteAsync(
        [FromBody] ClienteCriarDto cliente
        )
        {            
                 var cli = new ClienteServiceDto()
                 {
                     Nome = cliente.Nome,
                     Email = cliente.Email,
                     MultiplicadorBase = cliente.MultiplicadorBase
                 };

            var clienteId = _clienteService.CriarCliente(cli);

            return Ok(clienteId);
        }
    }
}
