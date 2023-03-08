using bytebank.Modelos.Conta;
using System;
using System.Collections;
using bytebank_ATENDIMENTO.bytebank.util;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

#region Exemplo 
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArrayContaCorrente() {
    ContaCorrente[] contas = new ContaCorrente[]
    {
        new ContaCorrente(888, "584923-A"),
        new ContaCorrente(879, "584923-B"),
        new ContaCorrente(877, "584923-C")
    };

    int cont = 0;

    foreach(var conta in contas) {
        Console.WriteLine($"Conta[{cont}]: {conta.Id}");
        cont++;
    }
}

void TestaClasseArrayDeContas() {
    ListaDeContasCorrentes array = new ListaDeContasCorrentes();

    // Adiciona contas
    ContaCorrente c1 = new ContaCorrente(888, "584923-A", 3254);
    ContaCorrente c2 = new ContaCorrente(879, "584923-B", 2022);
    ContaCorrente c3 = new ContaCorrente(877, "584923-C", 654);
    ContaCorrente c4 = new ContaCorrente(855, "584923-D", 50);
    ContaCorrente c5 = new ContaCorrente(700, "584923-E", 5012);

    array.AddConta(c1);
    array.AddConta(c2);
    array.AddConta(c3);
    array.AddConta(c4);
    array.AddConta(c5);
    /*
    array.AddConta(new ContaCorrente(866, "584923-E", 3000));
    array.AddConta(new ContaCorrente(866, "584923-E", 5));
    array.AddConta(new ContaCorrente(888, "584923-A", 3000));
    array.AddConta(new ContaCorrente(879, "584923-B", 1230));
    array.AddConta(new ContaCorrente(877, "584923-C", 123));
    array.AddConta(new ContaCorrente(855, "584923-D", 1000));
    */
    
    Console.WriteLine("======================");
    array.PrintArray();

    Console.WriteLine("Maior Saldo " + (array.MaiorSaldo()).Saldo);

    array.Remover(c3);
    
    // Printa info
    Console.WriteLine("======================");
    array.PrintArray();

    
    array.Remover(c2);
    
    // Printa info
    Console.WriteLine("======================");
    array.PrintArray();

    Console.WriteLine("Maior Saldo " + (array.MaiorSaldo()).Saldo);
}

//TestaClasseArrayDeContas();
#endregion

List<ContaCorrente> listaDeContas = new List<ContaCorrente>();
void Atendimento() {
    char opcao = '0';
    try {
        while(opcao != '6') {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do sistema      ===");
            try {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception ex) {
                throw new ByteBankException(ex.Message);
            }

            switch(opcao) {
                case '1': 
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    break;
                case '4': 
                    break;
                case '5': 
                    break;
                case '6': 
                    break;
                default: 
                    Console.WriteLine("Numero invalido");
                    break;
            }
        }
    }
    catch(ByteBankException ex) {
        Console.WriteLine($"{ex.Message}");
    }

}

#region Funções
void CadastrarConta() {
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}


#endregion

Atendimento();