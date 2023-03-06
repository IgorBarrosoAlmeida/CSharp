using bytebank.Modelos.Conta;
using System;
using bytebank_ATENDIMENTO.bytebank.util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
/*
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
*/

void TestaArrayContaCorrente() {
    ListaDeContasCorrentes array = new ListaDeContasCorrentes();

    // Adiciona contas
    array.addConta(new ContaCorrente(888, "584923-A"));
    array.addConta(new ContaCorrente(879, "584923-B"));
    array.addConta(new ContaCorrente(877, "584923-C"));
    array.addConta(new ContaCorrente(855, "584923-D"));
    array.addConta(new ContaCorrente(866, "584923-E"));
    array.addConta(new ContaCorrente(866, "584923-E"));
    array.addConta(new ContaCorrente(888, "584923-A"));
    array.addConta(new ContaCorrente(879, "584923-B"));
    array.addConta(new ContaCorrente(877, "584923-C"));
    array.addConta(new ContaCorrente(855, "584923-D"));

    array.printArray();
}

TestaArrayContaCorrente();