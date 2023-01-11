using System;
using bytebank.Contas;
using bytebank.Titular;

namespace bytebank {
    class Program {
        public static void Main(string[] args) {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.agencia = 15;
            conta.id = "140b";
            conta.saldo = 1000;

            conta.ImprimeDados();
        }
    }
}