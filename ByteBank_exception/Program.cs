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
                ContaCorrente conta = new ContaCorrente(312,54);
                ContaCorrente conta2 = new ContaCorrente(123,44);
                
                conta.Depositar(50);
                Console.WriteLine("Conta 1: " + conta.Saldo);
                conta.Transferir(500, conta2);
                Console.WriteLine("Conta 1: " + conta.Saldo);
            } 
            catch (ArgumentException ex) {
                Console.WriteLine("Erro no parametro: " + ex.ParamName);
            }
            catch (OperacaoFinanceiraException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações da  INNER EXCEPTION (exceção interna): ");

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }

            Console.WriteLine("Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
