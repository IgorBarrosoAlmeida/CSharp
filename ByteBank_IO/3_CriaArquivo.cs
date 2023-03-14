using ByteBankIO;
using System.Text;

partial class Program {
    public static void CriarArquivo() {
        string diretorioNovoArquivo = "./contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(diretorioNovoArquivo, FileMode.Create)) {
            string contaComoString = "456,7895,4785.40,Gustavo Santos";

            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    public static void CriarArquivoComWriter() {
        string diretorioNovoArquivo = "./contasExportadas.csv";

        
        using(var fluxoDeArquivo = new FileStream(diretorioNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo)) {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    public static void TestaEscrita() {
        var diretorioNovoArquivo = "teste.txt";

        using(var fluxoDeArquivo = new FileStream(diretorioNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo)) {
            for(int i = 0; i < 10000; i++) {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();

                System.Console.WriteLine($"Linha {i} foi escrita");
                System.Console.ReadLine();
            }
        }
    }
}