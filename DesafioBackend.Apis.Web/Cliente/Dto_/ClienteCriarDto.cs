using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackend.Apis.Web.Cliente
{
    public class ClienteCriarDto
    {        
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal MultiplicadorBase { get; set; }
    }
}
