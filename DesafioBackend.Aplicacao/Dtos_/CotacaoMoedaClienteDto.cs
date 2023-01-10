using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.application
{
    public class CotacaoMoedaClienteDto
    {
        public decimal ValorOriginal { get; set; }
        public decimal ValorComTaxa { get; set; }
        public decimal ValorCotadoEmReais{ get; set; }
        public ClienteServiceDto Cliente { get; set; }
    }
}
