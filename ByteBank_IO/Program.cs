using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var diretorioArquivo = "./contas.txt";
        var fluxoDoArquivo = new FileStream(diretorioArquivo, FileMode.Open);

        var buffer = new byte[1024]; // 1 KB

        fluxoDoArquivo.Read(buffer, 0, 1024);
        Console.ReadLine();
    }
}