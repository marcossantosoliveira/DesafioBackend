using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBackend.application.Services
{
    public interface ICotacaoMoedaService
    {
        CotacaoMoedaDto ObterCotacaoMoeda(Guid clienteId);

        CotacaoMoedaClienteDto ObterCotacaoMoeda(Guid clienteId, decimal valorCotadoEmReais);
    }
}
