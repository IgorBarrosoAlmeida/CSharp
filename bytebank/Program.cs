using System;
using bytebank.Contas;
using bytebank.Titular;

namespace bytebank {
    class Program {
        public static void Main(string[] args) {
            ContaCorrente conta = new ContaCorrente(18, "1010-X");
            ContaCorrente conta2 = new ContaCorrente(15, "2222-Y");
            Cliente titular = new Cliente();
            Cliente titular2 = new Cliente();

            titular.Nome = "Andre";
            titular.CPF = "123456789";
            titular.Profissao = "Professor";
            
            titular2.Nome = "Paulo";
            titular2.CPF = "987654321";
            titular2.Profissao = "Analista";

            conta.Titular = titular;
            conta2.Titular = titular2;
            conta.Depositar(1000);
            conta.Depositar(300);
            conta.ImprimeDados();
            conta2.ImprimeDados();
            Console.WriteLine("Total de contas: " + ContaCorrente.totalContas);
        }
    }
}