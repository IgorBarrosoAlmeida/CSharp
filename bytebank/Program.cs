using System;

namespace bytebank {
    class Program {
        public static void Main(string[] args) {
            ContaCorrente conta = new ContaCorrente();

            conta.agencia = 15;
            conta.id = "140b";
            conta.saldo = 1000;

            conta.ImprimeDados();
        }
    }
}