using bytebank.Modelos.Conta;
using System;
using bytebank_ATENDIMENTO.bytebank.util;

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
    array.AddConta(new ContaCorrente(888, "584923-A", 323));
    array.AddConta(new ContaCorrente(879, "584923-B", 2000));
    array.AddConta(new ContaCorrente(877, "584923-C", 650));
    array.AddConta(new ContaCorrente(855, "584923-D", 5));
    array.AddConta(new ContaCorrente(866, "584923-E", 3000));
    array.AddConta(new ContaCorrente(866, "584923-E", 5));
    array.AddConta(new ContaCorrente(888, "584923-A", 3000));
    array.AddConta(new ContaCorrente(879, "584923-B", 1230));
    array.AddConta(new ContaCorrente(877, "584923-C", 123));
    array.AddConta(new ContaCorrente(855, "584923-D", 1000));

    array.PrintArray();

    Console.WriteLine("Maior Saldo " + (array.MaiorSaldo()).Saldo);
}

TestaClasseArrayDeContas();