using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBackend.Integrations.CotacaoMoedas
{
    public interface ICotacaoMoedasClient
    {
        Task<CotacaoMoedaDto> ObterCotacaoMoedaUSD();

        Task<CotacaoMoedaDto> ObterCotacaoMoedaBRL();
    }
}
