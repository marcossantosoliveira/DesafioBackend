using DesafioBackend.application;
using DesafioBackend.application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackend.Apis.Web.CotacaoMoeda
{
    [Route("v1/desafio/backend")]
    [ApiController]
    public class ObterCotacaoMoedaController : ControllerBase
    {
        
        private readonly ICotacaoMoedaService _cotacaoMoedaService;

        public ObterCotacaoMoedaController(ICotacaoMoedaService cotacaoMoedaService)
        {
            _cotacaoMoedaService = cotacaoMoedaService;
        }

        [HttpGet("cliente/{clienteId}/cotacao")]
        public async Task<ActionResult<CotacaoMoedaDto>> ObterCotacaoMoedaAsync(        
        [FromRoute] Guid clienteId)
        {
            var cotacaoMoeda = _cotacaoMoedaService.ObterCotacaoMoeda(clienteId);
            return Ok(cotacaoMoeda);
        }

        [HttpPatch("cliente/{clienteId}/cotacao")]
        public async Task<ActionResult<CotacaoMoedaClienteDto>> ObterCotacaoMoedaAsync(
        [FromRoute] Guid clienteId,
        [FromBody] ValorCotadoDto valorCotado)
        {
            var cotacaoMoedaCliente = _cotacaoMoedaService.ObterCotacaoMoeda(clienteId, valorCotado.ValorCotadoEmReais);            

            return Ok(cotacaoMoedaCliente);
        }
    }
}
