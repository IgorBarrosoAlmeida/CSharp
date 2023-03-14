using ByteBankIO;
using System.Text;

partial class Program {
    public static void EscritaBinaria() {
        string diretorioArquivo = "./contaCorrente.txt";

        using(var fs = new FileStream(diretorioArquivo, FileMode.Create))
        using(var escritor = new BinaryWriter(fs)) {
            escritor.Write(456);                    // Num agencia
            escritor.Write(546544);                 // Num conta
            escritor.Write(4000.50);                // Saldo
            escritor.Write("Gustavo braga");        // Nome
        }
    }

    public static void LeituraBinaria() {
        string diretorioArquivo = "./contaCorrente.txt";

        using(var fs = new FileStream(diretorioArquivo, FileMode.Open))
        using(var leitor = new BinaryReader(fs)) {
            var agencia = leitor.ReadInt32();
            var numeroConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();
        
            System.Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
        }
    }
}