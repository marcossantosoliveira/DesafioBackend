using DesafioBackend.Integrations.CotacaoMoedas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBackend.application.Services
{
    public class CotacaoMoedaService: ICotacaoMoedaService
    {

        private ICotacaoMoedasClient _cotacaoMoedaClient;
        private readonly IClienteService _clienteService;

        public CotacaoMoedaService(ICotacaoMoedasClient cotacaoMoedaClient,
                                   IClienteService clienteService)
        {
            _cotacaoMoedaClient = cotacaoMoedaClient;
            _clienteService = clienteService;
        }

        public CotacaoMoedaDto ObterCotacaoMoeda(Guid clienteId)
        {
            var cotacaoMoeda = _cotacaoMoedaClient.ObterCotacaoMoedaUSD();
            var cliente = _clienteService.ObterClientePorId(clienteId);

            var valorCotacao = new CotacaoMoedaDto
            {
                ValorOriginal = cotacaoMoeda.Result.USDBRL.Bid,
                ValorComTaxa = cotacaoMoeda.Result.USDBRL.Bid * cliente.MultiplicadorBase

            };

            return valorCotacao;
        }

        public CotacaoMoedaClienteDto ObterCotacaoMoeda(Guid clienteId, decimal valorCotadoEmReais)
        {
            var cotacaoMoeda = _cotacaoMoedaClient.ObterCotacaoMoedaBRL();
            var cliente = _clienteService.ObterClientePorId(clienteId);

            var valorCotacao = new CotacaoMoedaClienteDto
            {
                ValorOriginal = cotacaoMoeda.Result.USDBRL.Bid,
                ValorComTaxa = cotacaoMoeda.Result.USDBRL.Bid * cliente.MultiplicadorBase,
                ValorCotadoEmReais = valorCotadoEmReais,
                Cliente = new ClienteServiceDto()
                {
                    Nome = cliente.Nome,
                    Email = cliente.Email,
                    Id = cliente.Id
                }
            };

            return valorCotacao;
        }
    }
}
