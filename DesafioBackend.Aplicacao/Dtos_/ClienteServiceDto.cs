using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.application
{
    public class ClienteServiceDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal MultiplicadorBase { get; set; }
    }
}
