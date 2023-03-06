using bytebank.Modelos.Conta;
using System;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

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