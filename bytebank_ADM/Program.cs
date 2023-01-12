using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using System;
/*
namespace bytebank_ADM {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario("123456789", 2000);
            Diretor f2 = new Diretor("987654321", 5000);

            f1.Nome = "Pedro";
            // f1.Cpf = "345123";
            // f1.Salario = 2000;
            f2.Nome = "Paula";
            // f2.Cpf = "12312";
            // f2.Salario = 5000;

            f1.ImprimeDados();
            f2.ImprimeDados();

            GerenciadorBonificacao boni = new GerenciadorBonificacao();

            boni.Registrar(f1);
            boni.Registrar(f2);

            Console.WriteLine("Bonificação total: " + boni.TotalBonificacao);
            f1.AumentarSalario();
            f2.AumentarSalario();
            Console.WriteLine("Salario Pedro pós aumento: " + f1.Salario);
            Console.WriteLine("Salario Paula pós aumento: " + f2.Salario);
        }
    }
}
*/

void CalcularBonificacao() {
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Diretor diretor = new Diretor("123456");
    diretor.Nome = "Igor Barroso";

    Designer designer = new Designer("987654");
    designer.Nome = "Leandro Rodrigues";

    GerenteDeContas gerente = new GerenteDeContas("763412");
    gerente.Nome = "Júlia Almeida";

    Auxiliar auxiliar = new Auxiliar("543135");
    auxiliar.Nome = "João Pedro";

    gerenciador.Registrar(diretor);
    gerenciador.Registrar(designer);
    gerenciador.Registrar(gerente);
    gerenciador.Registrar(auxiliar);

    Console.WriteLine("Total de Bonificações: " + gerenciador.TotalBonificacao);
}

CalcularBonificacao();