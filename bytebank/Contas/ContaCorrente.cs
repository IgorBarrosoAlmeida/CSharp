using bytebank.Titular;

namespace bytebank.Contas {
    public class ContaCorrente{
        // Atributos
        public Cliente Titular { get; set;}
        public String Id { get; set; }
        public int Agencia { get; set; }
        private double saldo;

        // Métodos
        public void Depositar(double valor){
            this.saldo += valor;
        }

        public bool Sacar(double valor) {
            if(valor > this.saldo){
                return false;
            } else{
                this.saldo -= valor;
                return true;
            }
        }

        public bool Transferir(ContaCorrente destinatario, double valor) {
            if(this.Sacar(valor)) {
                destinatario.Depositar(valor);
                return true;
            } else{
                return false;
            }
        }

        public void ImprimeDados() {
            System.Console.WriteLine("Titular: ");
            System.Console.WriteLine("   Nome: " + this.Titular.Nome + "\n   CPF: " + this.Titular.CPF + "\n   Profissão: " + this.Titular.Profissao);
            System.Console.WriteLine("ID da conta: " + this.Id);
            System.Console.WriteLine("Agência: " + this.Agencia);
            System.Console.WriteLine("Saldo: " + this.saldo);
        }
    }
}