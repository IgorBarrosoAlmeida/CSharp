using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using System;

namespace bytebank_ADM {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();

            f1.Nome = "Pedro";
            f1.Cpf = "123456789";
            f1.Salario = 2000;

            f1.ImprimeDados();
            Console.WriteLine("Bonificação: " + f1.GetBonificacao());

            Diretor f2 = new Diretor();

            f2.Nome = "Paula";
            f2.Cpf = "987654321";
            f2.Salario = 5000;

            f2.ImprimeDados();
            Console.WriteLine("Bonificação: " + f2.GetBonificacao());

            GerenciadorBonificacao boni = new GerenciadorBonificacao();

            boni.Registrar(f1);
            boni.Registrar(f2);

            Console.WriteLine("Bonificação total: " + boni.TotalBonificacao);
        }
    }
}