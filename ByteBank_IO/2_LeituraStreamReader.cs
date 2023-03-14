using ByteBankIO;

partial class Program
{
    static void LeituraStreamReader() {
        var diretorioArquivo = "./contas.txt";

        using(var fluxoDeArquivo = new FileStream(diretorioArquivo, FileMode.Open)) {
            var leitor = new StreamReader(fluxoDeArquivo);
            
            /*
            var linha = leitor.ReadLine();
            Console.WriteLine(linha);
            */
            
            /*
            var texto = leitor.ReadToEnd();
            Console.WriteLine(texto);
            */

            while(!leitor.EndOfStream) {
                var linha = leitor.ReadLine();
                var conta = ConverterStringParaContaCorrente(linha);
                
                var msg = $"Conta número {conta.Numero}, agencia {conta.Agencia}, saldo {conta.Saldo}";

                Console.WriteLine(msg);
            }
        }

        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha) {
        // 375,4644,2483.13,Jonatan
        var campos = linha.Split(',');

        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace('.', ','));
        var nomeTitular = campos[3];


        var resultado = new ContaCorrente(agencia, numero);
        resultado.Depositar(saldo);

        Cliente titular = new Cliente();
        titular.Nome = nomeTitular;

        resultado.Titular = titular;

        return resultado;
    }
    
}