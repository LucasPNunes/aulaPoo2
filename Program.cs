using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("Cassio", 1000);
            conta.Depositar(100);
            conta.Sacar(300);
            conta.Sacar(1000);
            conta.Depositar(600);
            Console.WriteLine(conta.Log);
        }
    }
}
