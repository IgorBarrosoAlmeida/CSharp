using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_exception {
    class Program {
        static void Main(string[] args) {
            try {
                ContaCorrente conta = new ContaCorrente(123, 0);
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
