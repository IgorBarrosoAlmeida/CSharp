using System;
using bytebank.Contas;
using bytebank.Titular;

namespace bytebank {
    class Program {
        public static void Main(string[] args) {
            ContaCorrente conta = new ContaCorrente();
            Cliente titular = new Cliente();

            titular.Nome = "Andre";
            titular.CPF = "123456789";
            titular.Profissao = "Professor";

            conta.Titular = titular;
            conta.Agencia = 15;
            conta.Depositar(1000);
            conta.Id = "1020-C";
            conta.ImprimeDados();
        }
    }
}