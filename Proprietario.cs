using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Proprietario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public EnderecoProprietario endereco;

        public Proprietario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = new EnderecoProprietario();
        }   
    }
}
