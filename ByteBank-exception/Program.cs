using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_exception.Exceptions;

namespace ByteBank_exception {
    class Program {
        static void Main(string[] args) {
            try {
                ContaCorrente conta = new ContaCorrente(123, 9);
                conta.Depositar(100);
                System.Console.WriteLine("Saldo: " + conta.Saldo);

                conta.Sacar(150);
            } catch (ArgumentException ex) {
                Console.WriteLine("Erro no parametro: " + ex.ParamName);
            }
            catch (SaldoInsuficienteException ex) {
                Console.WriteLine(ex.Message + " Saldo: R$" + ex.Saldo + " Valor saque: R$" + ex.ValorSaque);
            }

            Console.WriteLine("Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
