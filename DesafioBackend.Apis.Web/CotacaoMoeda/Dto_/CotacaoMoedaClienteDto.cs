using DesafioBackend.Apis.Web.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackend.Apis.Web.CotacaoMoeda
{
    public class CotacaoMoedaClienteDto
    {
        public decimal ValorOriginal { get; set; }
        public string ValorComTaxa { get; set; }

        public ClienteDto Cliente { get; set; }

    }
}
