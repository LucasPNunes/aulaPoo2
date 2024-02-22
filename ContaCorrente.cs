using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public string Proprietario { get; private set; }
        public string Log { get; private set; }

        public ContaCorrente(string proprietario ,double saldo )
        {
            this.Saldo = saldo;
            this.Proprietario = proprietario;
            this.Log = $"EXTRATO DE {proprietario}.\n";
        }

        public Boolean Sacar(double valorSaque)
        {
            if (Saldo >= valorSaque)
            {
                this.Saldo -= valorSaque;
                Console.WriteLine("Saque realizado.");
                log($"\nSaque realizado no valor de {valorSaque}.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                log($"\nTentativa de Saque no valor de {valorSaque}. Saldo insuficiente.");
                return false;
            }
        }

        public Boolean Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Deposito realizado.");
            log($"\nDeposito realizado no valor de {valorDeposito}.");
            return true;
        }

        public void log(string dado)
        {
            this.Log += dado;
        }
    }
}
