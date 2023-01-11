using System;

namespace bytebank {
    class Program {
        public static void Main(string[] args) {
            ContaCorrente conta = new ContaCorrente();

            conta.id = "140b";
            Console.WriteLine(conta.id);
        }
    }
}