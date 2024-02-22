using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class EnderecoProprietario
    {
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; } 

        public EnderecoProprietario(string cep, string rua, string numero)
        {
            this.cep = cep;
            this.rua = rua;
            this.numero = numero;
        }

        public EnderecoProprietario()
        {

        }
    }
}
